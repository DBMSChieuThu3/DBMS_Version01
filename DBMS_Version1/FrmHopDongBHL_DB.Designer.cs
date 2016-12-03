namespace DBMS_Version1
{
    partial class FrmHopDongBHL_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHopDongBHL_DB));
            this.NgayKT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvHDBHL = new System.Windows.Forms.DataGridView();
            this.NgayBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbMaDoi = new System.Windows.Forms.ComboBox();
            this.cmbMaBHL = new System.Windows.Forms.ComboBox();
            this.MaDoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaBHL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgBatDauHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgKetThucHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBHL)).BeginInit();
            this.SuspendLayout();
            // 
            // NgayKT
            // 
            this.NgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayKT.Location = new System.Drawing.Point(507, 95);
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Size = new System.Drawing.Size(137, 20);
            this.NgayKT.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 123;
            this.label7.Text = "Ngày Kết Thúc HĐ";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(137, 106);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(201, 20);
            this.txtLuong.TabIndex = 122;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(556, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 38);
            this.btnXoa.TabIndex = 118;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(556, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 38);
            this.btnSua.TabIndex = 117;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(556, 162);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 38);
            this.btnThem.TabIndex = 116;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 20);
            this.label8.TabIndex = 115;
            this.label8.Text = "Danh sách các hợp đồng";
            // 
            // dgvHDBHL
            // 
            this.dgvHDBHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBHL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoi,
            this.MaBHL,
            this.NgBatDauHD,
            this.NgKetThucHD,
            this.Luong});
            this.dgvHDBHL.Location = new System.Drawing.Point(4, 162);
            this.dgvHDBHL.Name = "dgvHDBHL";
            this.dgvHDBHL.Size = new System.Drawing.Size(546, 231);
            this.dgvHDBHL.TabIndex = 114;
            // 
            // NgayBD
            // 
            this.NgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayBD.Location = new System.Drawing.Point(507, 53);
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Size = new System.Drawing.Size(137, 20);
            this.NgayBD.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "Mã BHL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Ngày Bắt Đầu HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "Mã Đội Bóng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 22);
            this.label2.TabIndex = 106;
            this.label2.Text = "QUẢN LÝ HỢP ĐỒNG HUẤN LUẬN VIÊN - ĐỘI BÓNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 105;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(556, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 120;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbMaDoi
            // 
            this.cmbMaDoi.FormattingEnabled = true;
            this.cmbMaDoi.Location = new System.Drawing.Point(137, 51);
            this.cmbMaDoi.Name = "cmbMaDoi";
            this.cmbMaDoi.Size = new System.Drawing.Size(201, 21);
            this.cmbMaDoi.TabIndex = 125;
            // 
            // cmbMaBHL
            // 
            this.cmbMaBHL.FormattingEnabled = true;
            this.cmbMaBHL.Location = new System.Drawing.Point(137, 78);
            this.cmbMaBHL.Name = "cmbMaBHL";
            this.cmbMaBHL.Size = new System.Drawing.Size(201, 21);
            this.cmbMaBHL.TabIndex = 126;
            // 
            // MaDoi
            // 
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.HeaderText = "Mã Đội";
            this.MaDoi.Name = "MaDoi";
            // 
            // MaBHL
            // 
            this.MaBHL.DataPropertyName = "MaBHL";
            this.MaBHL.HeaderText = "Mã BHL";
            this.MaBHL.Name = "MaBHL";
            // 
            // NgBatDauHD
            // 
            this.NgBatDauHD.DataPropertyName = "NgBatDauHD";
            this.NgBatDauHD.HeaderText = "Ngày Bắt đầu";
            this.NgBatDauHD.Name = "NgBatDauHD";
            this.NgBatDauHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgBatDauHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgKetThucHD
            // 
            this.NgKetThucHD.DataPropertyName = "NgKetThucHD";
            this.NgKetThucHD.HeaderText = "Ngày Kết Thúc";
            this.NgKetThucHD.Name = "NgKetThucHD";
            this.NgKetThucHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgKetThucHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // FrmHopDongBHL_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 404);
            this.Controls.Add(this.cmbMaBHL);
            this.Controls.Add(this.cmbMaDoi);
            this.Controls.Add(this.NgayKT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvHDBHL);
            this.Controls.Add(this.NgayBD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHopDongBHL_DB";
            this.Text = "FrmHopDongHLV_DB";
            this.Load += new System.EventHandler(this.FrmHopDongBHL_DB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBHL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker NgayKT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvHDBHL;
        private System.Windows.Forms.DateTimePicker NgayBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbMaDoi;
        private System.Windows.Forms.ComboBox cmbMaBHL;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaDoi;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaBHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgBatDauHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgKetThucHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
    }
}