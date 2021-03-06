using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MultiplyMatrix
{
    class Multiply
    {
        int tmp = 0;
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
        public TextBox[,] multiply(TextBox[,] textbox1, TextBox[,] textbox2)
        {
            TextBox[,] c = new TextBox[textbox1.GetLength(0), textbox2.GetLength(1)];
            for(int i = 0; i < textbox1.GetLength(0); i++)
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
    }
}
