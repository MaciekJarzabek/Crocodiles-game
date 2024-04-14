namespace Gra_LAB6
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(339, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(339, 183);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 80);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 5;
            label1.Text = "Plansza (od 3x3 do 10x10)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 80);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 6;
            label2.Text = "Dydelfy (od 1 do 6)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 106);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 7;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 186);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 8;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 286);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 9;
            label5.Text = "Czas (od 10 do 60 sek)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 160);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 10;
            label6.Text = "Krokodyle (od 0 do 1)";
            // 
            // button1
            // 
            button1.Location = new Point(286, 356);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 11;
            button1.Text = "Zapisz ustawienia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}