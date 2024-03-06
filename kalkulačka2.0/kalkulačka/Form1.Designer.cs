namespace kalkulačka
{
    partial class Form1
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
            this.textBoxCislo1 = new System.Windows.Forms.TextBox();
            this.textBoxCislo2 = new System.Windows.Forms.TextBox();
            this.labelRovnase = new System.Windows.Forms.Label();
            this.textBoxVysledek = new System.Windows.Forms.TextBox();
            this.listBoxOperator = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonRovnase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCislo1
            // 
            this.textBoxCislo1.Location = new System.Drawing.Point(46, 38);
            this.textBoxCislo1.Name = "textBoxCislo1";
            this.textBoxCislo1.Size = new System.Drawing.Size(141, 20);
            this.textBoxCislo1.TabIndex = 0;
            // 
            // textBoxCislo2
            // 
            this.textBoxCislo2.Location = new System.Drawing.Point(320, 38);
            this.textBoxCislo2.Name = "textBoxCislo2";
            this.textBoxCislo2.Size = new System.Drawing.Size(125, 20);
            this.textBoxCislo2.TabIndex = 1;
            // 
            // labelRovnase
            // 
            this.labelRovnase.AutoSize = true;
            this.labelRovnase.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRovnase.Location = new System.Drawing.Point(488, 28);
            this.labelRovnase.Name = "labelRovnase";
            this.labelRovnase.Size = new System.Drawing.Size(43, 46);
            this.labelRovnase.TabIndex = 3;
            this.labelRovnase.Text = "=";
            // 
            // textBoxVysledek
            // 
            this.textBoxVysledek.Location = new System.Drawing.Point(591, 35);
            this.textBoxVysledek.Name = "textBoxVysledek";
            this.textBoxVysledek.Size = new System.Drawing.Size(128, 20);
            this.textBoxVysledek.TabIndex = 4;
            // 
            // listBoxOperator
            // 
            this.listBoxOperator.FormattingEnabled = true;
            this.listBoxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "*/*"});
            this.listBoxOperator.Location = new System.Drawing.Point(209, 39);
            this.listBoxOperator.Name = "listBoxOperator";
            this.listBoxOperator.Size = new System.Drawing.Size(60, 56);
            this.listBoxOperator.TabIndex = 5;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(46, 139);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(49, 53);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnswer.Location = new System.Drawing.Point(118, 139);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(49, 53);
            this.buttonAnswer.TabIndex = 7;
            this.buttonAnswer.Text = "Ans";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(46, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(118, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(192, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(45, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 53);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(118, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 53);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(192, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 53);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(45, 374);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 53);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(118, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 53);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(192, 374);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 53);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(118, 457);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(49, 53);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonRovnase
            // 
            this.buttonRovnase.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRovnase.Location = new System.Drawing.Point(192, 139);
            this.buttonRovnase.Name = "buttonRovnase";
            this.buttonRovnase.Size = new System.Drawing.Size(49, 53);
            this.buttonRovnase.TabIndex = 18;
            this.buttonRovnase.Text = "=";
            this.buttonRovnase.UseVisualStyleBackColor = true;
            this.buttonRovnase.Click += new System.EventHandler(this.buttonRovnase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.buttonRovnase);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxOperator);
            this.Controls.Add(this.textBoxVysledek);
            this.Controls.Add(this.labelRovnase);
            this.Controls.Add(this.textBoxCislo2);
            this.Controls.Add(this.textBoxCislo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCislo1;
        private System.Windows.Forms.TextBox textBoxCislo2;
        private System.Windows.Forms.Label labelRovnase;
        private System.Windows.Forms.TextBox textBoxVysledek;
        private System.Windows.Forms.ListBox listBoxOperator;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonRovnase;
    }
}

