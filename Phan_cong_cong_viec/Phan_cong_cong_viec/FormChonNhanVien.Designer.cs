namespace Phan_cong_cong_viec
{
    partial class FormChonNhanVien
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
            this.btnQuaylai = new System.Windows.Forms.Button();
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
            this.btnTiep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(681, 371);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btnQuaylai.TabIndex = 0;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuayLai_Click);
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
            this.dtgrvNV.Location = new System.Drawing.Point(12, 51);
            this.dtgrvNV.Name = "dtgrvNV";
            this.dtgrvNV.Size = new System.Drawing.Size(852, 305);
            this.dtgrvNV.TabIndex = 123;
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
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(772, 371);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 124;
            this.btnTiep.Text = "Tiếp tục";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 125;
            this.label1.Text = "Chọn nhân viên";
            // 
            // FormChonNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.dtgrvNV);
            this.Controls.Add(this.btnQuaylai);
            this.Name = "FormChonNhanVien";
            this.Text = "Chọn nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPhanCongCongViec_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuaylai;
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
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Label label1;
    }
}