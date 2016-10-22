namespace DBMS_Version1
{
    partial class FrmDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(271, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 164);
            this.panel1.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(138, 74);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(242, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(242, 20);
            this.txtID.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(227, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "CÂU LẠC BỘ BÓNG ĐÁ CTRL + F5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(656, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "CHÀO MỪNG BẠN ĐẾN VỚI PHẦN MỀM QUẢN LÝ NHÂN SỰ";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FrmDangNhap";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}