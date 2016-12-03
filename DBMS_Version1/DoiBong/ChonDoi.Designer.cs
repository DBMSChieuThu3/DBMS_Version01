namespace DBMS_Version1.DoiBong
{
    partial class ChonDoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoiBong = new System.Windows.Forms.ComboBox();
            this.btnTiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin vui lòng chọn đội bóng";
            // 
            // cmbDoiBong
            // 
            this.cmbDoiBong.FormattingEnabled = true;
            this.cmbDoiBong.Location = new System.Drawing.Point(101, 64);
            this.cmbDoiBong.Name = "cmbDoiBong";
            this.cmbDoiBong.Size = new System.Drawing.Size(336, 21);
            this.cmbDoiBong.TabIndex = 1;
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(193, 103);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(144, 55);
            this.btnTiep.TabIndex = 2;
            this.btnTiep.Text = "Tiếp tục >>";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // ChonDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 184);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.cmbDoiBong);
            this.Controls.Add(this.label1);
            this.Name = "ChonDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonDoi";
            this.Load += new System.EventHandler(this.ChonDoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDoiBong;
        private System.Windows.Forms.Button btnTiep;
    }
}