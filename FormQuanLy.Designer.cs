﻿namespace LTTQ_Proj
{
    partial class FormQuanLy
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnPThoat = new Button();
            btnPTimKiem = new Button();
            btnPXoa = new Button();
            btnPSua = new Button();
            btnPThem = new Button();
            grbDannhSachPhong = new GroupBox();
            dgvPDanhSachPhong = new DataGridView();
            grbThongTinPhong = new GroupBox();
            cmbPSoNguoiToiDa = new ComboBox();
            grbLoaiPhong = new GroupBox();
            rdbPNu = new RadioButton();
            rdbPNam = new RadioButton();
            txtPGhiChu = new TextBox();
            txtPTienThue = new TextBox();
            txtPSoNguoiDangO = new TextBox();
            txtPMaNha = new TextBox();
            txtPTenPhong = new TextBox();
            txtPMaPhong = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label9 = new Label();
            btnTThoat = new Button();
            btnTThem = new Button();
            btnThueTimKiem = new Button();
            groupBox2 = new GroupBox();
            dgvDSPhongConTrong = new DataGridView();
            groupBox3 = new GroupBox();
            dvgDSSVThuePhong = new DataGridView();
            groupBox1 = new GroupBox();
            tabSinhVien = new TabPage();
            labelQLSinhVien = new Label();
            groupBoxSinhVienViewData = new GroupBox();
            dataGridViewSinhVien = new DataGridView();
            groupBoxSinhVien2 = new GroupBox();
            btnSVThem = new Button();
            btnSVSua = new Button();
            btnSVXoa = new Button();
            groupBoxSinhVien1 = new GroupBox();
            inputSVMaLop = new ComboBox();
            inputSVMaKhoa = new ComboBox();
            inputSVMaQue = new ComboBox();
            inputSVGioiTinh = new ComboBox();
            labelSVMaLop = new Label();
            labelSVMaKhoa = new Label();
            labelSVMaQue = new Label();
            labelSVGioiTinh = new Label();
            labelSVNgaySinh = new Label();
            inputSVNgaySinh = new TextBox();
            inputSVTenSinhVien = new TextBox();
            labelSVTenSV = new Label();
            inputSVMaSinhVien = new TextBox();
            labelSVMaSV = new Label();
            tabPage3 = new TabPage();

            errorPhong = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grbDannhSachPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPDanhSachPhong).BeginInit();
            grbThongTinPhong.SuspendLayout();
            grbLoaiPhong.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongConTrong).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDSSVThuePhong).BeginInit();
            tabSinhVien.SuspendLayout();
            groupBoxSinhVienViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            groupBoxSinhVien2.SuspendLayout();
            groupBoxSinhVien1.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)errorPhong).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabSinhVien);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1102, 508);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnPThoat);
            tabPage1.Controls.Add(btnPTimKiem);
            tabPage1.Controls.Add(btnPXoa);
            tabPage1.Controls.Add(btnPSua);
            tabPage1.Controls.Add(btnPThem);
            tabPage1.Controls.Add(grbDannhSachPhong);
            tabPage1.Controls.Add(grbThongTinPhong);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1094, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Phòng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPThoat
            // 
            btnPThoat.Location = new Point(809, 400);
            btnPThoat.Margin = new Padding(3, 2, 3, 2);
            btnPThoat.Name = "btnPThoat";
            btnPThoat.Size = new Size(108, 30);
            btnPThoat.TabIndex = 4;
            btnPThoat.Text = "Thoát";
            btnPThoat.UseVisualStyleBackColor = true;
            btnPThoat.Click += btnPThoat_Click;
            // 
            // btnPTimKiem
            // 
            btnPTimKiem.Location = new Point(494, 400);
            btnPTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnPTimKiem.Name = "btnPTimKiem";
            btnPTimKiem.Size = new Size(108, 30);
            btnPTimKiem.TabIndex = 4;
            btnPTimKiem.Text = "Tìm Kiếm";
            btnPTimKiem.UseVisualStyleBackColor = true;
            btnPTimKiem.Click += btnPTimKiem_Click;
            // 
            // btnPXoa
            // 
            btnPXoa.Location = new Point(263, 442);
            btnPXoa.Margin = new Padding(3, 2, 3, 2);
            btnPXoa.Name = "btnPXoa";
            btnPXoa.Size = new Size(89, 26);
            btnPXoa.TabIndex = 4;
            btnPXoa.Text = "Xoá";
            btnPXoa.UseVisualStyleBackColor = true;
            btnPXoa.Click += btnPXoa_Click;
            // 
            // btnPSua
            // 
            btnPSua.Location = new Point(148, 442);
            btnPSua.Margin = new Padding(3, 2, 3, 2);
            btnPSua.Name = "btnPSua";
            btnPSua.Size = new Size(89, 26);
            btnPSua.TabIndex = 4;
            btnPSua.Text = "Sửa";
            btnPSua.UseVisualStyleBackColor = true;
            btnPSua.Click += btnPSua_Click;
            // 
            // btnPThem
            // 
            btnPThem.Location = new Point(33, 442);
            btnPThem.Margin = new Padding(3, 2, 3, 2);
            btnPThem.Name = "btnPThem";
            btnPThem.Size = new Size(89, 26);
            btnPThem.TabIndex = 4;
            btnPThem.Text = "Thêm";
            btnPThem.UseVisualStyleBackColor = true;
            btnPThem.Click += btnPThem_Click;
            // 
            // grbDannhSachPhong
            // 
            grbDannhSachPhong.Controls.Add(dgvPDanhSachPhong);
            grbDannhSachPhong.Location = new Point(369, 38);
            grbDannhSachPhong.Margin = new Padding(3, 2, 3, 2);
            grbDannhSachPhong.Name = "grbDannhSachPhong";
            grbDannhSachPhong.Padding = new Padding(3, 2, 3, 2);
            grbDannhSachPhong.Size = new Size(711, 333);
            grbDannhSachPhong.TabIndex = 3;
            grbDannhSachPhong.TabStop = false;
            grbDannhSachPhong.Text = "Danh Sách Phòng";
            // 
            // dgvPDanhSachPhong
            // 
            dgvPDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPDanhSachPhong.Dock = DockStyle.Fill;
            dgvPDanhSachPhong.Location = new Point(3, 18);
            dgvPDanhSachPhong.Margin = new Padding(3, 2, 3, 2);
            dgvPDanhSachPhong.Name = "dgvPDanhSachPhong";
            dgvPDanhSachPhong.RowHeadersWidth = 51;
            dgvPDanhSachPhong.RowTemplate.Height = 29;
            dgvPDanhSachPhong.Size = new Size(705, 313);
            dgvPDanhSachPhong.TabIndex = 0;
            dgvPDanhSachPhong.CellContentClick += dgvPDanhSachPhong_CellContentClick;
            // 
            // grbThongTinPhong
            // 
            grbThongTinPhong.Controls.Add(cmbPSoNguoiToiDa);
            grbThongTinPhong.Controls.Add(grbLoaiPhong);
            grbThongTinPhong.Controls.Add(txtPGhiChu);
            grbThongTinPhong.Controls.Add(txtPTienThue);
            grbThongTinPhong.Controls.Add(txtPSoNguoiDangO);
            grbThongTinPhong.Controls.Add(txtPMaNha);
            grbThongTinPhong.Controls.Add(txtPTenPhong);
            grbThongTinPhong.Controls.Add(txtPMaPhong);
            grbThongTinPhong.Controls.Add(label5);
            grbThongTinPhong.Controls.Add(label8);
            grbThongTinPhong.Controls.Add(label7);
            grbThongTinPhong.Controls.Add(label6);
            grbThongTinPhong.Controls.Add(label4);
            grbThongTinPhong.Controls.Add(label3);
            grbThongTinPhong.Controls.Add(label2);
            grbThongTinPhong.Location = new Point(18, 38);
            grbThongTinPhong.Margin = new Padding(3, 2, 3, 2);
            grbThongTinPhong.Name = "grbThongTinPhong";
            grbThongTinPhong.Padding = new Padding(3, 2, 3, 2);
            grbThongTinPhong.Size = new Size(346, 388);
            grbThongTinPhong.TabIndex = 2;
            grbThongTinPhong.TabStop = false;
            grbThongTinPhong.Text = "Thông tin phòng";
            // 
            // cmbPSoNguoiToiDa
            // 
            cmbPSoNguoiToiDa.FormattingEnabled = true;
            cmbPSoNguoiToiDa.Location = new Point(151, 226);
            cmbPSoNguoiToiDa.Margin = new Padding(3, 2, 3, 2);
            cmbPSoNguoiToiDa.Name = "cmbPSoNguoiToiDa";
            cmbPSoNguoiToiDa.Size = new Size(120, 23);
            cmbPSoNguoiToiDa.TabIndex = 3;
            // 
            // grbLoaiPhong
            // 
            grbLoaiPhong.Controls.Add(rdbPNu);
            grbLoaiPhong.Controls.Add(rdbPNam);
            grbLoaiPhong.Location = new Point(25, 137);
            grbLoaiPhong.Margin = new Padding(3, 2, 3, 2);
            grbLoaiPhong.Name = "grbLoaiPhong";
            grbLoaiPhong.Padding = new Padding(3, 2, 3, 2);
            grbLoaiPhong.Size = new Size(248, 69);
            grbLoaiPhong.TabIndex = 2;
            grbLoaiPhong.TabStop = false;
            grbLoaiPhong.Text = "Loại Phòng";
            // 
            // rdbPNu
            // 
            rdbPNu.AutoSize = true;
            rdbPNu.Location = new Point(157, 26);
            rdbPNu.Margin = new Padding(3, 2, 3, 2);
            rdbPNu.Name = "rdbPNu";
            rdbPNu.Size = new Size(41, 19);
            rdbPNu.TabIndex = 3;
            rdbPNu.TabStop = true;
            rdbPNu.Text = "Nữ";
            rdbPNu.UseVisualStyleBackColor = true;
            // 
            // rdbPNam
            // 
            rdbPNam.AutoSize = true;
            rdbPNam.Location = new Point(33, 26);
            rdbPNam.Margin = new Padding(3, 2, 3, 2);
            rdbPNam.Name = "rdbPNam";
            rdbPNam.Size = new Size(51, 19);
            rdbPNam.TabIndex = 2;
            rdbPNam.TabStop = true;
            rdbPNam.Text = "Nam";
            rdbPNam.UseVisualStyleBackColor = true;
            // 
            // txtPGhiChu
            // 
            txtPGhiChu.Location = new Point(112, 333);
            txtPGhiChu.Margin = new Padding(3, 2, 3, 2);
            txtPGhiChu.Name = "txtPGhiChu";
            txtPGhiChu.Size = new Size(162, 23);
            txtPGhiChu.TabIndex = 1;
            // 
            // txtPTienThue
            // 
            txtPTienThue.Location = new Point(112, 299);
            txtPTienThue.Margin = new Padding(3, 2, 3, 2);
            txtPTienThue.Name = "txtPTienThue";
            txtPTienThue.Size = new Size(162, 23);
            txtPTienThue.TabIndex = 1;
            // 
            // txtPSoNguoiDangO
            // 
            txtPSoNguoiDangO.Location = new Point(151, 260);
            txtPSoNguoiDangO.Margin = new Padding(3, 2, 3, 2);
            txtPSoNguoiDangO.Name = "txtPSoNguoiDangO";
            txtPSoNguoiDangO.Size = new Size(123, 23);
            txtPSoNguoiDangO.TabIndex = 1;
            // 
            // txtPMaNha
            // 
            txtPMaNha.Location = new Point(109, 96);
            txtPMaNha.Margin = new Padding(3, 2, 3, 2);
            txtPMaNha.Name = "txtPMaNha";
            txtPMaNha.Size = new Size(162, 23);
            txtPMaNha.TabIndex = 1;
            // 
            // txtPTenPhong
            // 
            txtPTenPhong.Location = new Point(109, 61);
            txtPTenPhong.Margin = new Padding(3, 2, 3, 2);
            txtPTenPhong.Name = "txtPTenPhong";
            txtPTenPhong.Size = new Size(162, 23);
            txtPTenPhong.TabIndex = 1;
            // 
            // txtPMaPhong
            // 
            txtPMaPhong.Location = new Point(109, 28);
            txtPMaPhong.Margin = new Padding(3, 2, 3, 2);
            txtPMaPhong.Name = "txtPMaPhong";
            txtPMaPhong.Size = new Size(162, 23);
            txtPMaPhong.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 228);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 0;
            label5.Text = "Số người ở tối đa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 335);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 0;
            label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 296);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 0;
            label7.Text = "Tiền Thuê";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 262);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 0;
            label6.Text = "Số người đang ở";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 98);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 0;
            label4.Text = "Mã Nhà";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 63);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Tên Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 28);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(479, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Phòng";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(btnTThoat);
            tabPage2.Controls.Add(btnTThem);
            tabPage2.Controls.Add(btnThueTimKiem);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1094, 480);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Thuê Phòng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(527, 15);
            label9.Name = "label9";
            label9.Size = new Size(296, 31);
            label9.TabIndex = 4;
            label9.Text = "Thuê Phòng cho Sinh Viên";
            // 
            // btnTThoat
            // 
            btnTThoat.Location = new Point(919, 571);
            btnTThoat.Name = "btnTThoat";
            btnTThoat.Size = new Size(121, 42);
            btnTThoat.TabIndex = 3;
            btnTThoat.Text = "Thoát";
            btnTThoat.UseVisualStyleBackColor = true;
            // 
            // btnTThem
            // 
            btnTThem.Location = new Point(560, 571);
            btnTThem.Name = "btnTThem";
            btnTThem.Size = new Size(121, 42);
            btnTThem.TabIndex = 3;
            btnTThem.Text = "Thêm";
            btnTThem.UseVisualStyleBackColor = true;
            // 
            // btnThueTimKiem
            // 
            btnThueTimKiem.Location = new Point(132, 571);
            btnThueTimKiem.Name = "btnThueTimKiem";
            btnThueTimKiem.Size = new Size(121, 42);
            btnThueTimKiem.TabIndex = 3;
            btnThueTimKiem.Text = "Tìm Kiếm";
            btnThueTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDSPhongConTrong);
            groupBox2.Location = new Point(628, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(616, 353);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Phòng còn trống";
            // 
            // dgvDSPhongConTrong
            // 
            dgvDSPhongConTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhongConTrong.Dock = DockStyle.Fill;
            dgvDSPhongConTrong.Location = new Point(3, 23);
            dgvDSPhongConTrong.Name = "dgvDSPhongConTrong";
            dgvDSPhongConTrong.RowHeadersWidth = 51;
            dgvDSPhongConTrong.RowTemplate.Height = 29;
            dgvDSPhongConTrong.Size = new Size(610, 327);
            dgvDSPhongConTrong.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dvgDSSVThuePhong);
            groupBox3.Location = new Point(6, 180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(607, 353);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách Sinh Viên muốn thuê";
            // 
            // dvgDSSVThuePhong
            // 
            dvgDSSVThuePhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDSSVThuePhong.Dock = DockStyle.Fill;
            dvgDSSVThuePhong.Location = new Point(3, 23);
            dvgDSSVThuePhong.Name = "dvgDSSVThuePhong";
            dvgDSSVThuePhong.RowHeadersWidth = 51;
            dvgDSSVThuePhong.RowTemplate.Height = 29;
            dvgDSSVThuePhong.Size = new Size(601, 327);
            dvgDSSVThuePhong.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(9, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1232, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tabSinhVien
            // 
            tabSinhVien.Controls.Add(labelQLSinhVien);
            tabSinhVien.Controls.Add(groupBoxSinhVienViewData);
            tabSinhVien.Controls.Add(groupBoxSinhVien2);
            tabSinhVien.Controls.Add(groupBoxSinhVien1);
            tabSinhVien.Location = new Point(4, 24);
            tabSinhVien.Name = "tabSinhVien";
            tabSinhVien.Padding = new Padding(3, 4, 3, 4);
            tabSinhVien.Size = new Size(1252, 645);
            tabSinhVien.TabIndex = 1;
            tabSinhVien.Text = "Sinh Viên";
            tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // labelQLSinhVien
            // 
            labelQLSinhVien.AutoSize = true;
            labelQLSinhVien.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQLSinhVien.Location = new Point(447, 24);
            labelQLSinhVien.Name = "labelQLSinhVien";
            labelQLSinhVien.Size = new Size(226, 37);
            labelQLSinhVien.TabIndex = 3;
            labelQLSinhVien.Text = "Quản lý Sinh Viên";
            // 
            // groupBoxSinhVienViewData
            // 
            groupBoxSinhVienViewData.Controls.Add(dataGridViewSinhVien);
            groupBoxSinhVienViewData.Location = new Point(406, 64);
            groupBoxSinhVienViewData.Name = "groupBoxSinhVienViewData";
            groupBoxSinhVienViewData.Size = new Size(682, 408);
            groupBoxSinhVienViewData.TabIndex = 2;
            groupBoxSinhVienViewData.TabStop = false;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Dock = DockStyle.Fill;
            dataGridViewSinhVien.Location = new Point(3, 19);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 51;
            dataGridViewSinhVien.RowTemplate.Height = 25;
            dataGridViewSinhVien.Size = new Size(676, 386);
            dataGridViewSinhVien.TabIndex = 0;
            // 
            // groupBoxSinhVien2
            // 
            groupBoxSinhVien2.Controls.Add(btnSVXoa);
            groupBoxSinhVien2.Controls.Add(btnSVSua);
            groupBoxSinhVien2.Controls.Add(btnSVThem);
            groupBoxSinhVien2.Location = new Point(10, 362);
            groupBoxSinhVien2.Name = "groupBoxSinhVien2";
            groupBoxSinhVien2.Size = new Size(390, 110);
            groupBoxSinhVien2.TabIndex = 1;
            groupBoxSinhVien2.TabStop = false;
            // 
            // btnSVThem
            // 
            btnSVThem.Location = new Point(27, 46);
            btnSVThem.Name = "btnSVThem";
            btnSVThem.Size = new Size(90, 30);
            btnSVThem.TabIndex = 0;
            btnSVThem.Text = "Thêm";
            btnSVThem.UseVisualStyleBackColor = true;
            btnSVThem.Click += btnSVThem_Click;
            // 
            // groupBoxSinhVien1
            // 
            groupBoxSinhVien1.Controls.Add(inputSVMaLop);
            groupBoxSinhVien1.Controls.Add(inputSVMaKhoa);
            groupBoxSinhVien1.Controls.Add(inputSVMaQue);
            groupBoxSinhVien1.Controls.Add(inputSVGioiTinh);
            groupBoxSinhVien1.Controls.Add(labelSVMaLop);
            groupBoxSinhVien1.Controls.Add(labelSVMaKhoa);
            groupBoxSinhVien1.Controls.Add(labelSVMaQue);
            groupBoxSinhVien1.Controls.Add(labelSVGioiTinh);
            groupBoxSinhVien1.Controls.Add(labelSVNgaySinh);
            groupBoxSinhVien1.Controls.Add(inputSVNgaySinh);
            groupBoxSinhVien1.Controls.Add(inputSVTenSinhVien);
            groupBoxSinhVien1.Controls.Add(labelSVTenSV);
            groupBoxSinhVien1.Controls.Add(inputSVMaSinhVien);
            groupBoxSinhVien1.Controls.Add(labelSVMaSV);
            groupBoxSinhVien1.Location = new Point(10, 64);
            groupBoxSinhVien1.Name = "groupBoxSinhVien1";
            groupBoxSinhVien1.Size = new Size(390, 292);
            groupBoxSinhVien1.TabIndex = 0;
            groupBoxSinhVien1.TabStop = false;
            // 
            // inputSVMaLop
            // 
            inputSVMaLop.FormattingEnabled = true;
            inputSVMaLop.Location = new Point(130, 219);
            inputSVMaLop.Name = "inputSVMaLop";
            inputSVMaLop.Size = new Size(98, 23);
            inputSVMaLop.TabIndex = 3;
            // 
            // inputSVMaKhoa
            // 
            inputSVMaKhoa.FormattingEnabled = true;
            inputSVMaKhoa.Location = new Point(130, 187);
            inputSVMaKhoa.Name = "inputSVMaKhoa";
            inputSVMaKhoa.Size = new Size(98, 23);
            inputSVMaKhoa.TabIndex = 3;
            inputSVMaKhoa.SelectedIndexChanged += inputSVMaKhoa_SelectedIndexChanged;
            // 
            // inputSVMaQue
            // 
            inputSVMaQue.FormattingEnabled = true;
            inputSVMaQue.Location = new Point(130, 153);
            inputSVMaQue.Name = "inputSVMaQue";
            inputSVMaQue.Size = new Size(98, 23);
            inputSVMaQue.TabIndex = 3;
            // 
            // inputSVGioiTinh
            // 
            inputSVGioiTinh.FormattingEnabled = true;
            inputSVGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            inputSVGioiTinh.Location = new Point(130, 120);
            inputSVGioiTinh.Name = "inputSVGioiTinh";
            inputSVGioiTinh.Size = new Size(98, 23);
            inputSVGioiTinh.TabIndex = 3;
            // 
            // labelSVMaLop
            // 
            labelSVMaLop.AutoSize = true;
            labelSVMaLop.Location = new Point(27, 222);
            labelSVMaLop.Name = "labelSVMaLop";
            labelSVMaLop.Size = new Size(27, 15);
            labelSVMaLop.TabIndex = 2;
            labelSVMaLop.Text = "Lớp";
            // 
            // labelSVMaKhoa
            // 
            labelSVMaKhoa.AutoSize = true;
            labelSVMaKhoa.Location = new Point(27, 190);
            labelSVMaKhoa.Name = "labelSVMaKhoa";
            labelSVMaKhoa.Size = new Size(34, 15);
            labelSVMaKhoa.TabIndex = 2;
            labelSVMaKhoa.Text = "Khoa";
            // 
            // labelSVMaQue
            // 
            labelSVMaQue.AutoSize = true;
            labelSVMaQue.Location = new Point(27, 156);
            labelSVMaQue.Name = "labelSVMaQue";
            labelSVMaQue.Size = new Size(29, 15);
            labelSVMaQue.TabIndex = 2;
            labelSVMaQue.Text = "Quê";
            // 
            // labelSVGioiTinh
            // 
            labelSVGioiTinh.AutoSize = true;
            labelSVGioiTinh.Location = new Point(27, 123);
            labelSVGioiTinh.Name = "labelSVGioiTinh";
            labelSVGioiTinh.Size = new Size(52, 15);
            labelSVGioiTinh.TabIndex = 2;
            labelSVGioiTinh.Text = "Giới tính";
            // 
            // labelSVNgaySinh
            // 
            labelSVNgaySinh.AutoSize = true;
            labelSVNgaySinh.Location = new Point(27, 90);
            labelSVNgaySinh.Name = "labelSVNgaySinh";
            labelSVNgaySinh.Size = new Size(60, 15);
            labelSVNgaySinh.TabIndex = 2;
            labelSVNgaySinh.Text = "Ngày sinh";
            // 
            // inputSVNgaySinh
            // 
            inputSVNgaySinh.Location = new Point(130, 86);
            inputSVNgaySinh.Name = "inputSVNgaySinh";
            inputSVNgaySinh.Size = new Size(214, 23);
            inputSVNgaySinh.TabIndex = 1;
            // 
            // inputSVTenSinhVien
            // 
            inputSVTenSinhVien.Location = new Point(130, 57);
            inputSVTenSinhVien.Name = "inputSVTenSinhVien";
            inputSVTenSinhVien.Size = new Size(214, 23);
            inputSVTenSinhVien.TabIndex = 1;
            // 
            // labelSVTenSV
            // 
            labelSVTenSV.AutoSize = true;
            labelSVTenSV.Location = new Point(27, 60);
            labelSVTenSV.Name = "labelSVTenSV";
            labelSVTenSV.Size = new Size(75, 15);
            labelSVTenSV.TabIndex = 0;
            labelSVTenSV.Text = "Tên sinh viên";
            // 
            // inputSVMaSinhVien
            // 
            inputSVMaSinhVien.Location = new Point(130, 28);
            inputSVMaSinhVien.Name = "inputSVMaSinhVien";
            inputSVMaSinhVien.Size = new Size(214, 23);
            inputSVMaSinhVien.TabIndex = 1;
            // 
            // labelSVMaSV
            // 
            labelSVMaSV.AutoSize = true;
            labelSVMaSV.Location = new Point(27, 31);
            labelSVMaSV.Name = "labelSVMaSV";
            labelSVMaSV.Size = new Size(74, 15);
            labelSVMaSV.TabIndex = 0;
            labelSVMaSV.Text = "Mã sinh viên";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1252, 645);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSVSua
            // 
            btnSVSua.Location = new Point(153, 46);
            btnSVSua.Name = "btnSVSua";
            btnSVSua.Size = new Size(90, 30);
            btnSVSua.TabIndex = 0;
            btnSVSua.Text = "Sửa";
            btnSVSua.UseVisualStyleBackColor = true;
            // 
            // btnSVXoa
            // 
            btnSVXoa.Location = new Point(270, 46);
            btnSVXoa.Name = "btnSVXoa";
            btnSVXoa.Size = new Size(90, 30);
            btnSVXoa.TabIndex = 0;
            btnSVXoa.Text = "Xoá";
            btnSVXoa.UseVisualStyleBackColor = true;
            // errorPhong
            // 
            errorPhong.ContainerControl = this;
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 508);
            Controls.Add(tabControl1);
            Name = "FormQuanLy";
            Text = "FormQuanLy";
            Load += FormQuanLy_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grbDannhSachPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPDanhSachPhong).EndInit();
            grbThongTinPhong.ResumeLayout(false);
            grbThongTinPhong.PerformLayout();
            grbLoaiPhong.ResumeLayout(false);
            grbLoaiPhong.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongConTrong).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgDSSVThuePhong).EndInit();
            tabSinhVien.ResumeLayout(false);
            tabSinhVien.PerformLayout();
            groupBoxSinhVienViewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            groupBoxSinhVien2.ResumeLayout(false);
            groupBoxSinhVien1.ResumeLayout(false);
            groupBoxSinhVien1.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)errorPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabSinhVien;
        private GroupBox groupBoxSinhVien2;
        private GroupBox groupBoxSinhVien1;
        private GroupBox groupBoxSinhVienViewData;
        private DataGridView dataGridViewSinhVien;
        private Label labelSVMaSV;
        private TextBox inputSVMaSinhVien;
        private TextBox inputSVTenSinhVien;
        private Label labelSVTenSV;
        private Label labelSVNgaySinh;
        private Label labelSVGioiTinh;
        private TextBox inputSVNgaySinh;
        private ComboBox inputSVGioiTinh;
        private ComboBox inputSVMaLop;
        private ComboBox inputSVMaKhoa;
        private ComboBox inputSVMaQue;
        private Label labelSVMaLop;
        private Label labelSVMaKhoa;
        private Label labelSVMaQue;
        private Button btnSVThem;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private GroupBox grbDannhSachPhong;
        private GroupBox grbThongTinPhong;
        private TextBox txtPTenPhong;
        private TextBox txtPMaPhong;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grbLoaiPhong;
        private RadioButton rdbPNu;
        private RadioButton rdbPNam;
        private ComboBox cmbPSoNguoiToiDa;
        private Label label5;
        private TextBox txtPGhiChu;
        private TextBox txtPTienThue;
        private TextBox txtPSoNguoiDangO;
        private TextBox txtPMaNha;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dgvPDanhSachPhong;
        private Button btnPThem;
        private Button btnPThoat;
        private Button btnPTimKiem;
        private Button btnPXoa;
        private Button btnPSua;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dgvDSPhongConTrong;
        private DataGridView dvgDSSVThuePhong;
        private Button btnTThoat;
        private Button btnTThem;
        private Button btnThueTimKiem;
        private Label label9;
        private Label labelQLSinhVien;
        private Button btnSVSua;
        private Button btnSVXoa;
        private ErrorProvider errorPhong;
    }
}