namespace Rainbow
{
    partial class rainbow
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
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbBright = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBright = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textGreen = new System.Windows.Forms.TextBox();
            this.textBlue = new System.Windows.Forms.TextBox();
            this.textBright = new System.Windows.Forms.TextBox();
            this.textRed = new System.Windows.Forms.TextBox();
            this.gbScheme = new System.Windows.Forms.GroupBox();
            this.trHex = new System.Windows.Forms.Label();
            this.tlRgb = new System.Windows.Forms.Label();
            this.blHex = new System.Windows.Forms.Label();
            this.blRgb = new System.Windows.Forms.Label();
            this.trRgb = new System.Windows.Forms.Label();
            this.tlHex = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brHex = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.brRgb = new System.Windows.Forms.Label();
            this.btnMono = new System.Windows.Forms.Button();
            this.btnAnalogous = new System.Windows.Forms.Button();
            this.btnComplementary = new System.Windows.Forms.Button();
            this.btnTriadic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            this.gbColors.SuspendLayout();
            this.gbScheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRed
            // 
            this.tbRed.BackColor = System.Drawing.Color.White;
            this.tbRed.LargeChange = 15;
            this.tbRed.Location = new System.Drawing.Point(188, 20);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(263, 45);
            this.tbRed.TabIndex = 0;
            this.tbRed.TickFrequency = 15;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRed.Scroll += new System.EventHandler(this.TbRed_Scroll);
            // 
            // tbBright
            // 
            this.tbBright.BackColor = System.Drawing.Color.White;
            this.tbBright.LargeChange = 10;
            this.tbBright.Location = new System.Drawing.Point(188, 200);
            this.tbBright.Maximum = 100;
            this.tbBright.Name = "tbBright";
            this.tbBright.Size = new System.Drawing.Size(263, 45);
            this.tbBright.TabIndex = 1;
            this.tbBright.TabStop = false;
            this.tbBright.TickFrequency = 10;
            this.tbBright.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbBright.Value = 100;
            this.tbBright.Scroll += new System.EventHandler(this.TbBright_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.BackColor = System.Drawing.Color.White;
            this.tbBlue.LargeChange = 15;
            this.tbBlue.Location = new System.Drawing.Point(188, 140);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(263, 45);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.TickFrequency = 15;
            this.tbBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbBlue.Scroll += new System.EventHandler(this.TbBlue_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.AutoSize = false;
            this.tbGreen.BackColor = System.Drawing.Color.White;
            this.tbGreen.LargeChange = 15;
            this.tbGreen.Location = new System.Drawing.Point(188, 80);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(263, 45);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.TickFrequency = 15;
            this.tbGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbGreen.Scroll += new System.EventHandler(this.TbGreen_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(6, 26);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(47, 22);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            // 
            // lblBright
            // 
            this.lblBright.AutoSize = true;
            this.lblBright.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBright.Location = new System.Drawing.Point(6, 211);
            this.lblBright.Name = "lblBright";
            this.lblBright.Size = new System.Drawing.Size(100, 22);
            this.lblBright.TabIndex = 5;
            this.lblBright.Text = "Brightness";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(6, 151);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(48, 22);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(6, 91);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(69, 22);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "Green";
            // 
            // gbColors
            // 
            this.gbColors.BackColor = System.Drawing.SystemColors.Window;
            this.gbColors.Controls.Add(this.button1);
            this.gbColors.Controls.Add(this.textGreen);
            this.gbColors.Controls.Add(this.textBlue);
            this.gbColors.Controls.Add(this.textBright);
            this.gbColors.Controls.Add(this.textRed);
            this.gbColors.Controls.Add(this.tbRed);
            this.gbColors.Controls.Add(this.lblBright);
            this.gbColors.Controls.Add(this.lblBlue);
            this.gbColors.Controls.Add(this.lblGreen);
            this.gbColors.Controls.Add(this.tbGreen);
            this.gbColors.Controls.Add(this.tbBlue);
            this.gbColors.Controls.Add(this.tbBright);
            this.gbColors.Controls.Add(this.lblRed);
            this.gbColors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColors.Location = new System.Drawing.Point(26, 28);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(466, 303);
            this.gbColors.TabIndex = 8;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Color Values";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Use Text Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textGreen
            // 
            this.textGreen.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGreen.Location = new System.Drawing.Point(115, 85);
            this.textGreen.Multiline = true;
            this.textGreen.Name = "textGreen";
            this.textGreen.Size = new System.Drawing.Size(67, 35);
            this.textGreen.TabIndex = 11;
            this.textGreen.Text = "0";
            this.textGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBlue
            // 
            this.textBlue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBlue.Location = new System.Drawing.Point(115, 145);
            this.textBlue.Multiline = true;
            this.textBlue.Name = "textBlue";
            this.textBlue.Size = new System.Drawing.Size(67, 35);
            this.textBlue.TabIndex = 10;
            this.textBlue.Text = "0";
            this.textBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBright
            // 
            this.textBright.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBright.Location = new System.Drawing.Point(115, 205);
            this.textBright.Multiline = true;
            this.textBright.Name = "textBright";
            this.textBright.Size = new System.Drawing.Size(67, 35);
            this.textBright.TabIndex = 9;
            this.textBright.Text = "100";
            this.textBright.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textRed
            // 
            this.textRed.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRed.Location = new System.Drawing.Point(115, 20);
            this.textRed.Multiline = true;
            this.textRed.Name = "textRed";
            this.textRed.Size = new System.Drawing.Size(67, 35);
            this.textRed.TabIndex = 8;
            this.textRed.Text = "0";
            this.textRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbScheme
            // 
            this.gbScheme.BackColor = System.Drawing.Color.White;
            this.gbScheme.Controls.Add(this.trHex);
            this.gbScheme.Controls.Add(this.tlRgb);
            this.gbScheme.Controls.Add(this.blHex);
            this.gbScheme.Controls.Add(this.blRgb);
            this.gbScheme.Controls.Add(this.trRgb);
            this.gbScheme.Controls.Add(this.tlHex);
            this.gbScheme.Controls.Add(this.panel4);
            this.gbScheme.Controls.Add(this.panel2);
            this.gbScheme.Controls.Add(this.panel1);
            this.gbScheme.Controls.Add(this.brHex);
            this.gbScheme.Controls.Add(this.panel3);
            this.gbScheme.Controls.Add(this.brRgb);
            this.gbScheme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheme.ForeColor = System.Drawing.Color.Black;
            this.gbScheme.Location = new System.Drawing.Point(527, 28);
            this.gbScheme.Name = "gbScheme";
            this.gbScheme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbScheme.Size = new System.Drawing.Size(466, 303);
            this.gbScheme.TabIndex = 9;
            this.gbScheme.TabStop = false;
            this.gbScheme.Text = "Color Scheme";
            // 
            // trHex
            // 
            this.trHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trHex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trHex.Location = new System.Drawing.Point(9, 33);
            this.trHex.Name = "trHex";
            this.trHex.Size = new System.Drawing.Size(90, 20);
            this.trHex.TabIndex = 9;
            this.trHex.Text = "hex";
            this.trHex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tlRgb
            // 
            this.tlRgb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlRgb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlRgb.Location = new System.Drawing.Point(366, 113);
            this.tlRgb.Name = "tlRgb";
            this.tlRgb.Size = new System.Drawing.Size(90, 20);
            this.tlRgb.TabIndex = 8;
            this.tlRgb.Text = "rgb";
            this.tlRgb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // blHex
            // 
            this.blHex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blHex.Location = new System.Drawing.Point(366, 166);
            this.blHex.Name = "blHex";
            this.blHex.Size = new System.Drawing.Size(90, 20);
            this.blHex.TabIndex = 6;
            this.blHex.Text = "hex";
            // 
            // blRgb
            // 
            this.blRgb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.blRgb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blRgb.Location = new System.Drawing.Point(366, 253);
            this.blRgb.Name = "blRgb";
            this.blRgb.Size = new System.Drawing.Size(90, 20);
            this.blRgb.TabIndex = 5;
            this.blRgb.Text = "rgb";
            this.blRgb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // trRgb
            // 
            this.trRgb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trRgb.Location = new System.Drawing.Point(9, 113);
            this.trRgb.Name = "trRgb";
            this.trRgb.Size = new System.Drawing.Size(90, 20);
            this.trRgb.TabIndex = 7;
            this.trRgb.Text = "rgb";
            this.trRgb.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tlHex
            // 
            this.tlHex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlHex.Location = new System.Drawing.Point(366, 33);
            this.tlHex.Name = "tlHex";
            this.tlHex.Size = new System.Drawing.Size(90, 20);
            this.tlHex.TabIndex = 2;
            this.tlHex.Text = "hex";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(245, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 105);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(245, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 105);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(106, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 105);
            this.panel1.TabIndex = 1;
            // 
            // brHex
            // 
            this.brHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brHex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brHex.Location = new System.Drawing.Point(9, 166);
            this.brHex.Name = "brHex";
            this.brHex.Size = new System.Drawing.Size(90, 20);
            this.brHex.TabIndex = 4;
            this.brHex.Text = "hex";
            this.brHex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(106, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 105);
            this.panel3.TabIndex = 1;
            // 
            // brRgb
            // 
            this.brRgb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brRgb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brRgb.Location = new System.Drawing.Point(9, 253);
            this.brRgb.Name = "brRgb";
            this.brRgb.Size = new System.Drawing.Size(90, 20);
            this.brRgb.TabIndex = 3;
            this.brRgb.Text = "rgb";
            this.brRgb.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnMono
            // 
            this.btnMono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMono.Location = new System.Drawing.Point(26, 339);
            this.btnMono.Name = "btnMono";
            this.btnMono.Size = new System.Drawing.Size(182, 35);
            this.btnMono.TabIndex = 10;
            this.btnMono.Text = "Monochromatic";
            this.btnMono.UseVisualStyleBackColor = true;
            this.btnMono.Click += new System.EventHandler(this.BtnMono_Click);
            // 
            // btnAnalogous
            // 
            this.btnAnalogous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalogous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalogous.Location = new System.Drawing.Point(811, 339);
            this.btnAnalogous.Name = "btnAnalogous";
            this.btnAnalogous.Size = new System.Drawing.Size(182, 35);
            this.btnAnalogous.TabIndex = 12;
            this.btnAnalogous.Text = "Analogous";
            this.btnAnalogous.UseVisualStyleBackColor = true;
            this.btnAnalogous.Click += new System.EventHandler(this.BtnAnalogous_Click);
            // 
            // btnComplementary
            // 
            this.btnComplementary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplementary.Location = new System.Drawing.Point(527, 339);
            this.btnComplementary.Name = "btnComplementary";
            this.btnComplementary.Size = new System.Drawing.Size(182, 35);
            this.btnComplementary.TabIndex = 13;
            this.btnComplementary.Text = "Complementary";
            this.btnComplementary.UseVisualStyleBackColor = true;
            this.btnComplementary.Click += new System.EventHandler(this.BtnComplementary_Click);
            // 
            // btnTriadic
            // 
            this.btnTriadic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriadic.Location = new System.Drawing.Point(310, 339);
            this.btnTriadic.Name = "btnTriadic";
            this.btnTriadic.Size = new System.Drawing.Size(182, 35);
            this.btnTriadic.TabIndex = 14;
            this.btnTriadic.Text = "Triadic";
            this.btnTriadic.UseVisualStyleBackColor = true;
            this.btnTriadic.Click += new System.EventHandler(this.BtnTriadic_Click);
            // 
            // rainbow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 511);
            this.Controls.Add(this.btnTriadic);
            this.Controls.Add(this.btnComplementary);
            this.Controls.Add(this.btnAnalogous);
            this.Controls.Add(this.btnMono);
            this.Controls.Add(this.gbScheme);
            this.Controls.Add(this.gbColors);
            this.Name = "rainbow";
            this.Text = "Rainbow";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.gbScheme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbBright;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBright;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.TextBox textGreen;
        private System.Windows.Forms.TextBox textBlue;
        private System.Windows.Forms.TextBox textBright;
        private System.Windows.Forms.TextBox textRed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbScheme;
        private System.Windows.Forms.Label trHex;
        private System.Windows.Forms.Label tlRgb;
        private System.Windows.Forms.Label trRgb;
        private System.Windows.Forms.Label blHex;
        private System.Windows.Forms.Label blRgb;
        private System.Windows.Forms.Label brHex;
        private System.Windows.Forms.Label brRgb;
        private System.Windows.Forms.Label tlHex;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMono;
        private System.Windows.Forms.Button btnAnalogous;
        private System.Windows.Forms.Button btnComplementary;
        private System.Windows.Forms.Button btnTriadic;
    }
}

