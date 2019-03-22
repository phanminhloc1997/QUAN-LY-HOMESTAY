namespace QUANLYHOMESTAY
{
    partial class frmDangNhap
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
            this.btDK = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.btDN = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblThongBao = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btDK
            // 
            this.btDK.Location = new System.Drawing.Point(208, 193);
            this.btDK.Margin = new System.Windows.Forms.Padding(4);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(100, 28);
            this.btDK.TabIndex = 1;
            this.btDK.Text = "Đăng ký";
            this.btDK.UseVisualStyleBackColor = true;
            this.btDK.Click += new System.EventHandler(this.btDK_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(29, 100);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(62, 16);
            this.txt.TabIndex = 0;
            this.txt.Text = "Mật khẩu";
            // 
            // btDN
            // 
            this.btDN.Location = new System.Drawing.Point(33, 193);
            this.btDN.Margin = new System.Windows.Forms.Padding(4);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(100, 28);
            this.btDN.TabIndex = 1;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = true;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(175, 36);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(132, 22);
            this.txtTenDN.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(175, 94);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(132, 22);
            this.txtMK.TabIndex = 2;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Location = new System.Drawing.Point(81, 273);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(210, 30);
            this.lblThongBao.TabIndex = 3;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btDK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDK;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.LinkLabel lblThongBao;
    }
}