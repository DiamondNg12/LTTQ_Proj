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
            btnSVXoa = new Button();
            btnSVSua = new Button();
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
            errorPhong = new ErrorProvider(components);
            errorSV = new ErrorProvider(components);
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
            ((System.ComponentModel.ISupportInitialize)errorSV).BeginInit();
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
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1574, 847);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1566, 809);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Phòng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPThoat
            // 
            btnPThoat.Location = new Point(1156, 667);
            btnPThoat.Margin = new Padding(4, 3, 4, 3);
            btnPThoat.Name = "btnPThoat";
            btnPThoat.Size = new Size(154, 50);
            btnPThoat.TabIndex = 4;
            btnPThoat.Text = "Thoát";
            btnPThoat.UseVisualStyleBackColor = true;
            btnPThoat.Click += btnPThoat_Click;
            // 
            // btnPTimKiem
            // 
            btnPTimKiem.Location = new Point(706, 667);
            btnPTimKiem.Margin = new Padding(4, 3, 4, 3);
            btnPTimKiem.Name = "btnPTimKiem";
            btnPTimKiem.Size = new Size(154, 50);
            btnPTimKiem.TabIndex = 4;
            btnPTimKiem.Text = "Tìm Kiếm";
            btnPTimKiem.UseVisualStyleBackColor = true;
            btnPTimKiem.Click += btnPTimKiem_Click;
            // 
            // btnPXoa
            // 
            btnPXoa.Location = new Point(376, 737);
            btnPXoa.Margin = new Padding(4, 3, 4, 3);
            btnPXoa.Name = "btnPXoa";
            btnPXoa.Size = new Size(127, 43);
            btnPXoa.TabIndex = 4;
            btnPXoa.Text = "Xoá";
            btnPXoa.UseVisualStyleBackColor = true;
            btnPXoa.Click += btnPXoa_Click;
            // 
            // btnPSua
            // 
            btnPSua.Location = new Point(211, 737);
            btnPSua.Margin = new Padding(4, 3, 4, 3);
            btnPSua.Name = "btnPSua";
            btnPSua.Size = new Size(127, 43);
            btnPSua.TabIndex = 4;
            btnPSua.Text = "Sửa";
            btnPSua.UseVisualStyleBackColor = true;
            btnPSua.Click += btnPSua_Click;
            // 
            // btnPThem
            // 
            btnPThem.Location = new Point(47, 737);
            btnPThem.Margin = new Padding(4, 3, 4, 3);
            btnPThem.Name = "btnPThem";
            btnPThem.Size = new Size(127, 43);
            btnPThem.TabIndex = 4;
            btnPThem.Text = "Thêm";
            btnPThem.UseVisualStyleBackColor = true;
            btnPThem.Click += btnPThem_Click;
            // 
            // grbDannhSachPhong
            // 
            grbDannhSachPhong.Controls.Add(dgvPDanhSachPhong);
            grbDannhSachPhong.Location = new Point(527, 63);
            grbDannhSachPhong.Margin = new Padding(4, 3, 4, 3);
            grbDannhSachPhong.Name = "grbDannhSachPhong";
            grbDannhSachPhong.Padding = new Padding(4, 3, 4, 3);
            grbDannhSachPhong.Size = new Size(1016, 555);
            grbDannhSachPhong.TabIndex = 3;
            grbDannhSachPhong.TabStop = false;
            grbDannhSachPhong.Text = "Danh Sách Phòng";
            // 
            // dgvPDanhSachPhong
            // 
            dgvPDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPDanhSachPhong.Dock = DockStyle.Fill;
            dgvPDanhSachPhong.Location = new Point(4, 27);
            dgvPDanhSachPhong.Margin = new Padding(4, 3, 4, 3);
            dgvPDanhSachPhong.Name = "dgvPDanhSachPhong";
            dgvPDanhSachPhong.RowHeadersWidth = 51;
            dgvPDanhSachPhong.RowTemplate.Height = 29;
            dgvPDanhSachPhong.Size = new Size(1008, 525);
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
            grbThongTinPhong.Location = new Point(26, 63);
            grbThongTinPhong.Margin = new Padding(4, 3, 4, 3);
            grbThongTinPhong.Name = "grbThongTinPhong";
            grbThongTinPhong.Padding = new Padding(4, 3, 4, 3);
            grbThongTinPhong.Size = new Size(494, 647);
            grbThongTinPhong.TabIndex = 2;
            grbThongTinPhong.TabStop = false;
            grbThongTinPhong.Text = "Thông tin phòng";
            // 
            // cmbPSoNguoiToiDa
            // 
            cmbPSoNguoiToiDa.FormattingEnabled = true;
            cmbPSoNguoiToiDa.Location = new Point(216, 377);
            cmbPSoNguoiToiDa.Margin = new Padding(4, 3, 4, 3);
            cmbPSoNguoiToiDa.Name = "cmbPSoNguoiToiDa";
            cmbPSoNguoiToiDa.Size = new Size(170, 33);
            cmbPSoNguoiToiDa.TabIndex = 3;
            // 
            // grbLoaiPhong
            // 
            grbLoaiPhong.Controls.Add(rdbPNu);
            grbLoaiPhong.Controls.Add(rdbPNam);
            grbLoaiPhong.Location = new Point(36, 228);
            grbLoaiPhong.Margin = new Padding(4, 3, 4, 3);
            grbLoaiPhong.Name = "grbLoaiPhong";
            grbLoaiPhong.Padding = new Padding(4, 3, 4, 3);
            grbLoaiPhong.Size = new Size(354, 115);
            grbLoaiPhong.TabIndex = 2;
            grbLoaiPhong.TabStop = false;
            grbLoaiPhong.Text = "Loại Phòng";
            // 
            // rdbPNu
            // 
            rdbPNu.AutoSize = true;
            rdbPNu.Location = new Point(224, 43);
            rdbPNu.Margin = new Padding(4, 3, 4, 3);
            rdbPNu.Name = "rdbPNu";
            rdbPNu.Size = new Size(61, 29);
            rdbPNu.TabIndex = 3;
            rdbPNu.TabStop = true;
            rdbPNu.Text = "Nữ";
            rdbPNu.UseVisualStyleBackColor = true;
            // 
            // rdbPNam
            // 
            rdbPNam.AutoSize = true;
            rdbPNam.Location = new Point(47, 43);
            rdbPNam.Margin = new Padding(4, 3, 4, 3);
            rdbPNam.Name = "rdbPNam";
            rdbPNam.Size = new Size(75, 29);
            rdbPNam.TabIndex = 2;
            rdbPNam.TabStop = true;
            rdbPNam.Text = "Nam";
            rdbPNam.UseVisualStyleBackColor = true;
            // 
            // txtPGhiChu
            // 
            txtPGhiChu.Location = new Point(160, 555);
            txtPGhiChu.Margin = new Padding(4, 3, 4, 3);
            txtPGhiChu.Name = "txtPGhiChu";
            txtPGhiChu.Size = new Size(230, 31);
            txtPGhiChu.TabIndex = 1;
            // 
            // txtPTienThue
            // 
            txtPTienThue.Location = new Point(160, 498);
            txtPTienThue.Margin = new Padding(4, 3, 4, 3);
            txtPTienThue.Name = "txtPTienThue";
            txtPTienThue.Size = new Size(230, 31);
            txtPTienThue.TabIndex = 1;
            // 
            // txtPSoNguoiDangO
            // 
            txtPSoNguoiDangO.Location = new Point(216, 433);
            txtPSoNguoiDangO.Margin = new Padding(4, 3, 4, 3);
            txtPSoNguoiDangO.Name = "txtPSoNguoiDangO";
            txtPSoNguoiDangO.Size = new Size(174, 31);
            txtPSoNguoiDangO.TabIndex = 1;
            // 
            // txtPMaNha
            // 
            txtPMaNha.Location = new Point(156, 160);
            txtPMaNha.Margin = new Padding(4, 3, 4, 3);
            txtPMaNha.Name = "txtPMaNha";
            txtPMaNha.Size = new Size(230, 31);
            txtPMaNha.TabIndex = 1;
            // 
            // txtPTenPhong
            // 
            txtPTenPhong.Location = new Point(156, 102);
            txtPTenPhong.Margin = new Padding(4, 3, 4, 3);
            txtPTenPhong.Name = "txtPTenPhong";
            txtPTenPhong.Size = new Size(230, 31);
            txtPTenPhong.TabIndex = 1;
            // 
            // txtPMaPhong
            // 
            txtPMaPhong.Location = new Point(156, 47);
            txtPMaPhong.Margin = new Padding(4, 3, 4, 3);
            txtPMaPhong.Name = "txtPMaPhong";
            txtPMaPhong.Size = new Size(230, 31);
            txtPMaPhong.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 0;
            label5.Text = "Số người ở tối đa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 558);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 0;
            label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 493);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 0;
            label7.Text = "Tiền Thuê";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 437);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 0;
            label6.Text = "Số người đang ở";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 163);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 0;
            label4.Text = "Mã Nhà";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 0;
            label3.Text = "Tên Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(684, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
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
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1566, 809);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Thuê Phòng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(753, 25);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(363, 38);
            label9.TabIndex = 4;
            label9.Text = "Thuê Phòng cho Sinh Viên";
            // 
            // btnTThoat
            // 
            btnTThoat.Location = new Point(1313, 952);
            btnTThoat.Margin = new Padding(4, 5, 4, 5);
            btnTThoat.Name = "btnTThoat";
            btnTThoat.Size = new Size(173, 70);
            btnTThoat.TabIndex = 3;
            btnTThoat.Text = "Thoát";
            btnTThoat.UseVisualStyleBackColor = true;
            // 
            // btnTThem
            // 
            btnTThem.Location = new Point(800, 952);
            btnTThem.Margin = new Padding(4, 5, 4, 5);
            btnTThem.Name = "btnTThem";
            btnTThem.Size = new Size(173, 70);
            btnTThem.TabIndex = 3;
            btnTThem.Text = "Thêm";
            btnTThem.UseVisualStyleBackColor = true;
            // 
            // btnThueTimKiem
            // 
            btnThueTimKiem.Location = new Point(189, 952);
            btnThueTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnThueTimKiem.Name = "btnThueTimKiem";
            btnThueTimKiem.Size = new Size(173, 70);
            btnThueTimKiem.TabIndex = 3;
            btnThueTimKiem.Text = "Tìm Kiếm";
            btnThueTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDSPhongConTrong);
            groupBox2.Location = new Point(897, 300);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(880, 588);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Phòng còn trống";
            // 
            // dgvDSPhongConTrong
            // 
            dgvDSPhongConTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhongConTrong.Dock = DockStyle.Fill;
            dgvDSPhongConTrong.Location = new Point(4, 29);
            dgvDSPhongConTrong.Margin = new Padding(4, 5, 4, 5);
            dgvDSPhongConTrong.Name = "dgvDSPhongConTrong";
            dgvDSPhongConTrong.RowHeadersWidth = 51;
            dgvDSPhongConTrong.RowTemplate.Height = 29;
            dgvDSPhongConTrong.Size = new Size(872, 554);
            dgvDSPhongConTrong.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dvgDSSVThuePhong);
            groupBox3.Location = new Point(9, 300);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(867, 588);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách Sinh Viên muốn thuê";
            // 
            // dvgDSSVThuePhong
            // 
            dvgDSSVThuePhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDSSVThuePhong.Dock = DockStyle.Fill;
            dvgDSSVThuePhong.Location = new Point(4, 29);
            dvgDSSVThuePhong.Margin = new Padding(4, 5, 4, 5);
            dvgDSSVThuePhong.Name = "dvgDSSVThuePhong";
            dvgDSSVThuePhong.RowHeadersWidth = 51;
            dvgDSSVThuePhong.RowTemplate.Height = 29;
            dvgDSSVThuePhong.Size = new Size(859, 554);
            dvgDSSVThuePhong.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 82);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1760, 208);
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
            tabSinhVien.Location = new Point(4, 34);
            tabSinhVien.Margin = new Padding(4, 5, 4, 5);
            tabSinhVien.Name = "tabSinhVien";
            tabSinhVien.Padding = new Padding(4, 7, 4, 7);
            tabSinhVien.Size = new Size(1566, 809);
            tabSinhVien.TabIndex = 1;
            tabSinhVien.Text = "Sinh Viên";
            tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // labelQLSinhVien
            // 
            labelQLSinhVien.AutoSize = true;
            labelQLSinhVien.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQLSinhVien.Location = new Point(639, 40);
            labelQLSinhVien.Margin = new Padding(4, 0, 4, 0);
            labelQLSinhVien.Name = "labelQLSinhVien";
            labelQLSinhVien.Size = new Size(342, 55);
            labelQLSinhVien.TabIndex = 3;
            labelQLSinhVien.Text = "Quản lý Sinh Viên";
            // 
            // groupBoxSinhVienViewData
            // 
            groupBoxSinhVienViewData.Controls.Add(dataGridViewSinhVien);
            groupBoxSinhVienViewData.Location = new Point(580, 107);
            groupBoxSinhVienViewData.Margin = new Padding(4, 5, 4, 5);
            groupBoxSinhVienViewData.Name = "groupBoxSinhVienViewData";
            groupBoxSinhVienViewData.Padding = new Padding(4, 5, 4, 5);
            groupBoxSinhVienViewData.Size = new Size(974, 680);
            groupBoxSinhVienViewData.TabIndex = 2;
            groupBoxSinhVienViewData.TabStop = false;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Dock = DockStyle.Fill;
            dataGridViewSinhVien.Location = new Point(4, 29);
            dataGridViewSinhVien.Margin = new Padding(4, 5, 4, 5);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 51;
            dataGridViewSinhVien.RowTemplate.Height = 25;
            dataGridViewSinhVien.Size = new Size(966, 646);
            dataGridViewSinhVien.TabIndex = 0;
            dataGridViewSinhVien.SelectionChanged += dataGridViewSinhVien_SelectionChanged;
            // 
            // groupBoxSinhVien2
            // 
            groupBoxSinhVien2.Controls.Add(btnSVXoa);
            groupBoxSinhVien2.Controls.Add(btnSVSua);
            groupBoxSinhVien2.Controls.Add(btnSVThem);
            groupBoxSinhVien2.Location = new Point(14, 603);
            groupBoxSinhVien2.Margin = new Padding(4, 5, 4, 5);
            groupBoxSinhVien2.Name = "groupBoxSinhVien2";
            groupBoxSinhVien2.Padding = new Padding(4, 5, 4, 5);
            groupBoxSinhVien2.Size = new Size(557, 183);
            groupBoxSinhVien2.TabIndex = 1;
            groupBoxSinhVien2.TabStop = false;
            // 
            // btnSVXoa
            // 
            btnSVXoa.Location = new Point(386, 77);
            btnSVXoa.Margin = new Padding(4, 5, 4, 5);
            btnSVXoa.Name = "btnSVXoa";
            btnSVXoa.Size = new Size(129, 50);
            btnSVXoa.TabIndex = 0;
            btnSVXoa.Text = "Xoá";
            btnSVXoa.UseVisualStyleBackColor = true;
            btnSVXoa.Click += btnSVXoa_Click;
            // 
            // btnSVSua
            // 
            btnSVSua.Location = new Point(219, 77);
            btnSVSua.Margin = new Padding(4, 5, 4, 5);
            btnSVSua.Name = "btnSVSua";
            btnSVSua.Size = new Size(129, 50);
            btnSVSua.TabIndex = 0;
            btnSVSua.Text = "Sửa";
            btnSVSua.UseVisualStyleBackColor = true;
            btnSVSua.Click += btnSVSua_Click;
            // 
            // btnSVThem
            // 
            btnSVThem.Location = new Point(39, 77);
            btnSVThem.Margin = new Padding(4, 5, 4, 5);
            btnSVThem.Name = "btnSVThem";
            btnSVThem.Size = new Size(129, 50);
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
            groupBoxSinhVien1.Location = new Point(14, 107);
            groupBoxSinhVien1.Margin = new Padding(4, 5, 4, 5);
            groupBoxSinhVien1.Name = "groupBoxSinhVien1";
            groupBoxSinhVien1.Padding = new Padding(4, 5, 4, 5);
            groupBoxSinhVien1.Size = new Size(557, 487);
            groupBoxSinhVien1.TabIndex = 0;
            groupBoxSinhVien1.TabStop = false;
            // 
            // inputSVMaLop
            // 
            inputSVMaLop.FormattingEnabled = true;
            inputSVMaLop.Location = new Point(186, 365);
            inputSVMaLop.Margin = new Padding(4, 5, 4, 5);
            inputSVMaLop.Name = "inputSVMaLop";
            inputSVMaLop.Size = new Size(138, 33);
            inputSVMaLop.TabIndex = 3;
            // 
            // inputSVMaKhoa
            // 
            inputSVMaKhoa.FormattingEnabled = true;
            inputSVMaKhoa.Location = new Point(186, 312);
            inputSVMaKhoa.Margin = new Padding(4, 5, 4, 5);
            inputSVMaKhoa.Name = "inputSVMaKhoa";
            inputSVMaKhoa.Size = new Size(138, 33);
            inputSVMaKhoa.TabIndex = 3;
            inputSVMaKhoa.SelectedIndexChanged += inputSVMaKhoa_SelectedIndexChanged;
            // 
            // inputSVMaQue
            // 
            inputSVMaQue.FormattingEnabled = true;
            inputSVMaQue.Location = new Point(186, 255);
            inputSVMaQue.Margin = new Padding(4, 5, 4, 5);
            inputSVMaQue.Name = "inputSVMaQue";
            inputSVMaQue.Size = new Size(138, 33);
            inputSVMaQue.TabIndex = 3;
            // 
            // inputSVGioiTinh
            // 
            inputSVGioiTinh.FormattingEnabled = true;
            inputSVGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            inputSVGioiTinh.Location = new Point(186, 200);
            inputSVGioiTinh.Margin = new Padding(4, 5, 4, 5);
            inputSVGioiTinh.Name = "inputSVGioiTinh";
            inputSVGioiTinh.Size = new Size(138, 33);
            inputSVGioiTinh.TabIndex = 3;
            // 
            // labelSVMaLop
            // 
            labelSVMaLop.AutoSize = true;
            labelSVMaLop.Location = new Point(39, 370);
            labelSVMaLop.Margin = new Padding(4, 0, 4, 0);
            labelSVMaLop.Name = "labelSVMaLop";
            labelSVMaLop.Size = new Size(42, 25);
            labelSVMaLop.TabIndex = 2;
            labelSVMaLop.Text = "Lớp";
            // 
            // labelSVMaKhoa
            // 
            labelSVMaKhoa.AutoSize = true;
            labelSVMaKhoa.Location = new Point(39, 317);
            labelSVMaKhoa.Margin = new Padding(4, 0, 4, 0);
            labelSVMaKhoa.Name = "labelSVMaKhoa";
            labelSVMaKhoa.Size = new Size(52, 25);
            labelSVMaKhoa.TabIndex = 2;
            labelSVMaKhoa.Text = "Khoa";
            // 
            // labelSVMaQue
            // 
            labelSVMaQue.AutoSize = true;
            labelSVMaQue.Location = new Point(39, 260);
            labelSVMaQue.Margin = new Padding(4, 0, 4, 0);
            labelSVMaQue.Name = "labelSVMaQue";
            labelSVMaQue.Size = new Size(45, 25);
            labelSVMaQue.TabIndex = 2;
            labelSVMaQue.Text = "Quê";
            // 
            // labelSVGioiTinh
            // 
            labelSVGioiTinh.AutoSize = true;
            labelSVGioiTinh.Location = new Point(39, 205);
            labelSVGioiTinh.Margin = new Padding(4, 0, 4, 0);
            labelSVGioiTinh.Name = "labelSVGioiTinh";
            labelSVGioiTinh.Size = new Size(78, 25);
            labelSVGioiTinh.TabIndex = 2;
            labelSVGioiTinh.Text = "Giới tính";
            // 
            // labelSVNgaySinh
            // 
            labelSVNgaySinh.AutoSize = true;
            labelSVNgaySinh.Location = new Point(39, 150);
            labelSVNgaySinh.Margin = new Padding(4, 0, 4, 0);
            labelSVNgaySinh.Name = "labelSVNgaySinh";
            labelSVNgaySinh.Size = new Size(91, 25);
            labelSVNgaySinh.TabIndex = 2;
            labelSVNgaySinh.Text = "Ngày sinh";
            // 
            // inputSVNgaySinh
            // 
            inputSVNgaySinh.Location = new Point(186, 143);
            inputSVNgaySinh.Margin = new Padding(4, 5, 4, 5);
            inputSVNgaySinh.Name = "inputSVNgaySinh";
            inputSVNgaySinh.Size = new Size(304, 31);
            inputSVNgaySinh.TabIndex = 1;
            // 
            // inputSVTenSinhVien
            // 
            inputSVTenSinhVien.Location = new Point(186, 95);
            inputSVTenSinhVien.Margin = new Padding(4, 5, 4, 5);
            inputSVTenSinhVien.Name = "inputSVTenSinhVien";
            inputSVTenSinhVien.Size = new Size(304, 31);
            inputSVTenSinhVien.TabIndex = 1;
            // 
            // labelSVTenSV
            // 
            labelSVTenSV.AutoSize = true;
            labelSVTenSV.Location = new Point(39, 100);
            labelSVTenSV.Margin = new Padding(4, 0, 4, 0);
            labelSVTenSV.Name = "labelSVTenSV";
            labelSVTenSV.Size = new Size(112, 25);
            labelSVTenSV.TabIndex = 0;
            labelSVTenSV.Text = "Tên sinh viên";
            // 
            // inputSVMaSinhVien
            // 
            inputSVMaSinhVien.Location = new Point(186, 47);
            inputSVMaSinhVien.Margin = new Padding(4, 5, 4, 5);
            inputSVMaSinhVien.Name = "inputSVMaSinhVien";
            inputSVMaSinhVien.Size = new Size(304, 31);
            inputSVMaSinhVien.TabIndex = 1;
            // 
            // labelSVMaSV
            // 
            labelSVMaSV.AutoSize = true;
            labelSVMaSV.Location = new Point(39, 52);
            labelSVMaSV.Margin = new Padding(4, 0, 4, 0);
            labelSVMaSV.Name = "labelSVMaSV";
            labelSVMaSV.Size = new Size(111, 25);
            labelSVMaSV.TabIndex = 0;
            labelSVMaSV.Text = "Mã sinh viên";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 7, 4, 7);
            tabPage3.Size = new Size(1566, 809);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorPhong
            // 
            errorPhong.ContainerControl = this;
            // 
            // errorSV
            // 
            errorSV.ContainerControl = this;
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 847);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)errorSV).EndInit();
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
        private ErrorProvider errorSV;
    }
}