namespace MathFlashCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lblOperation = new Label();
            panel1 = new Panel();
            lblSelect = new Label();
            lblWrongRigth = new Label();
            lblOption1 = new Label();
            lblOption2 = new Label();
            lblOption3 = new Label();
            lblOption4 = new Label();
            lblOption5 = new Label();
            lblOption6 = new Label();
            lblPlayAgain = new Label();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Segoe UI", 99.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber1.Location = new Point(181, 9);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(146, 175);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "1";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 99.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber2.Location = new Point(181, 184);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(146, 175);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "1";
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperation.Location = new Point(12, 223);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(107, 128);
            lblOperation.TabIndex = 2;
            lblOperation.Text = "x";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(7, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 10);
            panel1.TabIndex = 3;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelect.Location = new Point(49, 377);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(273, 50);
            lblSelect.TabIndex = 4;
            lblSelect.Text = "Select a answer";
            // 
            // lblWrongRigth
            // 
            lblWrongRigth.AutoSize = true;
            lblWrongRigth.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWrongRigth.Location = new Point(167, 358);
            lblWrongRigth.Name = "lblWrongRigth";
            lblWrongRigth.Size = new Size(189, 32);
            lblWrongRigth.TabIndex = 5;
            lblWrongRigth.Text = "Select a answer";
            // 
            // lblOption1
            // 
            lblOption1.AutoSize = true;
            lblOption1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblOption1.Location = new Point(27, 438);
            lblOption1.Name = "lblOption1";
            lblOption1.Size = new Size(80, 65);
            lblOption1.TabIndex = 6;
            lblOption1.Text = "21";
            lblOption1.Click += lblOption_Click;
            // 
            // lblOption2
            // 
            lblOption2.AutoSize = true;
            lblOption2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblOption2.Location = new Point(137, 438);
            lblOption2.Name = "lblOption2";
            lblOption2.Size = new Size(80, 65);
            lblOption2.TabIndex = 7;
            lblOption2.Text = "21";
            lblOption2.Click += lblOption_Click;
            // 
            // lblOption3
            // 
            lblOption3.AutoSize = true;
            lblOption3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblOption3.Location = new Point(251, 438);
            lblOption3.Name = "lblOption3";
            lblOption3.Size = new Size(80, 65);
            lblOption3.TabIndex = 8;
            lblOption3.Text = "21";
            lblOption3.Click += lblOption_Click;
            // 
            // lblOption4
            // 
            lblOption4.AutoSize = true;
            lblOption4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblOption4.Location = new Point(27, 511);
            lblOption4.Name = "lblOption4";
            lblOption4.Size = new Size(80, 65);
            lblOption4.TabIndex = 9;
            lblOption4.Text = "21";
            lblOption4.Click += lblOption_Click;
            // 
            // lblOption5
            // 
            lblOption5.AutoSize = true;
            lblOption5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblOption5.Location = new Point(137, 511);
            lblOption5.Name = "lblOption5";
            lblOption5.Size = new Size(80, 65);
            lblOption5.TabIndex = 10;
            lblOption5.Text = "21";
            lblOption5.Click += lblOption_Click;
            // 
            // lblOption6
            // 
            lblOption6.AutoSize = true;
            lblOption6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblOption6.Location = new Point(251, 511);
            lblOption6.Name = "lblOption6";
            lblOption6.Size = new Size(80, 65);
            lblOption6.TabIndex = 11;
            lblOption6.Text = "21";
            lblOption6.Click += lblOption_Click;
            // 
            // lblPlayAgain
            // 
            lblPlayAgain.AutoSize = true;
            lblPlayAgain.BackColor = Color.FromArgb(192, 255, 192);
            lblPlayAgain.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayAgain.ForeColor = Color.FromArgb(0, 192, 0);
            lblPlayAgain.Location = new Point(29, 389);
            lblPlayAgain.Name = "lblPlayAgain";
            lblPlayAgain.Size = new Size(319, 46);
            lblPlayAgain.TabIndex = 12;
            lblPlayAgain.Text = "Wanna play again?";
            lblPlayAgain.Click += lblPlayAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 585);
            Controls.Add(lblPlayAgain);
            Controls.Add(lblOption6);
            Controls.Add(lblOption5);
            Controls.Add(lblOption4);
            Controls.Add(lblOption3);
            Controls.Add(lblOption2);
            Controls.Add(lblOption1);
            Controls.Add(lblWrongRigth);
            Controls.Add(lblSelect);
            Controls.Add(panel1);
            Controls.Add(lblOperation);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Flash Cards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private Label lblOperation;
        private Panel panel1;
        private Label lblSelect;
        private Label lblWrongRigth;
        private Label lblOption1;
        private Label lblOption2;
        private Label lblOption3;
        private Label lblOption4;
        private Label lblOption5;
        private Label lblOption6;
        private Label lblPlayAgain;
    }
}