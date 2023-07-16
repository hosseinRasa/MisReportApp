namespace MisReportApp
{
    partial class FrmMain
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
            this.lstMain = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.piLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSignOwners = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.grpRptType = new System.Windows.Forms.GroupBox();
            this.grpType1 = new System.Windows.Forms.RadioButton();
            this.grpType0 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.piLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpRptType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMain
            // 
            this.lstMain.FormattingEnabled = true;
            this.lstMain.ItemHeight = 20;
            this.lstMain.Location = new System.Drawing.Point(-2, 7);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(136, 64);
            this.lstMain.TabIndex = 4;
            this.lstMain.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(353, 412);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(135, 44);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // piLogo
            // 
            this.piLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piLogo.Location = new System.Drawing.Point(353, 7);
            this.piLogo.Name = "piLogo";
            this.piLogo.Size = new System.Drawing.Size(121, 97);
            this.piLogo.TabIndex = 10;
            this.piLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSignOwners);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(804, 109);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب خط امضا";
            // 
            // cmbSignOwners
            // 
            this.cmbSignOwners.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSignOwners.FormattingEnabled = true;
            this.cmbSignOwners.Location = new System.Drawing.Point(68, 48);
            this.cmbSignOwners.Name = "cmbSignOwners";
            this.cmbSignOwners.Size = new System.Drawing.Size(645, 26);
            this.cmbSignOwners.TabIndex = 15;
            this.cmbSignOwners.SelectedIndexChanged += new System.EventHandler(this.cmbSignOwners_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "امضا";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrows);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(804, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب گزارش";
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(21, 24);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(41, 29);
            this.btnBrows.TabIndex = 14;
            this.btnBrows.Text = "...";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام گزارش";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(68, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(645, 27);
            this.txtFileName.TabIndex = 12;
            // 
            // grpRptType
            // 
            this.grpRptType.Controls.Add(this.grpType1);
            this.grpRptType.Controls.Add(this.grpType0);
            this.grpRptType.Location = new System.Drawing.Point(12, 311);
            this.grpRptType.Name = "grpRptType";
            this.grpRptType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpRptType.Size = new System.Drawing.Size(804, 77);
            this.grpRptType.TabIndex = 17;
            this.grpRptType.TabStop = false;
            this.grpRptType.Text = "نوع گزارش";
            // 
            // grpType1
            // 
            this.grpType1.AutoSize = true;
            this.grpType1.Location = new System.Drawing.Point(444, 26);
            this.grpType1.Name = "grpType1";
            this.grpType1.Size = new System.Drawing.Size(70, 24);
            this.grpType1.TabIndex = 0;
            this.grpType1.TabStop = true;
            this.grpType1.Text = "نمودار";
            this.grpType1.UseVisualStyleBackColor = true;
            // 
            // grpType0
            // 
            this.grpType0.AutoSize = true;
            this.grpType0.Location = new System.Drawing.Point(590, 26);
            this.grpType0.Name = "grpType0";
            this.grpType0.Size = new System.Drawing.Size(70, 24);
            this.grpType0.TabIndex = 0;
            this.grpType0.TabStop = true;
            this.grpType0.Text = "گزارش";
            this.grpType0.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 474);
            this.Controls.Add(this.grpRptType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.piLogo);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstMain);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpRptType.ResumeLayout(false);
            this.grpRptType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox piLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cmbSignOwners;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpRptType;
        private System.Windows.Forms.RadioButton grpType1;
        private System.Windows.Forms.RadioButton grpType0;
    }
}