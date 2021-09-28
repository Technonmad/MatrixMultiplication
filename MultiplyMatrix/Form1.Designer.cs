namespace MultiplyMatrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrix1C = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matrix1R = new System.Windows.Forms.TextBox();
            this.matrix2R = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matrix2C = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.matrixPanel2 = new System.Windows.Forms.Panel();
            this.matrixPanel3 = new System.Windows.Forms.Panel();
            this.matrixPanel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность матриц:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Матрица 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Матрица 1:";
            // 
            // matrix1C
            // 
            this.matrix1C.Location = new System.Drawing.Point(109, 43);
            this.matrix1C.Name = "matrix1C";
            this.matrix1C.Size = new System.Drawing.Size(28, 20);
            this.matrix1C.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "x";
            // 
            // matrix1R
            // 
            this.matrix1R.Location = new System.Drawing.Point(166, 43);
            this.matrix1R.Name = "matrix1R";
            this.matrix1R.Size = new System.Drawing.Size(28, 20);
            this.matrix1R.TabIndex = 5;
            // 
            // matrix2R
            // 
            this.matrix2R.Location = new System.Drawing.Point(166, 72);
            this.matrix2R.Name = "matrix2R";
            this.matrix2R.Size = new System.Drawing.Size(28, 20);
            this.matrix2R.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "x";
            // 
            // matrix2C
            // 
            this.matrix2C.Location = new System.Drawing.Point(109, 72);
            this.matrix2C.Name = "matrix2C";
            this.matrix2C.Size = new System.Drawing.Size(28, 20);
            this.matrix2C.TabIndex = 6;
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(16, 144);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(205, 54);
            this.warningLabel.TabIndex = 9;
            this.warningLabel.Text = "label6";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(19, 109);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(100, 109);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Расчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // matrixPanel2
            // 
            this.matrixPanel2.AutoScroll = true;
            this.matrixPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrixPanel2.Location = new System.Drawing.Point(534, 9);
            this.matrixPanel2.Name = "matrixPanel2";
            this.matrixPanel2.Size = new System.Drawing.Size(279, 223);
            this.matrixPanel2.TabIndex = 12;
            // 
            // matrixPanel3
            // 
            this.matrixPanel3.AutoScroll = true;
            this.matrixPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrixPanel3.Location = new System.Drawing.Point(840, 9);
            this.matrixPanel3.Name = "matrixPanel3";
            this.matrixPanel3.Size = new System.Drawing.Size(279, 223);
            this.matrixPanel3.TabIndex = 12;
            // 
            // matrixPanel1
            // 
            this.matrixPanel1.AutoScroll = true;
            this.matrixPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrixPanel1.Location = new System.Drawing.Point(227, 9);
            this.matrixPanel1.Name = "matrixPanel1";
            this.matrixPanel1.Size = new System.Drawing.Size(279, 223);
            this.matrixPanel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(508, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(814, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 244);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.matrixPanel1);
            this.Controls.Add(this.matrixPanel3);
            this.Controls.Add(this.matrixPanel2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.matrix2R);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrix2C);
            this.Controls.Add(this.matrix1R);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matrix1C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Matrix multiplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matrix1C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox matrix1R;
        private System.Windows.Forms.TextBox matrix2R;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox matrix2C;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel matrixPanel2;
        private System.Windows.Forms.Panel matrixPanel3;
        private System.Windows.Forms.Panel matrixPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

