namespace DBMS_Version1.DoiBong
{
    partial class Quanlydoibong
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
            this.dgvCauThu = new System.Windows.Forms.DataGridView();
            this.TenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenDoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRWF = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.lblLWF = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.lblST = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.lblRM = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.lblLM = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.lblCM = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.lblCDM = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.lblLB = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.lblRB = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.lblCB = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.lblGK = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBanHuanLuyen = new System.Windows.Forms.DataGridView();
            this.TenBHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNhaTaiTro = new System.Windows.Forms.DataGridView();
            this.TenNTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauThu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHuanLuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaTaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCauThu
            // 
            this.dgvCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenCT,
            this.MaVT,
            this.TenVT});
            this.dgvCauThu.Location = new System.Drawing.Point(364, 52);
            this.dgvCauThu.Name = "dgvCauThu";
            this.dgvCauThu.Size = new System.Drawing.Size(269, 452);
            this.dgvCauThu.TabIndex = 0;
            // 
            // TenCT
            // 
            this.TenCT.DataPropertyName = "TenCT";
            this.TenCT.HeaderText = "Tên CT";
            this.TenCT.Name = "TenCT";
            // 
            // MaVT
            // 
            this.MaVT.DataPropertyName = "MaVT";
            this.MaVT.HeaderText = "Mã ";
            this.MaVT.Name = "MaVT";
            this.MaVT.Width = 30;
            // 
            // TenVT
            // 
            this.TenVT.DataPropertyName = "TenVT";
            this.TenVT.HeaderText = "Vị trí";
            this.TenVT.Name = "TenVT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đội: ";
            // 
            // lblTenDoi
            // 
            this.lblTenDoi.AutoSize = true;
            this.lblTenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDoi.Location = new System.Drawing.Point(76, 9);
            this.lblTenDoi.Name = "lblTenDoi";
            this.lblTenDoi.Size = new System.Drawing.Size(136, 31);
            this.lblTenDoi.TabIndex = 2;
            this.lblTenDoi.Text = "<tên đội>";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRWF);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.lblLWF);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.lblST);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.lblRM);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.lblLM);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.lblCM);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.lblCDM);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.lblLB);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.lblRB);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.lblCB);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.lblGK);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Location = new System.Drawing.Point(639, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 478);
            this.panel1.TabIndex = 3;
            // 
            // lblRWF
            // 
            this.lblRWF.AutoSize = true;
            this.lblRWF.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRWF.Location = new System.Drawing.Point(251, 29);
            this.lblRWF.Name = "lblRWF";
            this.lblRWF.Size = new System.Drawing.Size(41, 13);
            this.lblRWF.TabIndex = 21;
            this.lblRWF.Text = "<label>";
            // 
            // button21
            // 
            this.button21.Cursor = System.Windows.Forms.Cursors.Default;
            this.button21.Location = new System.Drawing.Point(256, 7);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(55, 23);
            this.button21.TabIndex = 20;
            this.button21.Text = "RWF";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // lblLWF
            // 
            this.lblLWF.AutoSize = true;
            this.lblLWF.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLWF.Location = new System.Drawing.Point(23, 29);
            this.lblLWF.Name = "lblLWF";
            this.lblLWF.Size = new System.Drawing.Size(41, 13);
            this.lblLWF.TabIndex = 19;
            this.lblLWF.Text = "<label>";
            // 
            // button20
            // 
            this.button20.Cursor = System.Windows.Forms.Cursors.Default;
            this.button20.Location = new System.Drawing.Point(30, 7);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(55, 23);
            this.button20.TabIndex = 18;
            this.button20.Text = "LWF";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblST.Location = new System.Drawing.Point(128, 29);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(41, 13);
            this.lblST.TabIndex = 17;
            this.lblST.Text = "<label>";
            this.lblST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button19
            // 
            this.button19.Cursor = System.Windows.Forms.Cursors.Default;
            this.button19.Location = new System.Drawing.Point(140, 7);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 23);
            this.button19.TabIndex = 16;
            this.button19.Text = "ST";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRM.Location = new System.Drawing.Point(244, 122);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(41, 13);
            this.lblRM.TabIndex = 15;
            this.lblRM.Text = "<label>";
            // 
            // button18
            // 
            this.button18.Cursor = System.Windows.Forms.Cursors.Default;
            this.button18.Location = new System.Drawing.Point(259, 96);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 23);
            this.button18.TabIndex = 14;
            this.button18.Text = "RM";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // lblLM
            // 
            this.lblLM.AutoSize = true;
            this.lblLM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLM.Location = new System.Drawing.Point(16, 122);
            this.lblLM.Name = "lblLM";
            this.lblLM.Size = new System.Drawing.Size(41, 13);
            this.lblLM.TabIndex = 13;
            this.lblLM.Text = "<label>";
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Default;
            this.button17.Location = new System.Drawing.Point(19, 96);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 23);
            this.button17.TabIndex = 12;
            this.button17.Text = "LM";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCM.Location = new System.Drawing.Point(119, 127);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(41, 13);
            this.lblCM.TabIndex = 11;
            this.lblCM.Text = "<label>";
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Default;
            this.button16.Location = new System.Drawing.Point(140, 105);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 23);
            this.button16.TabIndex = 10;
            this.button16.Text = "CM";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // lblCDM
            // 
            this.lblCDM.AutoSize = true;
            this.lblCDM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCDM.Location = new System.Drawing.Point(135, 213);
            this.lblCDM.Name = "lblCDM";
            this.lblCDM.Size = new System.Drawing.Size(41, 13);
            this.lblCDM.TabIndex = 9;
            this.lblCDM.Text = "<label>";
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Default;
            this.button15.Location = new System.Drawing.Point(140, 191);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 23);
            this.button15.TabIndex = 8;
            this.button15.Text = "CDM";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLB.Location = new System.Drawing.Point(14, 259);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(41, 13);
            this.lblLB.TabIndex = 7;
            this.lblLB.Text = "<label>";
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Default;
            this.button14.Location = new System.Drawing.Point(19, 237);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 23);
            this.button14.TabIndex = 6;
            this.button14.Text = "LB";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // lblRB
            // 
            this.lblRB.AutoSize = true;
            this.lblRB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRB.Location = new System.Drawing.Point(253, 263);
            this.lblRB.Name = "lblRB";
            this.lblRB.Size = new System.Drawing.Size(41, 13);
            this.lblRB.TabIndex = 5;
            this.lblRB.Text = "<label>";
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Default;
            this.button13.Location = new System.Drawing.Point(259, 237);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "RB";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCB.Location = new System.Drawing.Point(129, 316);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(41, 13);
            this.lblCB.TabIndex = 3;
            this.lblCB.Text = "<label>";
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Default;
            this.button12.Location = new System.Drawing.Point(140, 294);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "CB";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // lblGK
            // 
            this.lblGK.AutoSize = true;
            this.lblGK.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGK.Location = new System.Drawing.Point(134, 408);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(41, 13);
            this.lblGK.TabIndex = 1;
            this.lblGK.Text = "<label>";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Default;
            this.button11.Location = new System.Drawing.Point(140, 386);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "GK";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đội hình";
            // 
            // dgvBanHuanLuyen
            // 
            this.dgvBanHuanLuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHuanLuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenBHL,
            this.TenLoai});
            this.dgvBanHuanLuyen.Location = new System.Drawing.Point(12, 364);
            this.dgvBanHuanLuyen.Name = "dgvBanHuanLuyen";
            this.dgvBanHuanLuyen.Size = new System.Drawing.Size(299, 140);
            this.dgvBanHuanLuyen.TabIndex = 5;
            // 
            // TenBHL
            // 
            this.TenBHL.DataPropertyName = "TenBHL";
            this.TenBHL.HeaderText = "Tên";
            this.TenBHL.Name = "TenBHL";
            this.TenBHL.Width = 150;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Chức vụ";
            this.TenLoai.Name = "TenLoai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh sách các cầu thủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách các thành phần Ban huấn luyện";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm cầu thủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thêm thành phần Ban Huấn Luyện";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh sách các Nhà Tài trợ:";
            // 
            // dgvNhaTaiTro
            // 
            this.dgvNhaTaiTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaTaiTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNTT,
            this.TienTaiTro});
            this.dgvNhaTaiTro.Location = new System.Drawing.Point(15, 201);
            this.dgvNhaTaiTro.Name = "dgvNhaTaiTro";
            this.dgvNhaTaiTro.Size = new System.Drawing.Size(296, 116);
            this.dgvNhaTaiTro.TabIndex = 11;
            // 
            // TenNTT
            // 
            this.TenNTT.DataPropertyName = "TenNTT";
            this.TenNTT.HeaderText = "Tên";
            this.TenNTT.Name = "TenNTT";
            this.TenNTT.Width = 150;
            // 
            // TienTaiTro
            // 
            this.TienTaiTro.DataPropertyName = "TienTaiTro";
            this.TienTaiTro.HeaderText = "Số tiền tài trợ";
            this.TienTaiTro.Name = "TienTaiTro";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "Thêm Nhà Tài trợ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(567, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "edit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(603, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "del";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(317, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "del";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(317, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "edit";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(317, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "del";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Yellow;
            this.button9.Location = new System.Drawing.Point(317, 199);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "edit";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(104, 71);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 50);
            this.button10.TabIndex = 19;
            this.button10.Text = "Tăng lương";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(898, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Quanlydoibong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 516);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvNhaTaiTro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBanHuanLuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTenDoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCauThu);
            this.Name = "Quanlydoibong";
            this.Text = "Quanlydoibong";
            this.Load += new System.EventHandler(this.Quanlydoibong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHuanLuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaTaiTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCauThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenDoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBanHuanLuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNhaTaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTaiTro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblRWF;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label lblLWF;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label lblLM;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lblCDM;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label lblRB;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVT;
    }
}