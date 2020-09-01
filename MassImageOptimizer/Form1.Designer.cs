namespace AppSoftware.MassImageOptimizer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_qualitySliderValTxtBox = new System.Windows.Forms.TextBox();
            this.m_qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_resizeImagesChkBx = new System.Windows.Forms.CheckBox();
            this.m_maxHeightTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_maxWidthTxtBox = new System.Windows.Forms.TextBox();
            this.m_goBtn = new System.Windows.Forms.Button();
            this.m_folderPathTxtBox = new System.Windows.Forms.TextBox();
            this.m_browseBtn = new System.Windows.Forms.Button();
            this.m_progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_resultsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_qualityTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.m_goBtn);
            this.groupBox1.Controls.Add(this.m_folderPathTxtBox);
            this.groupBox1.Controls.Add(this.m_browseBtn);
            this.groupBox1.Controls.Add(this.m_progressBar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Directory Containing Images to be Optimized";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_qualitySliderValTxtBox);
            this.groupBox4.Controls.Add(this.m_qualityTrackBar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 89);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Image Quality";
            // 
            // m_qualitySliderValTxtBox
            // 
            this.m_qualitySliderValTxtBox.Location = new System.Drawing.Point(194, 17);
            this.m_qualitySliderValTxtBox.Name = "m_qualitySliderValTxtBox";
            this.m_qualitySliderValTxtBox.Size = new System.Drawing.Size(33, 20);
            this.m_qualitySliderValTxtBox.TabIndex = 8;
            this.m_qualitySliderValTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_qualityTrackBar
            // 
            this.m_qualityTrackBar.LargeChange = 10;
            this.m_qualityTrackBar.Location = new System.Drawing.Point(8, 36);
            this.m_qualityTrackBar.Maximum = 50;
            this.m_qualityTrackBar.Name = "m_qualityTrackBar";
            this.m_qualityTrackBar.Size = new System.Drawing.Size(409, 45);
            this.m_qualityTrackBar.TabIndex = 7;
            this.m_qualityTrackBar.Value = 45;
            this.m_qualityTrackBar.Scroll += new System.EventHandler(this.m_qualityTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lowest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Highest";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.m_resizeImagesChkBx);
            this.groupBox3.Controls.Add(this.m_maxHeightTxtBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.m_maxWidthTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 50);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Resizing (Downscaling only)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "px";
            // 
            // m_resizeImagesChkBx
            // 
            this.m_resizeImagesChkBx.AutoSize = true;
            this.m_resizeImagesChkBx.Location = new System.Drawing.Point(17, 19);
            this.m_resizeImagesChkBx.Name = "m_resizeImagesChkBx";
            this.m_resizeImagesChkBx.Size = new System.Drawing.Size(95, 17);
            this.m_resizeImagesChkBx.TabIndex = 4;
            this.m_resizeImagesChkBx.Text = "Resize Images";
            this.m_resizeImagesChkBx.UseVisualStyleBackColor = true;
            this.m_resizeImagesChkBx.CheckedChanged += new System.EventHandler(this.m_resizeImagesChkBx_CheckedChanged);
            // 
            // m_maxHeightTxtBox
            // 
            this.m_maxHeightTxtBox.Location = new System.Drawing.Point(333, 16);
            this.m_maxHeightTxtBox.Name = "m_maxHeightTxtBox";
            this.m_maxHeightTxtBox.Size = new System.Drawing.Size(33, 20);
            this.m_maxHeightTxtBox.TabIndex = 8;
            this.m_maxHeightTxtBox.Text = "450";
            this.m_maxHeightTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max Height:";
            // 
            // m_maxWidthTxtBox
            // 
            this.m_maxWidthTxtBox.Location = new System.Drawing.Point(194, 17);
            this.m_maxWidthTxtBox.Name = "m_maxWidthTxtBox";
            this.m_maxWidthTxtBox.Size = new System.Drawing.Size(33, 20);
            this.m_maxWidthTxtBox.TabIndex = 7;
            this.m_maxWidthTxtBox.Text = "450";
            this.m_maxWidthTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_goBtn
            // 
            this.m_goBtn.Location = new System.Drawing.Point(6, 197);
            this.m_goBtn.Name = "m_goBtn";
            this.m_goBtn.Size = new System.Drawing.Size(423, 23);
            this.m_goBtn.TabIndex = 3;
            this.m_goBtn.Text = "Optimize Images in Directory";
            this.m_goBtn.UseVisualStyleBackColor = true;
            this.m_goBtn.Click += new System.EventHandler(this.m_goBtn_Click);
            // 
            // m_folderPathTxtBox
            // 
            this.m_folderPathTxtBox.Location = new System.Drawing.Point(6, 19);
            this.m_folderPathTxtBox.Name = "m_folderPathTxtBox";
            this.m_folderPathTxtBox.Size = new System.Drawing.Size(342, 20);
            this.m_folderPathTxtBox.TabIndex = 2;
            // 
            // m_browseBtn
            // 
            this.m_browseBtn.Location = new System.Drawing.Point(354, 17);
            this.m_browseBtn.Name = "m_browseBtn";
            this.m_browseBtn.Size = new System.Drawing.Size(75, 23);
            this.m_browseBtn.TabIndex = 1;
            this.m_browseBtn.Text = "Browse";
            this.m_browseBtn.UseVisualStyleBackColor = true;
            this.m_browseBtn.Click += new System.EventHandler(this.m_browseBtn_Click);
            // 
            // m_progressBar
            // 
            this.m_progressBar.Location = new System.Drawing.Point(6, 226);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(423, 23);
            this.m_progressBar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_resultsListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // m_resultsListBox
            // 
            this.m_resultsListBox.FormattingEnabled = true;
            this.m_resultsListBox.Location = new System.Drawing.Point(6, 19);
            this.m_resultsListBox.Name = "m_resultsListBox";
            this.m_resultsListBox.Size = new System.Drawing.Size(423, 173);
            this.m_resultsListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AppSoftware Mass Image Optimizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_qualityTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_folderPathTxtBox;
        private System.Windows.Forms.Button m_browseBtn;
        private System.Windows.Forms.ProgressBar m_progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox m_resultsListBox;
        private System.Windows.Forms.Button m_goBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox m_resizeImagesChkBx;
        private System.Windows.Forms.TextBox m_maxHeightTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_maxWidthTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar m_qualityTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_qualitySliderValTxtBox;
    }
}

