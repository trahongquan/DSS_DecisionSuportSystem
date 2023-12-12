namespace Phan_cong_cong_viec
{
    partial class FormPhanCongCongViec
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvKhaNang = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.dtgrvNV = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kha_Nang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Dien_Thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuc_Vu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrvCV = new System.Windows.Forms.DataGridView();
            this.Chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ma_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tai_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhaNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 134;
            this.label1.Text = "Chọn nhân viên";
            // 
            // dtgvKhaNang
            // 
            this.dtgvKhaNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhaNang.Location = new System.Drawing.Point(12, 432);
            this.dtgvKhaNang.Name = "dtgvKhaNang";
            this.dtgvKhaNang.Size = new System.Drawing.Size(1064, 154);
            this.dtgvKhaNang.TabIndex = 135;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(789, 600);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 136;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(708, 600);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 137;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // dtgrvNV
            // 
            this.dtgrvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.Ma_NV,
            this.Ten_NV,
            this.Ngay_Sinh,
            this.Gioi_Tinh,
            this.Dia_Chi,
            this.Kha_Nang,
            this.So_Dien_Thoai,
            this.Chuc_Vu});
            this.dtgrvNV.Location = new System.Drawing.Point(12, 36);
            this.dtgrvNV.Name = "dtgrvNV";
            this.dtgrvNV.Size = new System.Drawing.Size(1064, 189);
            this.dtgrvNV.TabIndex = 138;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "";
            this.Chon.Name = "Chon";
            this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chon.Width = 20;
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã Nhân viên";
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.Width = 60;
            // 
            // Ten_NV
            // 
            this.Ten_NV.DataPropertyName = "Ten_NV";
            this.Ten_NV.HeaderText = "Tên nhân viên";
            this.Ten_NV.Name = "Ten_NV";
            this.Ten_NV.Width = 150;
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.DataPropertyName = "Ngay_Sinh";
            this.Ngay_Sinh.HeaderText = "Ngày sinh";
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            this.Ngay_Sinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
            this.Gioi_Tinh.HeaderText = "Giới tính";
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            this.Gioi_Tinh.Width = 50;
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.DataPropertyName = "Dia_Chi";
            this.Dia_Chi.HeaderText = "Địa chỉ";
            this.Dia_Chi.Name = "Dia_Chi";
            this.Dia_Chi.Width = 120;
            // 
            // Kha_Nang
            // 
            this.Kha_Nang.DataPropertyName = "Kha_Nang";
            this.Kha_Nang.HeaderText = "Khả Năng";
            this.Kha_Nang.Name = "Kha_Nang";
            this.Kha_Nang.Width = 150;
            // 
            // So_Dien_Thoai
            // 
            this.So_Dien_Thoai.DataPropertyName = "So_Dien_Thoai";
            this.So_Dien_Thoai.HeaderText = "Số điện thoại";
            this.So_Dien_Thoai.Name = "So_Dien_Thoai";
            this.So_Dien_Thoai.Width = 80;
            // 
            // Chuc_Vu
            // 
            this.Chuc_Vu.DataPropertyName = "Chuc_Vu";
            this.Chuc_Vu.HeaderText = "Chức vụ";
            this.Chuc_Vu.Name = "Chuc_Vu";
            this.Chuc_Vu.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 139;
            this.label2.Text = "Chọn công việc";
            // 
            // dtgrvCV
            // 
            this.dtgrvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon1,
            this.Ma_CV,
            this.Ten_CV,
            this.Tai_CV,
            this.Ghi_chu});
            this.dtgrvCV.Location = new System.Drawing.Point(126, 253);
            this.dtgrvCV.Name = "dtgrvCV";
            this.dtgrvCV.Size = new System.Drawing.Size(628, 151);
            this.dtgrvCV.TabIndex = 148;
            // 
            // Chon1
            // 
            this.Chon1.HeaderText = "";
            this.Chon1.Name = "Chon1";
            this.Chon1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chon1.Width = 20;
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
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(778, 386);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 149;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(21, 406);
            this.lb1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 22);
            this.lb1.TabIndex = 150;
            // 
            // FormPhanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 630);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dtgrvCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrvNV);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtgvKhaNang);
            this.Controls.Add(this.label1);
            this.Name = "FormPhanCongCongViec";
            this.Text = "Phân công công việc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKhaNang_FormClosed);
            this.Load += new System.EventHandler(this.FormKhaNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhaNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvKhaNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.DataGridView dtgrvNV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kha_Nang;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Dien_Thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuc_Vu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrvCV;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tai_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_chu;
        private System.Windows.Forms.Label lb1;
    }
}