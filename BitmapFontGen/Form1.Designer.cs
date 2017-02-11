namespace BitmapFontGen
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFontName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSJIS = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxGriph = new System.Windows.Forms.PictureBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonSelectOutput = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGriph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Font:";
            // 
            // textBoxFontName
            // 
            this.textBoxFontName.BackColor = System.Drawing.Color.White;
            this.textBoxFontName.Enabled = false;
            this.textBoxFontName.Location = new System.Drawing.Point(87, 6);
            this.textBoxFontName.Name = "textBoxFontName";
            this.textBoxFontName.Size = new System.Drawing.Size(226, 19);
            this.textBoxFontName.TabIndex = 1;
            this.textBoxFontName.TextChanged += new System.EventHandler(this.evRenderForDisplay);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labelSJIS);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.numericUpDownThreshold);
            this.groupBox1.Controls.Add(this.numericUpDownY);
            this.groupBox1.Controls.Add(this.numericUpDownX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBoxGriph);
            this.groupBox1.Controls.Add(this.textBoxChar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 276);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // labelSJIS
            // 
            this.labelSJIS.AutoSize = true;
            this.labelSJIS.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSJIS.Location = new System.Drawing.Point(67, 44);
            this.labelSJIS.Name = "labelSJIS";
            this.labelSJIS.Size = new System.Drawing.Size(50, 11);
            this.labelSJIS.TabIndex = 10;
            this.labelSJIS.Text = "CharSJIS";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelData.Location = new System.Drawing.Point(6, 259);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 11);
            this.labelData.TabIndex = 9;
            this.labelData.Text = "FontData";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(69, 127);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(62, 19);
            this.numericUpDownY.TabIndex = 8;
            this.numericUpDownY.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.evRenderForDisplay);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(69, 102);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(62, 19);
            this.numericUpDownX.TabIndex = 8;
            this.numericUpDownX.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.evRenderForDisplay);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Offset:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.DecimalPlaces = 1;
            this.numericUpDownSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSize.Location = new System.Drawing.Point(69, 66);
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(62, 19);
            this.numericUpDownSize.TabIndex = 4;
            this.numericUpDownSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.evRenderForDisplay);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "FontSize";
            // 
            // pictureBoxGriph
            // 
            this.pictureBoxGriph.Location = new System.Drawing.Point(162, 81);
            this.pictureBoxGriph.Name = "pictureBoxGriph";
            this.pictureBoxGriph.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxGriph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGriph.TabIndex = 2;
            this.pictureBoxGriph.TabStop = false;
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(69, 22);
            this.textBoxChar.MaxLength = 1;
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(39, 19);
            this.textBoxChar.TabIndex = 1;
            this.textBoxChar.Text = "禅";
            this.textBoxChar.TextChanged += new System.EventHandler(this.evRenderForDisplay);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Char:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitmap Font Size [pixel]:";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(149, 56);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownFontSize.TabIndex = 5;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.evRenderForDisplay);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.White;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(87, 31);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(226, 19);
            this.textBoxOutput.TabIndex = 7;
            // 
            // buttonSelectOutput
            // 
            this.buttonSelectOutput.Location = new System.Drawing.Point(319, 29);
            this.buttonSelectOutput.Name = "buttonSelectOutput";
            this.buttonSelectOutput.Size = new System.Drawing.Size(31, 23);
            this.buttonSelectOutput.TabIndex = 8;
            this.buttonSelectOutput.Text = "...";
            this.buttonSelectOutput.UseVisualStyleBackColor = true;
            this.buttonSelectOutput.Click += new System.EventHandler(this.buttonSelectOutput_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 64);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Threshold:";
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Location = new System.Drawing.Point(69, 184);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(62, 19);
            this.numericUpDownThreshold.TabIndex = 8;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numericUpDownThreshold.ValueChanged += new System.EventHandler(this.evRenderForDisplay);
            this.numericUpDownThreshold.Enter += new System.EventHandler(this.evRenderForDisplay);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 363);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 392);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSelectOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFontName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BitmapFontGenerator for u\'processor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGriph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFontName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSJIS;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxGriph;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonSelectOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

