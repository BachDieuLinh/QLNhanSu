namespace QLY_NHANSU
{
    partial class frm_NV
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.gr_TK = new System.Windows.Forms.GroupBox();
            this.rbtDiaChi = new System.Windows.Forms.RadioButton();
            this.rbtSDT = new System.Windows.Forms.RadioButton();
            this.rbtgt = new System.Windows.Forms.RadioButton();
            this.rbtTenNV = new System.Windows.Forms.RadioButton();
            this.rbtMaNV = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.clmMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_NS = new System.Windows.Forms.DateTimePicker();
            this.cb_GT = new System.Windows.Forms.ComboBox();
            this.gr_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(62, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(62, 186);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 75;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // gr_TK
            // 
            this.gr_TK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gr_TK.Controls.Add(this.rbtDiaChi);
            this.gr_TK.Controls.Add(this.rbtSDT);
            this.gr_TK.Controls.Add(this.rbtgt);
            this.gr_TK.Controls.Add(this.rbtTenNV);
            this.gr_TK.Controls.Add(this.rbtMaNV);
            this.gr_TK.Controls.Add(this.btnTimkiem);
            this.gr_TK.Controls.Add(this.txtTimKiem);
            this.gr_TK.Location = new System.Drawing.Point(752, 40);
            this.gr_TK.Name = "gr_TK";
            this.gr_TK.Size = new System.Drawing.Size(267, 178);
            this.gr_TK.TabIndex = 74;
            this.gr_TK.TabStop = false;
            this.gr_TK.Text = "Tìm kiếm";
            // 
            // rbtDiaChi
            // 
            this.rbtDiaChi.AutoSize = true;
            this.rbtDiaChi.Location = new System.Drawing.Point(16, 92);
            this.rbtDiaChi.Name = "rbtDiaChi";
            this.rbtDiaChi.Size = new System.Drawing.Size(59, 17);
            this.rbtDiaChi.TabIndex = 34;
            this.rbtDiaChi.TabStop = true;
            this.rbtDiaChi.Text = "Địa Chỉ";
            this.rbtDiaChi.UseVisualStyleBackColor = true;
            this.rbtDiaChi.CheckedChanged += new System.EventHandler(this.rbtDiaChi_CheckedChanged);
            // 
            // rbtSDT
            // 
            this.rbtSDT.AutoSize = true;
            this.rbtSDT.Location = new System.Drawing.Point(16, 140);
            this.rbtSDT.Name = "rbtSDT";
            this.rbtSDT.Size = new System.Drawing.Size(88, 17);
            this.rbtSDT.TabIndex = 33;
            this.rbtSDT.TabStop = true;
            this.rbtSDT.Text = "Số điện thoại";
            this.rbtSDT.UseVisualStyleBackColor = true;
            this.rbtSDT.CheckedChanged += new System.EventHandler(this.rbtSDT_CheckedChanged);
            this.rbtSDT.Click += new System.EventHandler(this.rbtSDT_CheckedChanged);
            // 
            // rbtgt
            // 
            this.rbtgt.AutoSize = true;
            this.rbtgt.Location = new System.Drawing.Point(18, 117);
            this.rbtgt.Name = "rbtgt";
            this.rbtgt.Size = new System.Drawing.Size(69, 17);
            this.rbtgt.TabIndex = 32;
            this.rbtgt.TabStop = true;
            this.rbtgt.Text = "Giới Tính";
            this.rbtgt.UseVisualStyleBackColor = true;
            this.rbtgt.CheckedChanged += new System.EventHandler(this.rbtgt_CheckedChanged);
            // 
            // rbtTenNV
            // 
            this.rbtTenNV.AutoSize = true;
            this.rbtTenNV.Location = new System.Drawing.Point(16, 69);
            this.rbtTenNV.Name = "rbtTenNV";
            this.rbtTenNV.Size = new System.Drawing.Size(94, 17);
            this.rbtTenNV.TabIndex = 31;
            this.rbtTenNV.TabStop = true;
            this.rbtTenNV.Text = "Tên nhân viên";
            this.rbtTenNV.UseVisualStyleBackColor = true;
            this.rbtTenNV.CheckedChanged += new System.EventHandler(this.rbtTenNV_CheckedChanged);
            // 
            // rbtMaNV
            // 
            this.rbtMaNV.AutoSize = true;
            this.rbtMaNV.Location = new System.Drawing.Point(16, 47);
            this.rbtMaNV.Name = "rbtMaNV";
            this.rbtMaNV.Size = new System.Drawing.Size(90, 17);
            this.rbtMaNV.TabIndex = 30;
            this.rbtMaNV.TabStop = true;
            this.rbtMaNV.Text = "Mã nhân viên";
            this.rbtMaNV.UseVisualStyleBackColor = true;
            this.rbtMaNV.CheckedChanged += new System.EventHandler(this.rbtMaNV_CheckedChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(257, 213);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 28;
            this.btnTimkiem.Text = "Tìm  kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(18, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(233, 20);
            this.txtTimKiem.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(354, 207);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(155, 20);
            this.txtLuong.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Chức vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(354, 145);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(155, 20);
            this.txtChucVu.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tên  nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(354, 176);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(258, 20);
            this.txtSDT.TabIndex = 65;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(354, 56);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(258, 20);
            this.txtTenNV.TabIndex = 64;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(354, 238);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 20);
            this.txtDiaChi.TabIndex = 63;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(354, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(155, 20);
            this.txtMaNV.TabIndex = 62;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(62, 81);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(62, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 60;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(62, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(62, 47);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaNV,
            this.clmTenNV,
            this.Column1,
            this.Column2,
            this.clmChucVu,
            this.clmSDT,
            this.clmLuong,
            this.clmDiaChi});
            this.dgvNhanVien.Location = new System.Drawing.Point(29, 313);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1049, 233);
            this.dgvNhanVien.TabIndex = 57;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // clmMaNV
            // 
            this.clmMaNV.DataPropertyName = "MaNV";
            this.clmMaNV.HeaderText = "Mã  nhân viên";
            this.clmMaNV.Name = "clmMaNV";
            // 
            // clmTenNV
            // 
            this.clmTenNV.DataPropertyName = "TenNV";
            this.clmTenNV.HeaderText = "Tên nhân viên";
            this.clmTenNV.Name = "clmTenNV";
            this.clmTenNV.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NS";
            this.Column1.HeaderText = "Ngày sinh";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GT";
            this.Column2.HeaderText = "Giới tính";
            this.Column2.Name = "Column2";
            // 
            // clmChucVu
            // 
            this.clmChucVu.DataPropertyName = "ChucVu";
            this.clmChucVu.HeaderText = "Chức vụ";
            this.clmChucVu.Name = "clmChucVu";
            this.clmChucVu.Width = 150;
            // 
            // clmSDT
            // 
            this.clmSDT.DataPropertyName = "SDT";
            this.clmSDT.HeaderText = "Số điện thoại";
            this.clmSDT.Name = "clmSDT";
            // 
            // clmLuong
            // 
            this.clmLuong.DataPropertyName = "LUONG";
            this.clmLuong.HeaderText = "Lương";
            this.clmLuong.Name = "clmLuong";
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.DataPropertyName = "DiaChi";
            this.clmDiaChi.HeaderText = "Địa chỉ";
            this.clmDiaChi.Name = "clmDiaChi";
            this.clmDiaChi.Width = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Giới Tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Ngày sinh";
            // 
            // dtp_NS
            // 
            this.dtp_NS.Location = new System.Drawing.Point(354, 83);
            this.dtp_NS.Name = "dtp_NS";
            this.dtp_NS.Size = new System.Drawing.Size(200, 20);
            this.dtp_NS.TabIndex = 80;
            // 
            // cb_GT
            // 
            this.cb_GT.FormattingEnabled = true;
            this.cb_GT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GT.Location = new System.Drawing.Point(354, 112);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(121, 21);
            this.cb_GT.TabIndex = 81;
            // 
            // frm_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 559);
            this.Controls.Add(this.cb_GT);
            this.Controls.Add(this.dtp_NS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gr_TK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "frm_NV";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frm_NV_Load);
            this.gr_TK.ResumeLayout(false);
            this.gr_TK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox gr_TK;
        private System.Windows.Forms.RadioButton rbtDiaChi;
        private System.Windows.Forms.RadioButton rbtSDT;
        private System.Windows.Forms.RadioButton rbtgt;
        private System.Windows.Forms.RadioButton rbtTenNV;
        private System.Windows.Forms.RadioButton rbtMaNV;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_NS;
        private System.Windows.Forms.ComboBox cb_GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
    }
}