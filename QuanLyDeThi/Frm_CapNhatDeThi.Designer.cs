namespace QuanLyDeThi
{
    partial class Frm_CapNhatDeThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.textBox_MaDe = new System.Windows.Forms.TextBox();
            this.comboBox_MaLop = new System.Windows.Forms.ComboBox();
            this.comboBox_MaKhoa = new System.Windows.Forms.ComboBox();
            this.comboBox_MaMon = new System.Windows.Forms.ComboBox();
            this.comboBox_MaGiaoVien = new System.Windows.Forms.ComboBox();
            this.textBox_TenMon = new System.Windows.Forms.TextBox();
            this.textBox_TenGiaoVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 190);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(644, 298);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Khoá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Giáo Viên";
            // 
            // button_Them
            // 
            this.button_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Them.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Them.FlatAppearance.BorderSize = 3;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(157, 135);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(90, 50);
            this.button_Them.TabIndex = 6;
            this.button_Them.Text = "Thêm";
            this.button_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Sua.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Sua.FlatAppearance.BorderSize = 3;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(304, 135);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(90, 50);
            this.button_Sua.TabIndex = 7;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Xoa.FlatAppearance.BorderSize = 3;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(446, 135);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(90, 50);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "Xoá";
            this.button_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.FlatAppearance.BorderSize = 3;
            this.button_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(568, 503);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(88, 30);
            this.button_Thoat.TabIndex = 9;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // textBox_MaDe
            // 
            this.textBox_MaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaDe.Location = new System.Drawing.Point(74, 6);
            this.textBox_MaDe.Name = "textBox_MaDe";
            this.textBox_MaDe.Size = new System.Drawing.Size(259, 20);
            this.textBox_MaDe.TabIndex = 10;
            // 
            // comboBox_MaLop
            // 
            this.comboBox_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaLop.FormattingEnabled = true;
            this.comboBox_MaLop.Location = new System.Drawing.Point(74, 34);
            this.comboBox_MaLop.Name = "comboBox_MaLop";
            this.comboBox_MaLop.Size = new System.Drawing.Size(259, 21);
            this.comboBox_MaLop.TabIndex = 15;
            // 
            // comboBox_MaKhoa
            // 
            this.comboBox_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaKhoa.FormattingEnabled = true;
            this.comboBox_MaKhoa.Location = new System.Drawing.Point(74, 65);
            this.comboBox_MaKhoa.Name = "comboBox_MaKhoa";
            this.comboBox_MaKhoa.Size = new System.Drawing.Size(259, 21);
            this.comboBox_MaKhoa.TabIndex = 16;
            // 
            // comboBox_MaMon
            // 
            this.comboBox_MaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaMon.FormattingEnabled = true;
            this.comboBox_MaMon.Location = new System.Drawing.Point(462, 6);
            this.comboBox_MaMon.Name = "comboBox_MaMon";
            this.comboBox_MaMon.Size = new System.Drawing.Size(194, 21);
            this.comboBox_MaMon.TabIndex = 17;
            this.comboBox_MaMon.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaMon_SelectedIndexChanged);
            // 
            // comboBox_MaGiaoVien
            // 
            this.comboBox_MaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaGiaoVien.FormattingEnabled = true;
            this.comboBox_MaGiaoVien.Location = new System.Drawing.Point(492, 65);
            this.comboBox_MaGiaoVien.Name = "comboBox_MaGiaoVien";
            this.comboBox_MaGiaoVien.Size = new System.Drawing.Size(164, 21);
            this.comboBox_MaGiaoVien.TabIndex = 18;
            this.comboBox_MaGiaoVien.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaGiaoVien_SelectedIndexChanged);
            // 
            // textBox_TenMon
            // 
            this.textBox_TenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenMon.Location = new System.Drawing.Point(403, 34);
            this.textBox_TenMon.Name = "textBox_TenMon";
            this.textBox_TenMon.ReadOnly = true;
            this.textBox_TenMon.Size = new System.Drawing.Size(253, 20);
            this.textBox_TenMon.TabIndex = 19;
            // 
            // textBox_TenGiaoVien
            // 
            this.textBox_TenGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenGiaoVien.Location = new System.Drawing.Point(403, 92);
            this.textBox_TenGiaoVien.Name = "textBox_TenGiaoVien";
            this.textBox_TenGiaoVien.ReadOnly = true;
            this.textBox_TenGiaoVien.Size = new System.Drawing.Size(253, 20);
            this.textBox_TenGiaoVien.TabIndex = 20;
            // 
            // Frm_CapNhatDeThi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 541);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_TenGiaoVien);
            this.Controls.Add(this.textBox_TenMon);
            this.Controls.Add(this.comboBox_MaGiaoVien);
            this.Controls.Add(this.comboBox_MaMon);
            this.Controls.Add(this.comboBox_MaKhoa);
            this.Controls.Add(this.comboBox_MaLop);
            this.Controls.Add(this.textBox_MaDe);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_CapNhatDeThi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Đề Thi";
            this.Load += new System.EventHandler(this.Frm_CapNhatDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.TextBox textBox_MaDe;
        private System.Windows.Forms.ComboBox comboBox_MaLop;
        private System.Windows.Forms.ComboBox comboBox_MaKhoa;
        private System.Windows.Forms.ComboBox comboBox_MaMon;
        private System.Windows.Forms.ComboBox comboBox_MaGiaoVien;
        private System.Windows.Forms.TextBox textBox_TenMon;
        private System.Windows.Forms.TextBox textBox_TenGiaoVien;
    }
}