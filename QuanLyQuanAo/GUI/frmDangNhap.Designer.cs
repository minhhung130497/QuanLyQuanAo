namespace quanlyquanao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.rbQuanLy = new System.Windows.Forms.RadioButton();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.llblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.llblDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.grbTuCach = new System.Windows.Forms.GroupBox();
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.llblKiemTraKetNoi = new System.Windows.Forms.LinkLabel();
            this.ttDangNhap = new System.Windows.Forms.ToolTip(this.components);
            this.grbTuCach.SuspendLayout();
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(59, 71);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(88, 16);
            this.lblTenTaiKhoan.TabIndex = 1;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            this.lblTenTaiKhoan.Click += new System.EventHandler(this.lblTenTaiKhoan_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lblMatKhau.Location = new System.Drawing.Point(59, 109);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(64, 16);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(151, 66);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(140, 23);
            this.txtTenTaiKhoan.TabIndex = 3;
            this.ttDangNhap.SetToolTip(this.txtTenTaiKhoan, "Nhập Tên Tài Khoản");
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(151, 103);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(140, 23);
            this.txtMatKhau.TabIndex = 4;
            this.ttDangNhap.SetToolTip(this.txtMatKhau, "Nhập Mật Khẩu Của Bạn");
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbQuanLy.AutoSize = true;
            this.rbQuanLy.Checked = true;
            this.rbQuanLy.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbQuanLy.Location = new System.Drawing.Point(29, 23);
            this.rbQuanLy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Size = new System.Drawing.Size(71, 17);
            this.rbQuanLy.TabIndex = 6;
            this.rbQuanLy.TabStop = true;
            this.rbQuanLy.Text = "Quản Lý";
            this.rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNhanVien.Location = new System.Drawing.Point(123, 23);
            this.rbNhanVien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(82, 19);
            this.rbNhanVien.TabIndex = 7;
            this.rbNhanVien.Text = "Nhân Viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangNhap.BackColor = System.Drawing.Color.Tomato;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(62, 233);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(227, 32);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.ttDangNhap.SetToolTip(this.btnDangNhap, "Đăng Nhập Vào Hệ Thống!");
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // llblQuenMatKhau
            // 
            this.llblQuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblQuenMatKhau.AutoSize = true;
            this.llblQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblQuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblQuenMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblQuenMatKhau.Location = new System.Drawing.Point(130, 313);
            this.llblQuenMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblQuenMatKhau.Name = "llblQuenMatKhau";
            this.llblQuenMatKhau.Size = new System.Drawing.Size(108, 17);
            this.llblQuenMatKhau.TabIndex = 11;
            this.llblQuenMatKhau.TabStop = true;
            this.llblQuenMatKhau.Text = "Quên mật khẩu?";
            this.llblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblQuenMatKhau_LinkClicked);
            // 
            // llblDoiMatKhau
            // 
            this.llblDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblDoiMatKhau.AutoSize = true;
            this.llblDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblDoiMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblDoiMatKhau.Location = new System.Drawing.Point(138, 350);
            this.llblDoiMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblDoiMatKhau.Name = "llblDoiMatKhau";
            this.llblDoiMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llblDoiMatKhau.Size = new System.Drawing.Size(90, 17);
            this.llblDoiMatKhau.TabIndex = 12;
            this.llblDoiMatKhau.TabStop = true;
            this.llblDoiMatKhau.Text = "Đổi mật khẩu";
            this.llblDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDoiMatKhau_LinkClicked);
            // 
            // grbTuCach
            // 
            this.grbTuCach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTuCach.Controls.Add(this.rbQuanLy);
            this.grbTuCach.Controls.Add(this.rbNhanVien);
            this.grbTuCach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTuCach.ForeColor = System.Drawing.Color.Black;
            this.grbTuCach.Location = new System.Drawing.Point(62, 144);
            this.grbTuCach.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbTuCach.Name = "grbTuCach";
            this.grbTuCach.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbTuCach.Size = new System.Drawing.Size(227, 57);
            this.grbTuCach.TabIndex = 14;
            this.grbTuCach.TabStop = false;
            this.grbTuCach.Text = "Tư cách";
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDangNhap.BackColor = System.Drawing.Color.White;
            this.pnlDangNhap.Controls.Add(this.lblDangNhap);
            this.pnlDangNhap.Controls.Add(this.llblKiemTraKetNoi);
            this.pnlDangNhap.Controls.Add(this.llblDoiMatKhau);
            this.pnlDangNhap.Controls.Add(this.grbTuCach);
            this.pnlDangNhap.Controls.Add(this.llblQuenMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblTenTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Controls.Add(this.lblMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtTenTaiKhoan);
            this.pnlDangNhap.ForeColor = System.Drawing.Color.Black;
            this.pnlDangNhap.Location = new System.Drawing.Point(124, 44);
            this.pnlDangNhap.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(352, 373);
            this.pnlDangNhap.TabIndex = 16;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDangNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblDangNhap.Location = new System.Drawing.Point(0, 0);
            this.lblDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDangNhap.MinimumSize = new System.Drawing.Size(352, 32);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(352, 32);
            this.lblDangNhap.TabIndex = 15;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // llblKiemTraKetNoi
            // 
            this.llblKiemTraKetNoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblKiemTraKetNoi.AutoSize = true;
            this.llblKiemTraKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblKiemTraKetNoi.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblKiemTraKetNoi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblKiemTraKetNoi.Location = new System.Drawing.Point(241, 40);
            this.llblKiemTraKetNoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblKiemTraKetNoi.Name = "llblKiemTraKetNoi";
            this.llblKiemTraKetNoi.Size = new System.Drawing.Size(111, 17);
            this.llblKiemTraKetNoi.TabIndex = 11;
            this.llblKiemTraKetNoi.TabStop = true;
            this.llblKiemTraKetNoi.Text = "Kiểm Tra Kết Nối";
            this.llblKiemTraKetNoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblKiemTraKetNoi_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QuanLyQuanAo.Properties.Resources.sounds_aura_hp2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 459);
            this.Controls.Add(this.pnlDangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quần Áo Sỉ Lẻ Baby Milo";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grbTuCach.ResumeLayout(false);
            this.grbTuCach.PerformLayout();
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.RadioButton rbQuanLy;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel llblQuenMatKhau;
        private System.Windows.Forms.LinkLabel llblDoiMatKhau;
        private System.Windows.Forms.GroupBox grbTuCach;
        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.LinkLabel llblKiemTraKetNoi;
        private System.Windows.Forms.ToolTip ttDangNhap;
    }
}

