namespace QuanLyDeThi
{
    partial class Frm_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.checkBox_P8 = new System.Windows.Forms.CheckBox();
            this.checkBox_GiaoVien = new System.Windows.Forms.CheckBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ten.Location = new System.Drawing.Point(194, 102);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(213, 20);
            this.textBox_Ten.TabIndex = 3;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.Location = new System.Drawing.Point(194, 136);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(213, 20);
            this.textBox_MatKhau.TabIndex = 4;
            // 
            // checkBox_P8
            // 
            this.checkBox_P8.AutoSize = true;
            this.checkBox_P8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_P8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_P8.Location = new System.Drawing.Point(137, 67);
            this.checkBox_P8.Name = "checkBox_P8";
            this.checkBox_P8.Size = new System.Drawing.Size(82, 17);
            this.checkBox_P8.TabIndex = 5;
            this.checkBox_P8.Text = "Quản Lý P8";
            this.checkBox_P8.UseVisualStyleBackColor = false;
            this.checkBox_P8.CheckedChanged += new System.EventHandler(this.checkBox_P8_CheckedChanged);
            // 
            // checkBox_GiaoVien
            // 
            this.checkBox_GiaoVien.AutoSize = true;
            this.checkBox_GiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_GiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_GiaoVien.Location = new System.Drawing.Point(257, 67);
            this.checkBox_GiaoVien.Name = "checkBox_GiaoVien";
            this.checkBox_GiaoVien.Size = new System.Drawing.Size(72, 17);
            this.checkBox_GiaoVien.TabIndex = 6;
            this.checkBox_GiaoVien.Text = "Giáo Viên";
            this.checkBox_GiaoVien.UseVisualStyleBackColor = false;
            this.checkBox_GiaoVien.CheckedChanged += new System.EventHandler(this.checkBox_GiaoVien_CheckedChanged);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_DangNhap.FlatAppearance.BorderSize = 3;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.Location = new System.Drawing.Point(100, 176);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(93, 38);
            this.button_DangNhap.TabIndex = 7;
            this.button_DangNhap.UseVisualStyleBackColor = true;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Thoat.FlatAppearance.BorderSize = 3;
            this.button_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(287, 176);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(93, 38);
            this.button_Thoat.TabIndex = 8;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(109, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hệ Thống Quản Lý Đề Thi Đại Học KT - HC CAND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(371, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phiên Bản 4.52";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Interval = 1000;
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.checkBox_GiaoVien);
            this.Controls.Add(this.checkBox_P8);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_Ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_DangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.CheckBox checkBox_P8;
        private System.Windows.Forms.CheckBox checkBox_GiaoVien;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ThoiGian;
    }
}