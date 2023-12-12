namespace Phan_cong_cong_viec
{
    partial class FormGiaoDienQuanLy
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
            this.btnQLCV = new System.Windows.Forms.Button();
            this.btnPCCV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLCV
            // 
            this.btnQLCV.AutoSize = true;
            this.btnQLCV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLCV.Location = new System.Drawing.Point(400, 140);
            this.btnQLCV.Name = "btnQLCV";
            this.btnQLCV.Size = new System.Drawing.Size(145, 44);
            this.btnQLCV.TabIndex = 6;
            this.btnQLCV.Text = "Quản lý công việc";
            this.btnQLCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLCV.UseCompatibleTextRendering = true;
            this.btnQLCV.UseVisualStyleBackColor = false;
            this.btnQLCV.Click += new System.EventHandler(this.btnQLCV_Click);
            // 
            // btnPCCV
            // 
            this.btnPCCV.AutoSize = true;
            this.btnPCCV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPCCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCCV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPCCV.Location = new System.Drawing.Point(239, 228);
            this.btnPCCV.Name = "btnPCCV";
            this.btnPCCV.Size = new System.Drawing.Size(158, 44);
            this.btnPCCV.TabIndex = 5;
            this.btnPCCV.Text = "Phân công công việc";
            this.btnPCCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPCCV.UseCompatibleTextRendering = true;
            this.btnPCCV.UseVisualStyleBackColor = false;
            this.btnPCCV.Click += new System.EventHandler(this.btnPCCV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHÂN CÔNG CÔNG VIỆC";
            // 
            // btnQLNV
            // 
            this.btnQLNV.AutoSize = true;
            this.btnQLNV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnQLNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLNV.Location = new System.Drawing.Point(99, 139);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(145, 44);
            this.btnQLNV.TabIndex = 7;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLNV.UseCompatibleTextRendering = true;
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(524, 291);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.UseCompatibleTextRendering = true;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormGiaoDienQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 331);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnQLCV);
            this.Controls.Add(this.btnPCCV);
            this.Controls.Add(this.label1);
            this.Name = "FormGiaoDienQuanLy";
            this.Text = "GiaoDienQuanLy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGiaoDienQuanLy_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLCV;
        private System.Windows.Forms.Button btnPCCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnThoat;

    }
}