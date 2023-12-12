namespace Phan_cong_cong_viec
{
    partial class FormCongViec
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiCV = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgrvCV = new System.Windows.Forms.DataGridView();
            this.Ma_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tai_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(120, 189);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(282, 26);
            this.txtGhiChu.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 151;
            this.label3.Text = "Ghi chú";
            // 
            // txtTaiCV
            // 
            this.txtTaiCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiCV.Location = new System.Drawing.Point(120, 146);
            this.txtTaiCV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTaiCV.Name = "txtTaiCV";
            this.txtTaiCV.Size = new System.Drawing.Size(282, 26);
            this.txtTaiCV.TabIndex = 150;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(118, 57);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.ReadOnly = true;
            this.txtMaCV.Size = new System.Drawing.Size(282, 26);
            this.txtMaCV.TabIndex = 148;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 147;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtgrvCV
            // 
            this.dtgrvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_CV,
            this.Ten_CV,
            this.Tai_CV,
            this.Ghi_chu});
            this.dtgrvCV.Location = new System.Drawing.Point(13, 269);
            this.dtgrvCV.Name = "dtgrvCV";
            this.dtgrvCV.Size = new System.Drawing.Size(628, 150);
            this.dtgrvCV.TabIndex = 146;
            this.dtgrvCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvCV_CellClick);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 144;
            this.label5.Text = "Tải công việc";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(120, 100);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(282, 26);
            this.txtTenCV.TabIndex = 145;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 142;
            this.label10.Text = "Tên công việc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 141;
            this.label11.Text = "Mã công việc";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(429, 215);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 35);
            this.btnXoa.TabIndex = 140;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(544, 110);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(97, 43);
            this.btnHienThi.TabIndex = 136;
            this.btnHienThi.Text = "Hiện thị";
            this.btnHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1197, 56);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 48);
            this.btnTimKiem.TabIndex = 135;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(429, 75);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 27);
            this.txtTimKiem.TabIndex = 134;
            this.txtTimKiem.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 133;
            this.label1.Text = "Quản lý công việc";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(429, 165);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 38);
            this.btnSua.TabIndex = 139;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.Location = new System.Drawing.Point(544, 168);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(97, 38);
            this.btnDatLai.TabIndex = 138;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(429, 110);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 43);
            this.btnThem.TabIndex = 137;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(542, 215);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 35);
            this.btnThoat.TabIndex = 175;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 439);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaiCV);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgrvCV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnThem);
            this.Name = "FormCongViec";
            this.Text = "Quản lý công việc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCongViec_FormClosed_1);
            this.Load += new System.EventHandler(this.FormCongViec_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgrvCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tai_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_chu;
        private System.Windows.Forms.Button btnThoat;
    }
}