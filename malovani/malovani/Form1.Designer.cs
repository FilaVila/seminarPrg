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
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelColors = new System.Windows.Forms.Panel();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.textBoxPB = new System.Windows.Forms.TextBox();
            this.labelPB = new System.Windows.Forms.Label();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.labelVyska = new System.Windows.Forms.Label();
            this.labelSirka = new System.Windows.Forms.Label();
            this.textBoxVyska = new System.Windows.Forms.TextBox();
            this.textBoxSirka = new System.Windows.Forms.TextBox();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.pictureBoxCheck = new System.Windows.Forms.PictureBox();
            this.pictureBoxRainbow = new System.Windows.Forms.PictureBox();
            this.pictureBoxGray = new System.Windows.Forms.PictureBox();
            this.pictureBoxPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.buttonVoskovka = new System.Windows.Forms.Button();
            this.buttonSpray = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.panelColors.SuspendLayout();
            this.panelCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Move += new System.EventHandler(this.panel1_Move);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(76, 65);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "Nové";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
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
            this.panelColors.Size = new System.Drawing.Size(274, 131);
            this.panelColors.TabIndex = 8;
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.White;
            this.panelCheck.Controls.Add(this.pictureBoxCheck);
            this.panelCheck.Location = new System.Drawing.Point(491, 222);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(60, 60);
            this.panelCheck.TabIndex = 9;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSize.Location = new System.Drawing.Point(557, 417);
            this.trackBarSize.Maximum = 50;
            this.trackBarSize.Minimum = 3;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(274, 45);
            this.trackBarSize.SmallChange = 3;
            this.trackBarSize.TabIndex = 10;
            this.trackBarSize.Value = 3;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(703, 375);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(57, 20);
            this.textBoxSize.TabIndex = 11;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSize.TextChanged += new System.EventHandler(this.textBoxSize_TextChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(603, 370);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(94, 25);
            this.labelSize.TabIndex = 12;
            this.labelSize.Text = "Tloušťka:";
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Image = global::malovani.Properties.Resources.rectangle;
            this.buttonRectangle.Location = new System.Drawing.Point(491, 549);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(76, 65);
            this.buttonRectangle.TabIndex = 14;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // textBoxPB
            // 
            this.textBoxPB.Location = new System.Drawing.Point(602, 510);
            this.textBoxPB.Name = "textBoxPB";
            this.textBoxPB.Size = new System.Drawing.Size(92, 20);
            this.textBoxPB.TabIndex = 15;
            // 
            // labelPB
            // 
            this.labelPB.AutoSize = true;
            this.labelPB.BackColor = System.Drawing.Color.White;
            this.labelPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPB.Location = new System.Drawing.Point(599, 478);
            this.labelPB.Name = "labelPB";
            this.labelPB.Size = new System.Drawing.Size(98, 17);
            this.labelPB.TabIndex = 16;
            this.labelPB.Text = "Počáteční bod";
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(741, 572);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(90, 35);
            this.buttonPaint.TabIndex = 17;
            this.buttonPaint.Text = "Nakresli";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.BackColor = System.Drawing.Color.White;
            this.checkBoxFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxFill.Location = new System.Drawing.Point(615, 572);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(62, 21);
            this.checkBoxFill.TabIndex = 18;
            this.checkBoxFill.Text = "Výplň";
            this.checkBoxFill.UseVisualStyleBackColor = false;
            // 
            // labelVyska
            // 
            this.labelVyska.AutoSize = true;
            this.labelVyska.BackColor = System.Drawing.Color.White;
            this.labelVyska.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVyska.Location = new System.Drawing.Point(727, 478);
            this.labelVyska.Name = "labelVyska";
            this.labelVyska.Size = new System.Drawing.Size(46, 17);
            this.labelVyska.TabIndex = 19;
            this.labelVyska.Text = "Výška";
            // 
            // labelSirka
            // 
            this.labelSirka.AutoSize = true;
            this.labelSirka.BackColor = System.Drawing.Color.White;
            this.labelSirka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSirka.Location = new System.Drawing.Point(791, 478);
            this.labelSirka.Name = "labelSirka";
            this.labelSirka.Size = new System.Drawing.Size(42, 18);
            this.labelSirka.TabIndex = 20;
            this.labelSirka.Text = "Šířka";
            // 
            // textBoxVyska
            // 
            this.textBoxVyska.Location = new System.Drawing.Point(727, 510);
            this.textBoxVyska.Name = "textBoxVyska";
            this.textBoxVyska.Size = new System.Drawing.Size(46, 20);
            this.textBoxVyska.TabIndex = 21;
            // 
            // textBoxSirka
            // 
            this.textBoxSirka.Location = new System.Drawing.Point(791, 510);
            this.textBoxSirka.Name = "textBoxSirka";
            this.textBoxSirka.Size = new System.Drawing.Size(42, 20);
            this.textBoxSirka.TabIndex = 22;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Image = global::malovani.Properties.Resources.hiclipart_com__1_;
            this.buttonEllipse.Location = new System.Drawing.Point(491, 478);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(76, 65);
            this.buttonEllipse.TabIndex = 13;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // pictureBoxCheck
            // 
            this.pictureBoxCheck.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCheck.Location = new System.Drawing.Point(10, 9);
            this.pictureBoxCheck.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCheck.Name = "pictureBoxCheck";
            this.pictureBoxCheck.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCheck.TabIndex = 0;
            this.pictureBoxCheck.TabStop = false;
            // 
            // pictureBoxRainbow
            // 
            this.pictureBoxRainbow.Image = global::malovani.Properties.Resources.duha2;
            this.pictureBoxRainbow.Location = new System.Drawing.Point(216, 71);
            this.pictureBoxRainbow.Name = "pictureBoxRainbow";
            this.pictureBoxRainbow.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxRainbow.TabIndex = 7;
            this.pictureBoxRainbow.TabStop = false;
            this.pictureBoxRainbow.Click += new System.EventHandler(this.pictureBoxRainbow_Click);
            // 
            // pictureBoxGray
            // 
            this.pictureBoxGray.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxGray.Location = new System.Drawing.Point(146, 71);
            this.pictureBoxGray.Name = "pictureBoxGray";
            this.pictureBoxGray.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxGray.TabIndex = 6;
            this.pictureBoxGray.TabStop = false;
            this.pictureBoxGray.Click += new System.EventHandler(this.pictureBoxGray_Click);
            // 
            // pictureBoxPink
            // 
            this.pictureBoxPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBoxPink.Location = new System.Drawing.Point(80, 71);
            this.pictureBoxPink.Name = "pictureBoxPink";
            this.pictureBoxPink.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPink.TabIndex = 5;
            this.pictureBoxPink.TabStop = false;
            this.pictureBoxPink.Click += new System.EventHandler(this.pictureBoxPink_Click);
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.Location = new System.Drawing.Point(14, 71);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBlack.TabIndex = 4;
            this.pictureBoxBlack.TabStop = false;
            this.pictureBoxBlack.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.Location = new System.Drawing.Point(216, 12);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxYellow.TabIndex = 3;
            this.pictureBoxYellow.TabStop = false;
            this.pictureBoxYellow.Click += new System.EventHandler(this.pictureBoxYellow_Click);
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxGreen.Location = new System.Drawing.Point(146, 12);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxGreen.TabIndex = 2;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Click += new System.EventHandler(this.pictureBoxGreen_Click);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(80, 12);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBlue.TabIndex = 1;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlue_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.Location = new System.Drawing.Point(14, 12);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxRed_Click);
            // 
            // buttonVoskovka
            // 
            this.buttonVoskovka.Image = global::malovani.Properties.Resources.pngegg;
            this.buttonVoskovka.Location = new System.Drawing.Point(557, 110);
            this.buttonVoskovka.Name = "buttonVoskovka";
            this.buttonVoskovka.Size = new System.Drawing.Size(76, 65);
            this.buttonVoskovka.TabIndex = 6;
            this.buttonVoskovka.UseVisualStyleBackColor = true;
            this.buttonVoskovka.Click += new System.EventHandler(this.buttonVoskovka_Click);
            // 
            // buttonSpray
            // 
            this.buttonSpray.Image = global::malovani.Properties.Resources.spray_can_png_28843__1_;
            this.buttonSpray.Location = new System.Drawing.Point(658, 110);
            this.buttonSpray.Name = "buttonSpray";
            this.buttonSpray.Size = new System.Drawing.Size(76, 65);
            this.buttonSpray.TabIndex = 5;
            this.buttonSpray.UseVisualStyleBackColor = true;
            this.buttonSpray.Click += new System.EventHandler(this.buttonSpray_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Image = global::malovani.Properties.Resources.eraser;
            this.buttonEraser.Location = new System.Drawing.Point(755, 110);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(76, 65);
            this.buttonEraser.TabIndex = 4;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.Image = global::malovani.Properties.Resources.Fountain_Pen_Head__1_;
            this.buttonPen.Location = new System.Drawing.Point(755, 35);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(76, 65);
            this.buttonPen.TabIndex = 3;
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Image = global::malovani.Properties.Resources.Paint_Brush_Free_Download_PNG__1_;
            this.buttonBrush.Location = new System.Drawing.Point(658, 35);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(76, 65);
            this.buttonBrush.TabIndex = 2;
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Image = global::malovani.Properties.Resources.pencil_png_653__1_;
            this.buttonPencil.Location = new System.Drawing.Point(557, 35);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(76, 65);
            this.buttonPencil.TabIndex = 1;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(866, 647);
            this.Controls.Add(this.textBoxSirka);
            this.Controls.Add(this.textBoxVyska);
            this.Controls.Add(this.labelSirka);
            this.Controls.Add(this.labelVyska);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.labelPB);
            this.Controls.Add(this.textBoxPB);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.panelCheck);
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
            this.panelCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.PictureBox pictureBoxCheck;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.TextBox textBoxPB;
        private System.Windows.Forms.Label labelPB;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.Label labelVyska;
        private System.Windows.Forms.Label labelSirka;
        private System.Windows.Forms.TextBox textBoxVyska;
        private System.Windows.Forms.TextBox textBoxSirka;
    }
}

