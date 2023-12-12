namespace Phan_cong_cong_viec
{
    partial class FormPhanCong
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qL_phan_cong_cong_viecDataSet = new Phan_cong_cong_viec.QL_phan_cong_cong_viecDataSet();
            this.khaNangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kha_NangTableAdapter = new Phan_cong_cong_viec.QL_phan_cong_cong_viecDataSetTableAdapters.Kha_NangTableAdapter();
            this.tênCôngViệcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyễnVănADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trầnThịTươiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nguyễnTrọngNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lêVânAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phanTuấnTàiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dươngVănKhánhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lêLaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_phan_cong_cong_viecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaNangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tênCôngViệcDataGridViewTextBoxColumn,
            this.nguyễnVănADataGridViewTextBoxColumn,
            this.trầnThịTươiDataGridViewTextBoxColumn,
            this.nguyễnTrọngNamDataGridViewTextBoxColumn,
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn,
            this.lêVânAnhDataGridViewTextBoxColumn,
            this.phanTuấnTàiDataGridViewTextBoxColumn,
            this.dươngVănKhánhDataGridViewTextBoxColumn,
            this.lêLaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khaNangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // qL_phan_cong_cong_viecDataSet
            // 
            this.qL_phan_cong_cong_viecDataSet.DataSetName = "QL_phan_cong_cong_viecDataSet";
            this.qL_phan_cong_cong_viecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khaNangBindingSource
            // 
            this.khaNangBindingSource.DataMember = "Kha_Nang";
            this.khaNangBindingSource.DataSource = this.qL_phan_cong_cong_viecDataSet;
            // 
            // kha_NangTableAdapter
            // 
            this.kha_NangTableAdapter.ClearBeforeFill = true;
            // 
            // tênCôngViệcDataGridViewTextBoxColumn
            // 
            this.tênCôngViệcDataGridViewTextBoxColumn.DataPropertyName = "Tên công việc";
            this.tênCôngViệcDataGridViewTextBoxColumn.HeaderText = "Tên công việc";
            this.tênCôngViệcDataGridViewTextBoxColumn.Name = "tênCôngViệcDataGridViewTextBoxColumn";
            // 
            // nguyễnVănADataGridViewTextBoxColumn
            // 
            this.nguyễnVănADataGridViewTextBoxColumn.DataPropertyName = "Nguyễn Văn A";
            this.nguyễnVănADataGridViewTextBoxColumn.HeaderText = "Nguyễn Văn A";
            this.nguyễnVănADataGridViewTextBoxColumn.Name = "nguyễnVănADataGridViewTextBoxColumn";
            this.nguyễnVănADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nguyễnVănADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // trầnThịTươiDataGridViewTextBoxColumn
            // 
            this.trầnThịTươiDataGridViewTextBoxColumn.DataPropertyName = "Trần Thị Tươi";
            this.trầnThịTươiDataGridViewTextBoxColumn.HeaderText = "Trần Thị Tươi";
            this.trầnThịTươiDataGridViewTextBoxColumn.Name = "trầnThịTươiDataGridViewTextBoxColumn";
            this.trầnThịTươiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trầnThịTươiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nguyễnTrọngNamDataGridViewTextBoxColumn
            // 
            this.nguyễnTrọngNamDataGridViewTextBoxColumn.DataPropertyName = "Nguyễn Trọng Nam";
            this.nguyễnTrọngNamDataGridViewTextBoxColumn.HeaderText = "Nguyễn Trọng Nam";
            this.nguyễnTrọngNamDataGridViewTextBoxColumn.Name = "nguyễnTrọngNamDataGridViewTextBoxColumn";
            this.nguyễnTrọngNamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nguyễnTrọngNamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nguyễnHuyHoàngDataGridViewTextBoxColumn
            // 
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn.DataPropertyName = "Nguyễn Huy Hoàng";
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn.HeaderText = "Nguyễn Huy Hoàng";
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn.Name = "nguyễnHuyHoàngDataGridViewTextBoxColumn";
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nguyễnHuyHoàngDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lêVânAnhDataGridViewTextBoxColumn
            // 
            this.lêVânAnhDataGridViewTextBoxColumn.DataPropertyName = "Lê Vân Anh";
            this.lêVânAnhDataGridViewTextBoxColumn.HeaderText = "Lê Vân Anh";
            this.lêVânAnhDataGridViewTextBoxColumn.Name = "lêVânAnhDataGridViewTextBoxColumn";
            this.lêVânAnhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lêVânAnhDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // phanTuấnTàiDataGridViewTextBoxColumn
            // 
            this.phanTuấnTàiDataGridViewTextBoxColumn.DataPropertyName = "Phan Tuấn Tài";
            this.phanTuấnTàiDataGridViewTextBoxColumn.HeaderText = "Phan Tuấn Tài";
            this.phanTuấnTàiDataGridViewTextBoxColumn.Name = "phanTuấnTàiDataGridViewTextBoxColumn";
            this.phanTuấnTàiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phanTuấnTàiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dươngVănKhánhDataGridViewTextBoxColumn
            // 
            this.dươngVănKhánhDataGridViewTextBoxColumn.DataPropertyName = "Dương Văn Khánh";
            this.dươngVănKhánhDataGridViewTextBoxColumn.HeaderText = "Dương Văn Khánh";
            this.dươngVănKhánhDataGridViewTextBoxColumn.Name = "dươngVănKhánhDataGridViewTextBoxColumn";
            this.dươngVănKhánhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dươngVănKhánhDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lêLaDataGridViewTextBoxColumn
            // 
            this.lêLaDataGridViewTextBoxColumn.DataPropertyName = "Lê La";
            this.lêLaDataGridViewTextBoxColumn.HeaderText = "Lê La";
            this.lêLaDataGridViewTextBoxColumn.Name = "lêLaDataGridViewTextBoxColumn";
            this.lêLaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lêLaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 449);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPhanCong";
            this.Text = "FormPhanCong";
            this.Load += new System.EventHandler(this.FormPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_phan_cong_cong_viecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaNangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_phan_cong_cong_viecDataSet qL_phan_cong_cong_viecDataSet;
        private System.Windows.Forms.BindingSource khaNangBindingSource;
        private QL_phan_cong_cong_viecDataSetTableAdapters.Kha_NangTableAdapter kha_NangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênCôngViệcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nguyễnVănADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trầnThịTươiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nguyễnTrọngNamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nguyễnHuyHoàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lêVânAnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn phanTuấnTàiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dươngVănKhánhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lêLaDataGridViewTextBoxColumn;
    }
}