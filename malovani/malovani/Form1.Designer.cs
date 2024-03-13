namespace malovani
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonSpray = new System.Windows.Forms.Button();
            this.buttonVoskovka = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelColors = new System.Windows.Forms.Panel();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.pictureBoxPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxGray = new System.Windows.Forms.PictureBox();
            this.pictureBoxRainbow = new System.Windows.Forms.PictureBox();
            this.panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRainbow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Move += new System.EventHandler(this.panel1_Move);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Location = new System.Drawing.Point(557, 35);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(76, 65);
            this.buttonPencil.TabIndex = 1;
            this.buttonPencil.Text = "Tužka";
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Location = new System.Drawing.Point(658, 35);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(76, 65);
            this.buttonBrush.TabIndex = 2;
            this.buttonBrush.Text = "Štětec";
            this.buttonBrush.UseVisualStyleBackColor = true;
            // 
            // buttonPen
            // 
            this.buttonPen.Location = new System.Drawing.Point(755, 35);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(76, 65);
            this.buttonPen.TabIndex = 3;
            this.buttonPen.Text = "Pero";
            this.buttonPen.UseVisualStyleBackColor = true;
            // 
            // buttonEraser
            // 
            this.buttonEraser.Location = new System.Drawing.Point(755, 110);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(76, 65);
            this.buttonEraser.TabIndex = 4;
            this.buttonEraser.Text = "Guma";
            this.buttonEraser.UseVisualStyleBackColor = true;
            // 
            // buttonSpray
            // 
            this.buttonSpray.Location = new System.Drawing.Point(658, 110);
            this.buttonSpray.Name = "buttonSpray";
            this.buttonSpray.Size = new System.Drawing.Size(76, 65);
            this.buttonSpray.TabIndex = 5;
            this.buttonSpray.Text = "Sprej";
            this.buttonSpray.UseVisualStyleBackColor = true;
            // 
            // buttonVoskovka
            // 
            this.buttonVoskovka.Location = new System.Drawing.Point(557, 110);
            this.buttonVoskovka.Name = "buttonVoskovka";
            this.buttonVoskovka.Size = new System.Drawing.Size(76, 65);
            this.buttonVoskovka.TabIndex = 6;
            this.buttonVoskovka.Text = "Voskovka";
            this.buttonVoskovka.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 22);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(76, 65);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "Nové";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // panelColors
            // 
            this.panelColors.BackColor = System.Drawing.Color.White;
            this.panelColors.Controls.Add(this.pictureBoxRainbow);
            this.panelColors.Controls.Add(this.pictureBoxGray);
            this.panelColors.Controls.Add(this.pictureBoxPink);
            this.panelColors.Controls.Add(this.pictureBoxBlack);
            this.panelColors.Controls.Add(this.pictureBoxYellow);
            this.panelColors.Controls.Add(this.pictureBoxGreen);
            this.panelColors.Controls.Add(this.pictureBoxBlue);
            this.panelColors.Controls.Add(this.pictureBoxRed);
            this.panelColors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColors.Location = new System.Drawing.Point(557, 197);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(260, 131);
            this.panelColors.TabIndex = 8;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.Location = new System.Drawing.Point(14, 12);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(70, 12);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBlue.TabIndex = 1;
            this.pictureBoxBlue.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxGreen.Location = new System.Drawing.Point(133, 12);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxGreen.TabIndex = 2;
            this.pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.Location = new System.Drawing.Point(198, 12);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxYellow.TabIndex = 3;
            this.pictureBoxYellow.TabStop = false;
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.Location = new System.Drawing.Point(14, 71);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBlack.TabIndex = 4;
            this.pictureBoxBlack.TabStop = false;
            // 
            // pictureBoxPink
            // 
            this.pictureBoxPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBoxPink.Location = new System.Drawing.Point(70, 71);
            this.pictureBoxPink.Name = "pictureBoxPink";
            this.pictureBoxPink.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPink.TabIndex = 5;
            this.pictureBoxPink.TabStop = false;
            // 
            // pictureBoxGray
            // 
            this.pictureBoxGray.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxGray.Location = new System.Drawing.Point(133, 71);
            this.pictureBoxGray.Name = "pictureBoxGray";
            this.pictureBoxGray.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxGray.TabIndex = 6;
            this.pictureBoxGray.TabStop = false;
            // 
            // pictureBoxRainbow
            // 
            this.pictureBoxRainbow.Location = new System.Drawing.Point(198, 71);
            this.pictureBoxRainbow.Name = "pictureBoxRainbow";
            this.pictureBoxRainbow.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxRainbow.TabIndex = 7;
            this.pictureBoxRainbow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1043, 775);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonVoskovka);
            this.Controls.Add(this.buttonSpray);
            this.Controls.Add(this.buttonEraser);
            this.Controls.Add(this.buttonPen);
            this.Controls.Add(this.buttonBrush);
            this.Controls.Add(this.buttonPencil);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRainbow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonSpray;
        private System.Windows.Forms.Button buttonVoskovka;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxPink;
        private System.Windows.Forms.PictureBox pictureBoxGray;
        private System.Windows.Forms.PictureBox pictureBoxRainbow;
    }
}

