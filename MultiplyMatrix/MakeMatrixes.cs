using System;
using System.Collections.Generic;
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

        public void checkParameters(Panel panel1, Panel panel2, Panel panel3, TextBox textBox1,
            TextBox textBox2, TextBox textBox3, TextBox textBox4, Label label, Button btn)
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
                    makeSomeMatrixes(panel1, panel2, panel3, textBox1, textBox2, textBox3, textBox4, label);
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

        public void makeSomeMatrixes(Panel panel1, Panel panel2, Panel panel3, TextBox textBox1,
            TextBox textBox2, TextBox textBox3, TextBox textBox4, Label label)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
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
            }
            catch
            {
                label.Text = "Заполните поля!";
                label.ForeColor = Color.Red;
                label.Visible = true;
                return;
            }
           
        }

        public void multiply(Panel panel3, Label label)
        {
            try
            {
                Multiply mlt = new Multiply();
                if (mlt.checkValues(textboxArray1, textboxArray2, label) == 1)
                {
                    mlt.showNewMatrix(mlt.multiply(textboxArray1, textboxArray2), panel3);
                    label.Visible = false;
                }
            }
            catch
            {
                label.Text = "Заполните матрицы!";
                label.ForeColor = Color.Red;
                label.Visible = true;
            }
        }
    }
}
