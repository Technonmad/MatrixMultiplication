using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplyMatrix
{
    public partial class Form1 : Form
    {
        MakeMatrixes makeMatrixes = new MakeMatrixes();
        Multiply multiply = new Multiply();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
            calculateButton.Enabled = false;
            multiply.makeThreads(mat);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            makeMatrixes.checkParameters(matrixPanel1, matrixPanel2, matrixPanel3, matrix1C, matrix1R, matrix2C, matrix2R, warningLabel, calculateButton);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            makeMatrixes.multiply(matrixPanel3, warningLabel);
        }

       
    }
}
