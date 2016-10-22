namespace DBMS_Version1
{
    partial class FrmCauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCauThu));
            this.cmbVTST = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVTST
            // 
            this.cmbVTST.FormattingEnabled = true;
            this.cmbVTST.Location = new System.Drawing.Point(507, 134);
            this.cmbVTST.Name = "cmbVTST";
            this.cmbVTST.Size = new System.Drawing.Size(201, 21);
            this.cmbVTST.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(369, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Vị trí sở trường";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(249, 442);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 38);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(695, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 81;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(468, 442);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 38);
            this.btnReset.TabIndex = 80;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(358, 442);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 38);
            this.btnXoa.TabIndex = 79;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(133, 442);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 38);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(21, 442);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 38);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Danh sách các cầu thủ";
            // 
            // dgvCT
            // 
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(19, 205);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.Size = new System.Drawing.Size(766, 231);
            this.dgvCT.TabIndex = 75;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(507, 89);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 20);
            this.txtSDT.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Số điện thoại";
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(136, 135);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(201, 20);
            this.NgaySinh.TabIndex = 72;
            // 
            // txtTCT
            // 
            this.txtTCT.Location = new System.Drawing.Point(136, 89);
            this.txtTCT.Name = "txtTCT";
            this.txtTCT.Size = new System.Drawing.Size(201, 20);
            this.txtTCT.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Tên Cầu Thủ";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(507, 50);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(201, 20);
            this.txtDC.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Ngày Sinh";
            // 
            // txtMCT
            // 
            this.txtMCT.Location = new System.Drawing.Point(136, 48);
            this.txtMCT.Name = "txtMCT";
            this.txtMCT.Size = new System.Drawing.Size(201, 20);
            this.txtMCT.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã Cầu Thủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "QUẢN LÝ THÔNG TIN CẦU THỦ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 63;
            // 
            // FrmCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 487);
            this.Controls.Add(this.cmbVTST);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.txtTCT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCauThu";
            this.Text = "FrmCauThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVTST;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.TextBox txtTCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}