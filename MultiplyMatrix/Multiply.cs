using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace MultiplyMatrix
{
    class Multiply
    {
        int tmp = 0;
        static object locker = new object();
        Stopwatch stopwatch = new Stopwatch();

        public int checkValues(TextBox[,] textBox1, TextBox[,] textBox2, Label label)
        {
            int flag = 0;
            for(int i = 0; i < textBox1.GetLength(0); i++)
            {
                for(int j = 0; j < textBox1.GetLength(1); j++)
                {
                    if (textBox1[i, j].Text == "")
                    {
                        label.Text = "Заполните матрицы!";
                        label.ForeColor = Color.Red;
                        label.Visible = true;
                    }
                    else
                        flag = 1;
                }
            }
            return flag;
        }
        public TextBox[,] multiply(TextBox[,] textbox1, TextBox[,] textbox2, Label label)
        {
            label.Text = "";
            stopwatch.Start();

            TextBox[,] c = new TextBox[textbox1.GetLength(0), textbox2.GetLength(1)];
            for (int i = 0; i < textbox1.GetLength(0); i++)
            {
                tmp = 0;
                for(int j = 0; j < textbox2.GetLength(1); j++)
                {
                    tmp = 0;
                    for(int k = 0; k < textbox2.GetLength(0); k++)
                    {
                        c[i, j] = new TextBox();
                        tmp += Convert.ToInt32(textbox1[i, k].Text) * Convert.ToInt32(textbox2[k, j].Text);
                        c[i, j].Text = Convert.ToString(tmp);
                    }
                }
            }

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Seconds, ts.Milliseconds);
            label.Text = elapsedTime;
            label.Visible = true;
           
            return c;
        }

        public void showNewMatrix(TextBox[,] c, Panel panel3)
        {
            panel3.Controls.Clear();
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j].Location = new Point(c[i, j].Width * j, i * 22);
                    panel3.Controls.Add(c[i, j]);
                }
            }
        }

        public void threadMultiply(TextBox[,] textbox1, TextBox[,] textbox2, int a, int b, TextBox[,] d)
        {
            lock (locker)
            {
                for (int i = a; i < b; i++)
                {
                    tmp = 0;
                    for (int j = 0; j < textbox2.GetLength(1); j++)
                    {
                        tmp = 0;
                        for (int k = 0; k < textbox2.GetLength(0); k++)
                        {
                            d[i, j] = new TextBox();
                            tmp += Convert.ToInt32(textbox1[i, k].Text) * Convert.ToInt32(textbox2[k, j].Text);
                            d[i, j].Text = Convert.ToString(tmp);
                        }
                    }
                }
            }
            
        }

        

        public TextBox[,] makeThreads(TextBox[,] textbox1, TextBox[,] textbox2, Label label)
        {

            label.Text = "";
            TextBox[,] d = new TextBox[textbox1.GetLength(0), textbox2.GetLength(1)];
            Thread thread1 = new Thread(() => { int a = 0; int b = textbox1.GetLength(0) / 4; threadMultiply(textbox1, textbox2, a, b, d); });
            Thread thread2 = new Thread(() => { int a = textbox1.GetLength(0) / 4; int b = a * 2; threadMultiply(textbox1, textbox2, a, b, d); });
            Thread thread3 = new Thread(() => { int a = textbox1.GetLength(0) / 2; int b  = a + textbox1.GetLength(0) / 4; threadMultiply(textbox1, textbox2, a, b, d); });
            Thread thread4 = new Thread(() => {
                int a = textbox1.GetLength(0) / 2 + textbox1.GetLength(0) / 4;
                int b  = textbox1.GetLength(0); threadMultiply(textbox1, textbox2, a, b, d);
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            stopwatch.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Seconds, ts.Milliseconds);
            label.Text = elapsedTime;
            label.Visible = true;

            return d;

        }
    }
}
