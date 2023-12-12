namespace Phan_cong_cong_viec
{
    partial class FormChonCongViec
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
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.dtgrvCV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ma_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tai_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(560, 356);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 126;
            this.btnTiep.Text = "Tiếp tục";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(469, 356);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btnQuaylai.TabIndex = 125;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // dtgrvCV
            // 
            this.dtgrvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.Ma_CV,
            this.Ten_CV,
            this.Tai_CV,
            this.Ghi_chu});
            this.dtgrvCV.Location = new System.Drawing.Point(12, 62);
            this.dtgrvCV.Name = "dtgrvCV";
            this.dtgrvCV.Size = new System.Drawing.Size(628, 268);
            this.dtgrvCV.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 148;
            this.label1.Text = "Chọn công việc";
            // 
            // chon
            // 
            this.chon.HeaderText = "";
            this.chon.Name = "chon";
            this.chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chon.Width = 20;
            // 
            // Ma_CV
            // 
            this.Ma_CV.DataPropertyName = "Ma_CV";
            this.Ma_CV.HeaderText = "Mã Công việc";
            this.Ma_CV.Name = "Ma_CV";
            // 
            // Ten_CV
            // 
            this.Ten_CV.DataPropertyName = "Ten_CV";
            this.Ten_CV.HeaderText = "Tên công việc";
            this.Ten_CV.Name = "Ten_CV";
            this.Ten_CV.Width = 150;
            // 
            // Tai_CV
            // 
            this.Tai_CV.DataPropertyName = "Tai_CV";
            this.Tai_CV.HeaderText = "Tải công việc";
            this.Tai_CV.Name = "Tai_CV";
            this.Tai_CV.Width = 150;
            // 
            // Ghi_chu
            // 
            this.Ghi_chu.DataPropertyName = "Ghi_chu";
            this.Ghi_chu.HeaderText = "Ghi chú";
            this.Ghi_chu.Name = "Ghi_chu";
            this.Ghi_chu.Width = 150;
            // 
            // FormChonCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrvCV);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnQuaylai);
            this.Name = "FormChonCongViec";
            this.Text = "FormChonCongViec";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChonCongViec_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.DataGridView dtgrvCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tai_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_chu;
    }
}