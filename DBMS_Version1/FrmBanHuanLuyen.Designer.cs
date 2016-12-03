namespace DBMS_Version1
{
    partial class FrmBanHuanLuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHuanLuyen));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBHL = new System.Windows.Forms.DataGridView();
            this.MaBHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTBHL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMBHL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboxLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(563, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(563, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 38);
            this.btnSua.TabIndex = 36;
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
            this.btnThem.Location = new System.Drawing.Point(563, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 38);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Danh sách các Ban Huấn Luyện";
            // 
            // dgvBHL
            // 
            this.dgvBHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBHL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBHL,
            this.TenBHL,
            this.NgSinh,
            this.DiaChi,
            this.MaLoai});
            this.dgvBHL.Location = new System.Drawing.Point(12, 157);
            this.dgvBHL.Name = "dgvBHL";
            this.dgvBHL.Size = new System.Drawing.Size(545, 231);
            this.dgvBHL.TabIndex = 33;
            // 
            // MaBHL
            // 
            this.MaBHL.DataPropertyName = "MaBHL";
            this.MaBHL.HeaderText = "Mã BHL";
            this.MaBHL.Name = "MaBHL";
            // 
            // TenBHL
            // 
            this.TenBHL.DataPropertyName = "TenBHL";
            this.TenBHL.HeaderText = "Tên BHL";
            this.TenBHL.Name = "TenBHL";
            // 
            // NgSinh
            // 
            this.NgSinh.DataPropertyName = "NgSinh";
            this.NgSinh.HeaderText = "Ngày Sinh";
            this.NgSinh.Name = "NgSinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Chức vụ";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Loại BHL";
            // 
            // NgaySinh
            // 
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgaySinh.Location = new System.Drawing.Point(112, 95);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(129, 20);
            this.NgaySinh.TabIndex = 30;
            // 
            // txtTBHL
            // 
            this.txtTBHL.Location = new System.Drawing.Point(112, 63);
            this.txtTBHL.Name = "txtTBHL";
            this.txtTBHL.Size = new System.Drawing.Size(129, 20);
            this.txtTBHL.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên BHL";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(420, 40);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(182, 20);
            this.txtDC.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày Sinh";
            // 
            // txtMBHL
            // 
            this.txtMBHL.Location = new System.Drawing.Point(112, 37);
            this.txtMBHL.Name = "txtMBHL";
            this.txtMBHL.Size = new System.Drawing.Size(129, 20);
            this.txtMBHL.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã BHL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "QUẢN LÝ THÔNG TIN BAN HUẤN LUYỆN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(563, 243);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 38);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(482, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btn_Reset);
            // 
            // cboxLoai
            // 
            this.cboxLoai.FormattingEnabled = true;
            this.cboxLoai.Location = new System.Drawing.Point(420, 66);
            this.cboxLoai.Name = "cboxLoai";
            this.cboxLoai.Size = new System.Drawing.Size(182, 21);
            this.cboxLoai.TabIndex = 41;
            // 
            // FrmBanHuanLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 398);
            this.Controls.Add(this.cboxLoai);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvBHL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.txtTBHL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMBHL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBanHuanLuyen";
            this.Text = "FrmHuanLuyenVien";
            this.Load += new System.EventHandler(this.FrmHuanLuyenVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBHL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.TextBox txtTBHL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMBHL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboxLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoai;
    }
}