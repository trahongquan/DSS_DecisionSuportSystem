namespace Phan_cong_cong_viec
{
    partial class FormTraCuuThongTin
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
            this.btnTTCV = new System.Windows.Forms.Button();
            this.btnTTNV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTTCV
            // 
            this.btnTTCV.AutoSize = true;
            this.btnTTCV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTTCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTCV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTTCV.Location = new System.Drawing.Point(26, 122);
            this.btnTTCV.Name = "btnTTCV";
            this.btnTTCV.Size = new System.Drawing.Size(224, 44);
            this.btnTTCV.TabIndex = 12;
            this.btnTTCV.Text = "XemThông tin công việc";
            this.btnTTCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTTCV.UseCompatibleTextRendering = true;
            this.btnTTCV.UseVisualStyleBackColor = false;
            this.btnTTCV.Click += new System.EventHandler(this.btnTTCV_Click);
            // 
            // btnTTNV
            // 
            this.btnTTNV.AutoSize = true;
            this.btnTTNV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTTNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTTNV.Location = new System.Drawing.Point(28, 41);
            this.btnTTNV.Name = "btnTTNV";
            this.btnTTNV.Size = new System.Drawing.Size(222, 44);
            this.btnTTNV.TabIndex = 11;
            this.btnTTNV.Text = "Thông tin nhân viên";
            this.btnTTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTTNV.UseCompatibleTextRendering = true;
            this.btnTTNV.UseVisualStyleBackColor = false;
            this.btnTTNV.Click += new System.EventHandler(this.btnTTNV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(282, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 30);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.UseCompatibleTextRendering = true;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormTraCuuThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 253);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTTCV);
            this.Controls.Add(this.btnTTNV);
            this.Name = "FormTraCuuThongTin";
            this.Text = "Tra cứu thông tin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTraCuuThongTin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTTCV;
        private System.Windows.Forms.Button btnTTNV;
        private System.Windows.Forms.Button btnThoat;

    }
}