namespace Phan_cong_cong_viec
{
    partial class FormGiaoDienNhanVien
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
            this.btnXLPCCV = new System.Windows.Forms.Button();
            this.btnTCTT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXLPCCV
            // 
            this.btnXLPCCV.AutoSize = true;
            this.btnXLPCCV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXLPCCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXLPCCV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXLPCCV.Location = new System.Drawing.Point(47, 101);
            this.btnXLPCCV.Name = "btnXLPCCV";
            this.btnXLPCCV.Size = new System.Drawing.Size(224, 44);
            this.btnXLPCCV.TabIndex = 9;
            this.btnXLPCCV.Text = "Xem lịch phân công công việc";
            this.btnXLPCCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXLPCCV.UseCompatibleTextRendering = true;
            this.btnXLPCCV.UseVisualStyleBackColor = false;
            this.btnXLPCCV.Click += new System.EventHandler(this.btnXLPCCV_Click);
            // 
            // btnTCTT
            // 
            this.btnTCTT.AutoSize = true;
            this.btnTCTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTCTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTCTT.Location = new System.Drawing.Point(47, 27);
            this.btnTCTT.Name = "btnTCTT";
            this.btnTCTT.Size = new System.Drawing.Size(224, 44);
            this.btnTCTT.TabIndex = 8;
            this.btnTCTT.Text = "Tra cứu thông tin";
            this.btnTCTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTCTT.UseCompatibleTextRendering = true;
            this.btnTCTT.UseVisualStyleBackColor = false;
            this.btnTCTT.Click += new System.EventHandler(this.btnTCTTCN_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(272, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGiaoDienNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXLPCCV);
            this.Controls.Add(this.btnTCTT);
            this.Name = "FormGiaoDienNhanVien";
            this.Text = "Giao Diện Nhân Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGiaoDienNhanVien_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXLPCCV;
        private System.Windows.Forms.Button btnTCTT;
        private System.Windows.Forms.Button button1;
    }
}