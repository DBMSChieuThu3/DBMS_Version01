namespace DBMS_Version1
{
    partial class FrmHopDongCT_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHopDongCT_DB));
            this.NgayKT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvHDCT = new System.Windows.Forms.DataGridView();
            this.NgayBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaDoi = new System.Windows.Forms.ComboBox();
            this.cmbMaCT = new System.Windows.Forms.ComboBox();
            this.MaCT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaDoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgBatDauHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgKetThucHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDCT)).BeginInit();
            this.SuspendLayout();
            // 
            // NgayKT
            // 
            this.NgayKT.CustomFormat = "yyyy/MM/dd";
            this.NgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayKT.Location = new System.Drawing.Point(437, 78);
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Size = new System.Drawing.Size(114, 20);
            this.NgayKT.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 143;
            this.label7.Text = "Ngày Kết Thúc HĐ";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(115, 78);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(156, 20);
            this.txtLuong.TabIndex = 142;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(567, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 140;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(567, 243);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 38);
            this.btnXoa.TabIndex = 138;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(567, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 38);
            this.btnSua.TabIndex = 137;
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
            this.btnThem.Location = new System.Drawing.Point(567, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 38);
            this.btnThem.TabIndex = 136;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 20);
            this.label8.TabIndex = 135;
            this.label8.Text = "Danh sách các hợp đồng";
            // 
            // dgvHDCT
            // 
            this.dgvHDCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCT,
            this.MaDoi,
            this.NgBatDauHD,
            this.NgKetThucHD,
            this.Luong});
            this.dgvHDCT.Location = new System.Drawing.Point(12, 155);
            this.dgvHDCT.Name = "dgvHDCT";
            this.dgvHDCT.Size = new System.Drawing.Size(549, 213);
            this.dgvHDCT.TabIndex = 134;
            // 
            // NgayBD
            // 
            this.NgayBD.CustomFormat = "yyyy/MM/dd";
            this.NgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NgayBD.Location = new System.Drawing.Point(437, 30);
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Size = new System.Drawing.Size(114, 20);
            this.NgayBD.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 131;
            this.label6.Text = "Mã Cầu Thủ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 130;
            this.label5.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 129;
            this.label4.Text = "Ngày Bắt Đầu HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 127;
            this.label3.Text = "Mã Đội Bóng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 22);
            this.label2.TabIndex = 126;
            this.label2.Text = "QUẢN LÝ HỢP ĐỒNG CẦU THỦ - ĐỘI BÓNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 125;
            // 
            // cmbMaDoi
            // 
            this.cmbMaDoi.FormattingEnabled = true;
            this.cmbMaDoi.Location = new System.Drawing.Point(115, 26);
            this.cmbMaDoi.Name = "cmbMaDoi";
            this.cmbMaDoi.Size = new System.Drawing.Size(156, 21);
            this.cmbMaDoi.TabIndex = 145;
            // 
            // cmbMaCT
            // 
            this.cmbMaCT.FormattingEnabled = true;
            this.cmbMaCT.Location = new System.Drawing.Point(115, 52);
            this.cmbMaCT.Name = "cmbMaCT";
            this.cmbMaCT.Size = new System.Drawing.Size(156, 21);
            this.cmbMaCT.TabIndex = 146;
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "MaCT";
            this.MaCT.HeaderText = "Mã Cầu Thủ";
            this.MaCT.Name = "MaCT";
            this.MaCT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaCT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaDoi
            // 
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.HeaderText = "Mã Đội Bóng";
            this.MaDoi.Name = "MaDoi";
            this.MaDoi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaDoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgBatDauHD
            // 
            this.NgBatDauHD.DataPropertyName = "NgBatDauHD";
            this.NgBatDauHD.HeaderText = "Ngày bắt đầu";
            this.NgBatDauHD.Name = "NgBatDauHD";
            // 
            // NgKetThucHD
            // 
            this.NgKetThucHD.DataPropertyName = "NgKetThucHD";
            this.NgKetThucHD.HeaderText = "Ngày kết thúc";
            this.NgKetThucHD.Name = "NgKetThucHD";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 147;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHopDongCT_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMaCT);
            this.Controls.Add(this.cmbMaDoi);
            this.Controls.Add(this.NgayKT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvHDCT);
            this.Controls.Add(this.NgayBD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHopDongCT_DB";
            this.Text = "FrmHopDongCT_DB";
            this.Load += new System.EventHandler(this.FrmHopDongCT_DB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker NgayKT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvHDCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaDoi;
        private System.Windows.Forms.ComboBox cmbMaCT;
        private System.Windows.Forms.DateTimePicker NgayBD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgBatDauHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgKetThucHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.Button button1;
    }
}