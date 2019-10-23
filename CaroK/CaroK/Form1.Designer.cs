namespace CaroK
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
            this.pnlCaro = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.procBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxMark = new System.Windows.Forms.PictureBox();
            this.picBoxHinh = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCaro
            // 
            this.pnlCaro.Location = new System.Drawing.Point(12, 12);
            this.pnlCaro.Name = "pnlCaro";
            this.pnlCaro.Size = new System.Drawing.Size(626, 553);
            this.pnlCaro.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picBoxHinh);
            this.panel2.Location = new System.Drawing.Point(660, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 269);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.picBoxMark);
            this.panel3.Controls.Add(this.procBar);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(660, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 214);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 22);
            this.txtName.TabIndex = 0;
            // 
            // procBar
            // 
            this.procBar.Location = new System.Drawing.Point(3, 41);
            this.procBar.Name = "procBar";
            this.procBar.Size = new System.Drawing.Size(117, 23);
            this.procBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "5 nước 1 hàng thì win";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBoxMark
            // 
            this.picBoxMark.Location = new System.Drawing.Point(126, 13);
            this.picBoxMark.Name = "picBoxMark";
            this.picBoxMark.Size = new System.Drawing.Size(123, 96);
            this.picBoxMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMark.TabIndex = 2;
            this.picBoxMark.TabStop = false;
            // 
            // picBoxHinh
            // 
            this.picBoxHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxHinh.Image = global::CaroK.Properties.Resources.Cocaro;
            this.picBoxHinh.Location = new System.Drawing.Point(0, 3);
            this.picBoxHinh.Name = "picBoxHinh";
            this.picBoxHinh.Size = new System.Drawing.Size(311, 266);
            this.picBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinh.TabIndex = 0;
            this.picBoxHinh.TabStop = false;
            this.picBoxHinh.Click += new System.EventHandler(this.picBoxHinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCaro);
            this.Name = "Form1";
            this.Text = "CaRoK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxMark;
        private System.Windows.Forms.ProgressBar procBar;
        private System.Windows.Forms.TextBox txtName;
    }
}

