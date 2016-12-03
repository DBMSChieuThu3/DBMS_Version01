namespace DBMS_Version1
{
    partial class FrmDoiBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiBong));
            this.cmbMT = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.MaDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTuoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayTL = new System.Windows.Forms.DateTimePicker();
            this.txtTDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMT
            // 
            this.cmbMT.FormattingEnabled = true;
            this.cmbMT.Location = new System.Drawing.Point(406, 61);
            this.cmbMT.Name = "cmbMT";
            this.cmbMT.Size = new System.Drawing.Size(116, 21);
            this.cmbMT.TabIndex = 102;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(463, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(463, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 38);
            this.btnXoa.TabIndex = 98;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(463, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 38);
            this.btnSua.TabIndex = 97;
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
            this.btnThem.Location = new System.Drawing.Point(463, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 38);
            this.btnThem.TabIndex = 96;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 95;
            this.label8.Text = "Danh sách các đội bóng";
            // 
            // dgvDB
            // 
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoi,
            this.TenDoi,
            this.NgayThanhLap,
            this.MaTuoi});
            this.dgvDB.Location = new System.Drawing.Point(10, 116);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.Size = new System.Drawing.Size(447, 231);
            this.dgvDB.TabIndex = 94;
            // 
            // MaDoi
            // 
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.HeaderText = "Mã Đội";
            this.MaDoi.Name = "MaDoi";
            // 
            // TenDoi
            // 
            this.TenDoi.DataPropertyName = "TenDoi";
            this.TenDoi.HeaderText = "Tên Đội";
            this.TenDoi.Name = "TenDoi";
            // 
            // NgayThanhLap
            // 
            this.NgayThanhLap.DataPropertyName = "NgayThanhLap";
            this.NgayThanhLap.HeaderText = "Ngày Thành Lập";
            this.NgayThanhLap.Name = "NgayThanhLap";
            // 
            // MaTuoi
            // 
            this.MaTuoi.DataPropertyName = "MaTuoi";
            this.MaTuoi.HeaderText = "Lứa Tuổi";
            this.MaTuoi.Name = "MaTuoi";
            this.MaTuoi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTuoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayTL
            // 
            this.NgayTL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayTL.Location = new System.Drawing.Point(406, 31);
            this.NgayTL.Name = "NgayTL";
            this.NgayTL.Size = new System.Drawing.Size(116, 20);
            this.NgayTL.TabIndex = 93;
            // 
            // txtTDB
            // 
            this.txtTDB.Location = new System.Drawing.Point(129, 58);
            this.txtTDB.Name = "txtTDB";
            this.txtTDB.Size = new System.Drawing.Size(116, 20);
            this.txtTDB.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Tên Đội bóng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Mã Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Ngày Thành Lập";
            // 
            // txtMDB
            // 
            this.txtMDB.Location = new System.Drawing.Point(129, 32);
            this.txtMDB.Name = "txtMDB";
            this.txtMDB.Size = new System.Drawing.Size(116, 20);
            this.txtMDB.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Mã Đội Bóng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "QUẢN LÝ THÔNG TIN ĐỘI BÓNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 85;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(408, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(49, 23);
            this.btnReset.TabIndex = 168;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // FrmDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 352);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvDB);
            this.Controls.Add(this.cmbMT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NgayTL);
            this.Controls.Add(this.txtTDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiBong";
            this.Text = "FrmDoiBong";
            this.Load += new System.EventHandler(this.FrmDoiBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMT;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.DateTimePicker NgayTL;
        private System.Windows.Forms.TextBox txtTDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhLap;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTuoi;
    }
}