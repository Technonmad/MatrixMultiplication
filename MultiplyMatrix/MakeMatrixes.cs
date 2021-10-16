using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplyMatrix
{
    class MakeMatrixes
    {
        int matrix1Columns, matrix1Rows, matrix2Columns, matrix2Rows;
        TextBox[,] textboxArray1, textboxArray2;
        Random rand = new Random();
        String newRand;


        public void checkParameters(Panel panel1, Panel panel2, Panel panel3, Panel panel4,TextBox textBox1,
            TextBox textBox2, TextBox textBox3, TextBox textBox4, Label label, Button btn, CheckBox checkBox)
        {
            
            btn.Enabled = false;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (Convert.ToInt32(textBox1.Text) < 2 || Convert.ToInt32(textBox2.Text) < 2
                || Convert.ToInt32(textBox3.Text) < 2 || Convert.ToInt32(textBox4.Text) < 2)
                {
                    label.Text = "Размер матриц не может быть меньше 2x2";
                    label.ForeColor = Color.Red;
                    label.Visible = true;
                    return;
                }
                else if(Convert.ToInt32(textBox2.Text) != Convert.ToInt32(textBox3.Text))
                {
                    label.Text = "Столбцы и строки не равны!";
                    label.ForeColor = Color.Red;
                    label.Visible = true;
                    return;
                }
                else
                {
                    makeSomeMatrixes(panel1, panel2, panel3, panel4, textBox1, textBox2, textBox3, textBox4, label, checkBox);
                    label.Visible = false;
                    btn.Enabled = true;
                }     
            }
            else
            {
                label.Text = "Заполните поля!";
                label.ForeColor = Color.Red;
                label.Visible = true;
                return;
            }
        }

        public void makeSomeMatrixes(Panel panel1, Panel panel2, Panel panel3, Panel panel4,TextBox textBox1,
            TextBox textBox2, TextBox textBox3, TextBox textBox4, Label label, CheckBox checkBox)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            try
            {
                matrix1Columns = Convert.ToInt32(textBox1.Text);
                matrix1Rows = Convert.ToInt32(textBox2.Text);
                matrix2Columns = Convert.ToInt32(textBox3.Text);
                matrix2Rows = Convert.ToInt32(textBox4.Text);

                textboxArray1 = new TextBox[matrix1Columns, matrix1Rows];
                textboxArray2 = new TextBox[matrix2Columns, matrix2Rows];

                for (int i = 0; i < matrix1Columns; i++)
                {
                    for (int j = 0; j < matrix1Rows; j++)
                    {
                        textboxArray1[i,j] = new TextBox();
                        textboxArray1[i, j].Name = "matr1_" + j + i;
                        textboxArray1[i, j].Width = 40;
                        textboxArray1[i, j].Location = new Point(textboxArray1[i, j].Width * j, i * 22);
                        panel1.Controls.Add(textboxArray1[i, j]);
                    }
                }
                for (int i = 0; i < matrix2Columns; i++)
                {
                    for (int j = 0; j < matrix2Rows; j++)
                    {
                        textboxArray2[i, j] = new TextBox();
                        textboxArray2[i, j].Name = "matr2_" + j + i;
                        textboxArray2[i, j].Width = 40;
                        textboxArray2[i, j].Location = new Point(textboxArray2[i, j].Width * j, i * 22);
                        panel2.Controls.Add(textboxArray2[i, j]);
                    }
                }
                if (checkBox.Checked)
                {
                    for (int i = 0; i < matrix1Columns; i++)
                    {
                        for (int j = 0; j < matrix1Rows; j++)
                        {
                            newRand = Convert.ToString(rand.Next(0, 100));
                            textboxArray1[i, j].Text = newRand;
                        }
                    }
                    for (int i = 0; i < matrix2Columns; i++)
                    {
                        for (int j = 0; j < matrix2Rows; j++)
                        {
                            newRand = Convert.ToString(rand.Next(0, 100));
                            textboxArray2[i, j].Text = newRand;
                        }
                    }
                }
            }
            catch(Exception)
            {
                label.Text = "Заполните поля!";
                label.ForeColor = Color.Red;
                label.Visible = true;
                return;
            }
           
        }

        public void multiply(Panel panel3, Panel panel4, Label label1, Label label2, Label label3)
        {
            try
           {
                Multiply mlt = new Multiply();
                if (mlt.checkValues(textboxArray1, textboxArray2, label1) == 1)
                {
                    mlt.showNewMatrix(mlt.multiply(textboxArray1, textboxArray2, label2), panel3);

                    mlt.showNewMatrix(mlt.makeThreads(textboxArray1, textboxArray2, label3), panel4);

                    label1.Visible = false;
                }
            }
            catch
            {
                label1.Text = "Заполните матрицы!";
                label1.ForeColor = Color.Red;
                label1.Visible = true;
            }
        }

    }
}
