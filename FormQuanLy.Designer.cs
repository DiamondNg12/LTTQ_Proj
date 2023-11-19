namespace LTTQ_Proj
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
            tabSinhVien = new TabPage();
            groupBoxSinhVienViewData = new GroupBox();
            dataGridViewSinhVien = new DataGridView();
            groupBoxSinhVien2 = new GroupBox();
            btnSVThem = new Button();
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grbDannhSachPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPDanhSachPhong).BeginInit();
            grbThongTinPhong.SuspendLayout();
            grbLoaiPhong.SuspendLayout();
            tabPage2.SuspendLayout();
            tabSinhVien.SuspendLayout();
            groupBoxSinhVienViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            groupBoxSinhVien2.SuspendLayout();
            groupBoxSinhVien1.SuspendLayout();
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1222, 678);
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1214, 645);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Phòng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPThoat
            // 
            btnPThoat.Location = new Point(925, 534);
            btnPThoat.Name = "btnPThoat";
            btnPThoat.Size = new Size(124, 40);
            btnPThoat.TabIndex = 4;
            btnPThoat.Text = "Thoát";
            btnPThoat.UseVisualStyleBackColor = true;
            // 
            // btnPTimKiem
            // 
            btnPTimKiem.Location = new Point(564, 534);
            btnPTimKiem.Name = "btnPTimKiem";
            btnPTimKiem.Size = new Size(124, 40);
            btnPTimKiem.TabIndex = 4;
            btnPTimKiem.Text = "Tìm Kiếm";
            btnPTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnPXoa
            // 
            btnPXoa.Location = new Point(301, 590);
            btnPXoa.Name = "btnPXoa";
            btnPXoa.Size = new Size(102, 34);
            btnPXoa.TabIndex = 4;
            btnPXoa.Text = "Xoá";
            btnPXoa.UseVisualStyleBackColor = true;
            // 
            // btnPSua
            // 
            btnPSua.Location = new Point(169, 590);
            btnPSua.Name = "btnPSua";
            btnPSua.Size = new Size(102, 34);
            btnPSua.TabIndex = 4;
            btnPSua.Text = "Sửa";
            btnPSua.UseVisualStyleBackColor = true;
            // 
            // btnPThem
            // 
            btnPThem.Location = new Point(38, 590);
            btnPThem.Name = "btnPThem";
            btnPThem.Size = new Size(102, 34);
            btnPThem.TabIndex = 4;
            btnPThem.Text = "Thêm";
            btnPThem.UseVisualStyleBackColor = true;
            // 
            // grbDannhSachPhong
            // 
            grbDannhSachPhong.Controls.Add(dgvPDanhSachPhong);
            grbDannhSachPhong.Location = new Point(422, 50);
            grbDannhSachPhong.Name = "grbDannhSachPhong";
            grbDannhSachPhong.Size = new Size(784, 444);
            grbDannhSachPhong.TabIndex = 3;
            grbDannhSachPhong.TabStop = false;
            grbDannhSachPhong.Text = "Danh Sách Phòng";
            // 
            // dgvPDanhSachPhong
            // 
            dgvPDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPDanhSachPhong.Dock = DockStyle.Fill;
            dgvPDanhSachPhong.Location = new Point(3, 23);
            dgvPDanhSachPhong.Name = "dgvPDanhSachPhong";
            dgvPDanhSachPhong.RowHeadersWidth = 51;
            dgvPDanhSachPhong.RowTemplate.Height = 29;
            dgvPDanhSachPhong.Size = new Size(778, 418);
            dgvPDanhSachPhong.TabIndex = 0;
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
            grbThongTinPhong.Location = new Point(21, 50);
            grbThongTinPhong.Name = "grbThongTinPhong";
            grbThongTinPhong.Size = new Size(395, 518);
            grbThongTinPhong.TabIndex = 2;
            grbThongTinPhong.TabStop = false;
            grbThongTinPhong.Text = "Thông tin phòng";
            // 
            // cmbPSoNguoiToiDa
            // 
            cmbPSoNguoiToiDa.FormattingEnabled = true;
            cmbPSoNguoiToiDa.Location = new Point(173, 301);
            cmbPSoNguoiToiDa.Name = "cmbPSoNguoiToiDa";
            cmbPSoNguoiToiDa.Size = new Size(137, 28);
            cmbPSoNguoiToiDa.TabIndex = 3;
            // 
            // grbLoaiPhong
            // 
            grbLoaiPhong.Controls.Add(rdbPNu);
            grbLoaiPhong.Controls.Add(rdbPNam);
            grbLoaiPhong.Location = new Point(29, 183);
            grbLoaiPhong.Name = "grbLoaiPhong";
            grbLoaiPhong.Size = new Size(284, 92);
            grbLoaiPhong.TabIndex = 2;
            grbLoaiPhong.TabStop = false;
            grbLoaiPhong.Text = "Loại Phòng";
            // 
            // rdbPNu
            // 
            rdbPNu.AutoSize = true;
            rdbPNu.Location = new Point(179, 35);
            rdbPNu.Name = "rdbPNu";
            rdbPNu.Size = new Size(50, 24);
            rdbPNu.TabIndex = 3;
            rdbPNu.TabStop = true;
            rdbPNu.Text = "Nữ";
            rdbPNu.UseVisualStyleBackColor = true;
            // 
            // rdbPNam
            // 
            rdbPNam.AutoSize = true;
            rdbPNam.Location = new Point(38, 35);
            rdbPNam.Name = "rdbPNam";
            rdbPNam.Size = new Size(62, 24);
            rdbPNam.TabIndex = 2;
            rdbPNam.TabStop = true;
            rdbPNam.Text = "Nam";
            rdbPNam.UseVisualStyleBackColor = true;
            // 
            // txtPGhiChu
            // 
            txtPGhiChu.Location = new Point(128, 444);
            txtPGhiChu.Name = "txtPGhiChu";
            txtPGhiChu.Size = new Size(185, 27);
            txtPGhiChu.TabIndex = 1;
            // 
            // txtPTienThue
            // 
            txtPTienThue.Location = new Point(128, 399);
            txtPTienThue.Name = "txtPTienThue";
            txtPTienThue.Size = new Size(185, 27);
            txtPTienThue.TabIndex = 1;
            // 
            // txtPSoNguoiDangO
            // 
            txtPSoNguoiDangO.Location = new Point(173, 346);
            txtPSoNguoiDangO.Name = "txtPSoNguoiDangO";
            txtPSoNguoiDangO.Size = new Size(140, 27);
            txtPSoNguoiDangO.TabIndex = 1;
            // 
            // txtPMaNha
            // 
            txtPMaNha.Location = new Point(125, 128);
            txtPMaNha.Name = "txtPMaNha";
            txtPMaNha.Size = new Size(185, 27);
            txtPMaNha.TabIndex = 1;
            // 
            // txtPTenPhong
            // 
            txtPTenPhong.Location = new Point(125, 81);
            txtPTenPhong.Name = "txtPTenPhong";
            txtPTenPhong.Size = new Size(185, 27);
            txtPTenPhong.TabIndex = 1;
            // 
            // txtPMaPhong
            // 
            txtPMaPhong.Location = new Point(125, 38);
            txtPMaPhong.Name = "txtPMaPhong";
            txtPMaPhong.Size = new Size(185, 27);
            txtPMaPhong.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 304);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 0;
            label5.Text = "Số người ở tối đa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 447);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 0;
            label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 394);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Tiền Thuê";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 349);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 0;
            label6.Text = "Số người đang ở";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 131);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "Mã Nhà";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 84);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 38);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(547, 16);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Phòng";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1214, 645);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Thuê Phòng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabSinhVien
            // 
            tabSinhVien.Controls.Add(groupBoxSinhVienViewData);
            tabSinhVien.Controls.Add(groupBoxSinhVien2);
            tabSinhVien.Controls.Add(groupBoxSinhVien1);
            tabSinhVien.Location = new Point(4, 29);
            tabSinhVien.Margin = new Padding(3, 4, 3, 4);
            tabSinhVien.Name = "tabSinhVien";
            tabSinhVien.Padding = new Padding(3, 4, 3, 4);
            tabSinhVien.Size = new Size(1214, 645);
            tabSinhVien.TabIndex = 1;
            tabSinhVien.Text = "Sinh Viên";
            tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBoxSinhVienViewData
            // 
            groupBoxSinhVienViewData.Controls.Add(dataGridViewSinhVien);
            groupBoxSinhVienViewData.Location = new Point(462, 8);
            groupBoxSinhVienViewData.Margin = new Padding(3, 4, 3, 4);
            groupBoxSinhVienViewData.Name = "groupBoxSinhVienViewData";
            groupBoxSinhVienViewData.Padding = new Padding(3, 4, 3, 4);
            groupBoxSinhVienViewData.Size = new Size(437, 544);
            groupBoxSinhVienViewData.TabIndex = 2;
            groupBoxSinhVienViewData.TabStop = false;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Dock = DockStyle.Fill;
            dataGridViewSinhVien.Location = new Point(3, 24);
            dataGridViewSinhVien.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 51;
            dataGridViewSinhVien.RowTemplate.Height = 25;
            dataGridViewSinhVien.Size = new Size(431, 516);
            dataGridViewSinhVien.TabIndex = 0;
            // 
            // groupBoxSinhVien2
            // 
            groupBoxSinhVien2.Controls.Add(btnSVThem);
            groupBoxSinhVien2.Location = new Point(9, 405);
            groupBoxSinhVien2.Margin = new Padding(3, 4, 3, 4);
            groupBoxSinhVien2.Name = "groupBoxSinhVien2";
            groupBoxSinhVien2.Padding = new Padding(3, 4, 3, 4);
            groupBoxSinhVien2.Size = new Size(446, 147);
            groupBoxSinhVien2.TabIndex = 1;
            groupBoxSinhVien2.TabStop = false;
            // 
            // btnSVThem
            // 
            btnSVThem.Location = new Point(75, 29);
            btnSVThem.Margin = new Padding(3, 4, 3, 4);
            btnSVThem.Name = "btnSVThem";
            btnSVThem.Size = new Size(103, 40);
            btnSVThem.TabIndex = 0;
            btnSVThem.Text = "button1";
            btnSVThem.UseVisualStyleBackColor = true;
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
            groupBoxSinhVien1.Location = new Point(9, 8);
            groupBoxSinhVien1.Margin = new Padding(3, 4, 3, 4);
            groupBoxSinhVien1.Name = "groupBoxSinhVien1";
            groupBoxSinhVien1.Padding = new Padding(3, 4, 3, 4);
            groupBoxSinhVien1.Size = new Size(446, 389);
            groupBoxSinhVien1.TabIndex = 0;
            groupBoxSinhVien1.TabStop = false;
            // 
            // inputSVMaLop
            // 
            inputSVMaLop.FormattingEnabled = true;
            inputSVMaLop.Items.AddRange(new object[] { "Nam", "Nữ" });
            inputSVMaLop.Location = new Point(149, 292);
            inputSVMaLop.Margin = new Padding(3, 4, 3, 4);
            inputSVMaLop.Name = "inputSVMaLop";
            inputSVMaLop.Size = new Size(111, 28);
            inputSVMaLop.TabIndex = 3;
            // 
            // inputSVMaKhoa
            // 
            inputSVMaKhoa.FormattingEnabled = true;
            inputSVMaKhoa.Items.AddRange(new object[] { "Nam", "Nữ" });
            inputSVMaKhoa.Location = new Point(149, 249);
            inputSVMaKhoa.Margin = new Padding(3, 4, 3, 4);
            inputSVMaKhoa.Name = "inputSVMaKhoa";
            inputSVMaKhoa.Size = new Size(111, 28);
            inputSVMaKhoa.TabIndex = 3;
            inputSVMaKhoa.SelectedIndexChanged += inputSVMaKhoa_SelectedIndexChanged;
            // 
            // inputSVMaQue
            // 
            inputSVMaQue.FormattingEnabled = true;
            inputSVMaQue.Location = new Point(149, 204);
            inputSVMaQue.Margin = new Padding(3, 4, 3, 4);
            inputSVMaQue.Name = "inputSVMaQue";
            inputSVMaQue.Size = new Size(111, 28);
            inputSVMaQue.TabIndex = 3;
            // 
            // inputSVGioiTinh
            // 
            inputSVGioiTinh.FormattingEnabled = true;
            inputSVGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            inputSVGioiTinh.Location = new Point(149, 160);
            inputSVGioiTinh.Margin = new Padding(3, 4, 3, 4);
            inputSVGioiTinh.Name = "inputSVGioiTinh";
            inputSVGioiTinh.Size = new Size(111, 28);
            inputSVGioiTinh.TabIndex = 3;
            // 
            // labelSVMaLop
            // 
            labelSVMaLop.AutoSize = true;
            labelSVMaLop.Location = new Point(31, 296);
            labelSVMaLop.Name = "labelSVMaLop";
            labelSVMaLop.Size = new Size(34, 20);
            labelSVMaLop.TabIndex = 2;
            labelSVMaLop.Text = "Lớp";
            // 
            // labelSVMaKhoa
            // 
            labelSVMaKhoa.AutoSize = true;
            labelSVMaKhoa.Location = new Point(31, 253);
            labelSVMaKhoa.Name = "labelSVMaKhoa";
            labelSVMaKhoa.Size = new Size(43, 20);
            labelSVMaKhoa.TabIndex = 2;
            labelSVMaKhoa.Text = "Khoa";
            // 
            // labelSVMaQue
            // 
            labelSVMaQue.AutoSize = true;
            labelSVMaQue.Location = new Point(31, 208);
            labelSVMaQue.Name = "labelSVMaQue";
            labelSVMaQue.Size = new Size(36, 20);
            labelSVMaQue.TabIndex = 2;
            labelSVMaQue.Text = "Quê";
            // 
            // labelSVGioiTinh
            // 
            labelSVGioiTinh.AutoSize = true;
            labelSVGioiTinh.Location = new Point(31, 164);
            labelSVGioiTinh.Name = "labelSVGioiTinh";
            labelSVGioiTinh.Size = new Size(65, 20);
            labelSVGioiTinh.TabIndex = 2;
            labelSVGioiTinh.Text = "Giới tính";
            // 
            // labelSVNgaySinh
            // 
            labelSVNgaySinh.AutoSize = true;
            labelSVNgaySinh.Location = new Point(31, 120);
            labelSVNgaySinh.Name = "labelSVNgaySinh";
            labelSVNgaySinh.Size = new Size(74, 20);
            labelSVNgaySinh.TabIndex = 2;
            labelSVNgaySinh.Text = "Ngày sinh";
            // 
            // inputSVNgaySinh
            // 
            inputSVNgaySinh.Location = new Point(149, 115);
            inputSVNgaySinh.Margin = new Padding(3, 4, 3, 4);
            inputSVNgaySinh.Name = "inputSVNgaySinh";
            inputSVNgaySinh.Size = new Size(244, 27);
            inputSVNgaySinh.TabIndex = 1;
            // 
            // inputSVTenSinhVien
            // 
            inputSVTenSinhVien.Location = new Point(149, 76);
            inputSVTenSinhVien.Margin = new Padding(3, 4, 3, 4);
            inputSVTenSinhVien.Name = "inputSVTenSinhVien";
            inputSVTenSinhVien.Size = new Size(244, 27);
            inputSVTenSinhVien.TabIndex = 1;
            // 
            // labelSVTenSV
            // 
            labelSVTenSV.AutoSize = true;
            labelSVTenSV.Location = new Point(31, 80);
            labelSVTenSV.Name = "labelSVTenSV";
            labelSVTenSV.Size = new Size(93, 20);
            labelSVTenSV.TabIndex = 0;
            labelSVTenSV.Text = "Tên sinh viên";
            // 
            // inputSVMaSinhVien
            // 
            inputSVMaSinhVien.Location = new Point(149, 37);
            inputSVMaSinhVien.Margin = new Padding(3, 4, 3, 4);
            inputSVMaSinhVien.Name = "inputSVMaSinhVien";
            inputSVMaSinhVien.Size = new Size(244, 27);
            inputSVMaSinhVien.TabIndex = 1;
            // 
            // labelSVMaSV
            // 
            labelSVMaSV.AutoSize = true;
            labelSVMaSV.Location = new Point(31, 41);
            labelSVMaSV.Name = "labelSVMaSV";
            labelSVMaSV.Size = new Size(91, 20);
            labelSVMaSV.TabIndex = 0;
            labelSVMaSV.Text = "Mã sinh viên";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1214, 645);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(41, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1134, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(628, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 353);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Phòng còn trống";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(41, 180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(572, 353);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách Sinh Viên muốn thuê";
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 678);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
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
            tabSinhVien.ResumeLayout(false);
            groupBoxSinhVienViewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            groupBoxSinhVien2.ResumeLayout(false);
            groupBoxSinhVien1.ResumeLayout(false);
            groupBoxSinhVien1.PerformLayout();
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
    }
}