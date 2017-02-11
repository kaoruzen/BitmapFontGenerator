namespace FontPlayer
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFontFile = new System.Windows.Forms.TextBox();
            this.textBoxTextFile = new System.Windows.Forms.TextBox();
            this.buttonFontPath = new System.Windows.Forms.Button();
            this.buttonTextPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(14, 70);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(640, 320);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "FontFile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "TextFile:";
            // 
            // textBoxFontFile
            // 
            this.textBoxFontFile.Enabled = false;
            this.textBoxFontFile.Location = new System.Drawing.Point(67, 18);
            this.textBoxFontFile.Name = "textBoxFontFile";
            this.textBoxFontFile.Size = new System.Drawing.Size(298, 19);
            this.textBoxFontFile.TabIndex = 1;
            // 
            // textBoxTextFile
            // 
            this.textBoxTextFile.Enabled = false;
            this.textBoxTextFile.Location = new System.Drawing.Point(67, 43);
            this.textBoxTextFile.Name = "textBoxTextFile";
            this.textBoxTextFile.Size = new System.Drawing.Size(298, 19);
            this.textBoxTextFile.TabIndex = 4;
            // 
            // buttonFontPath
            // 
            this.buttonFontPath.Location = new System.Drawing.Point(371, 16);
            this.buttonFontPath.Name = "buttonFontPath";
            this.buttonFontPath.Size = new System.Drawing.Size(28, 23);
            this.buttonFontPath.TabIndex = 2;
            this.buttonFontPath.Text = "...";
            this.buttonFontPath.UseVisualStyleBackColor = true;
            this.buttonFontPath.Click += new System.EventHandler(this.buttonFontPath_Click);
            // 
            // buttonTextPath
            // 
            this.buttonTextPath.Location = new System.Drawing.Point(371, 41);
            this.buttonTextPath.Name = "buttonTextPath";
            this.buttonTextPath.Size = new System.Drawing.Size(28, 23);
            this.buttonTextPath.TabIndex = 5;
            this.buttonTextPath.Text = "...";
            this.buttonTextPath.UseVisualStyleBackColor = true;
            this.buttonTextPath.Click += new System.EventHandler(this.buttonTextPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "FontSize:";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(477, 18);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(64, 19);
            this.numericUpDownFontSize.TabIndex = 3;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 402);
            this.Controls.Add(this.numericUpDownFontSize);
            this.Controls.Add(this.buttonTextPath);
            this.Controls.Add(this.buttonFontPath);
            this.Controls.Add(this.textBoxTextFile);
            this.Controls.Add(this.textBoxFontFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BitmapFontPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFontFile;
        private System.Windows.Forms.TextBox textBoxTextFile;
        private System.Windows.Forms.Button buttonFontPath;
        private System.Windows.Forms.Button buttonTextPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
    }
}

