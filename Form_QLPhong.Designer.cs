namespace LTTQ_Proj
{
    partial class Form_QLPhong
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnPXoa = new Button();
            btnPSua = new Button();
            btnPThem = new Button();
            grbPLoaiPhong = new GroupBox();
            rdbPVip = new RadioButton();
            rdbPThuong = new RadioButton();
            rdbPCoBan = new RadioButton();
            cmbPSoNguoiToiDa = new ComboBox();
            txtPGhiChu = new TextBox();
            txtPSoNguoiDangO = new TextBox();
            txtPTienThue = new TextBox();
            txtPMaNha = new TextBox();
            txtPTenPhong = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPMaPhong = new TextBox();
            label2 = new Label();
            grbPDanhSachPhong = new GroupBox();
            dgvPDanhSachPhong = new DataGridView();
            btnPTimKiem = new Button();
            panelPButton = new Panel();
            btnPThoat = new Button();
            errorP = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            grbPLoaiPhong.SuspendLayout();
            grbPDanhSachPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPDanhSachPhong).BeginInit();
            panelPButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(435, 7);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phòng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPXoa);
            groupBox1.Controls.Add(btnPSua);
            groupBox1.Controls.Add(btnPThem);
            groupBox1.Controls.Add(grbPLoaiPhong);
            groupBox1.Controls.Add(cmbPSoNguoiToiDa);
            groupBox1.Controls.Add(txtPGhiChu);
            groupBox1.Controls.Add(txtPSoNguoiDangO);
            groupBox1.Controls.Add(txtPTienThue);
            groupBox1.Controls.Add(txtPMaNha);
            groupBox1.Controls.Add(txtPTenPhong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPMaPhong);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 40);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(366, 374);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // btnPXoa
            // 
            btnPXoa.Location = new Point(236, 331);
            btnPXoa.Margin = new Padding(3, 2, 3, 2);
            btnPXoa.Name = "btnPXoa";
            btnPXoa.Size = new Size(82, 22);
            btnPXoa.TabIndex = 3;
            btnPXoa.Text = "Xoá";
            btnPXoa.UseVisualStyleBackColor = true;
            // 
            // btnPSua
            // 
            btnPSua.Location = new Point(124, 331);
            btnPSua.Margin = new Padding(3, 2, 3, 2);
            btnPSua.Name = "btnPSua";
            btnPSua.Size = new Size(82, 22);
            btnPSua.TabIndex = 3;
            btnPSua.Text = "Sửa";
            btnPSua.UseVisualStyleBackColor = true;
            btnPSua.Click += btnPSua_Click;
            // 
            // btnPThem
            // 
            btnPThem.Location = new Point(11, 331);
            btnPThem.Margin = new Padding(3, 2, 3, 2);
            btnPThem.Name = "btnPThem";
            btnPThem.Size = new Size(82, 22);
            btnPThem.TabIndex = 3;
            btnPThem.Text = "Thêm";
            btnPThem.UseVisualStyleBackColor = true;
            btnPThem.Click += btnPThem_Click;
            // 
            // grbPLoaiPhong
            // 
            grbPLoaiPhong.Controls.Add(rdbPVip);
            grbPLoaiPhong.Controls.Add(rdbPThuong);
            grbPLoaiPhong.Controls.Add(rdbPCoBan);
            grbPLoaiPhong.Location = new Point(11, 121);
            grbPLoaiPhong.Margin = new Padding(3, 2, 3, 2);
            grbPLoaiPhong.Name = "grbPLoaiPhong";
            grbPLoaiPhong.Padding = new Padding(3, 2, 3, 2);
            grbPLoaiPhong.Size = new Size(343, 62);
            grbPLoaiPhong.TabIndex = 3;
            grbPLoaiPhong.TabStop = false;
            grbPLoaiPhong.Text = "Loại phòng";
            // 
            // rdbPVip
            // 
            rdbPVip.AutoSize = true;
            rdbPVip.Location = new Point(236, 27);
            rdbPVip.Margin = new Padding(3, 2, 3, 2);
            rdbPVip.Name = "rdbPVip";
            rdbPVip.Size = new Size(42, 19);
            rdbPVip.TabIndex = 0;
            rdbPVip.TabStop = true;
            rdbPVip.Text = "Vip";
            rdbPVip.UseVisualStyleBackColor = true;
            // 
            // rdbPThuong
            // 
            rdbPThuong.AutoSize = true;
            rdbPThuong.Location = new Point(113, 27);
            rdbPThuong.Margin = new Padding(3, 2, 3, 2);
            rdbPThuong.Name = "rdbPThuong";
            rdbPThuong.Size = new Size(66, 19);
            rdbPThuong.TabIndex = 0;
            rdbPThuong.TabStop = true;
            rdbPThuong.Text = "Thường";
            rdbPThuong.UseVisualStyleBackColor = true;
            // 
            // rdbPCoBan
            // 
            rdbPCoBan.AutoSize = true;
            rdbPCoBan.Location = new Point(5, 27);
            rdbPCoBan.Margin = new Padding(3, 2, 3, 2);
            rdbPCoBan.Name = "rdbPCoBan";
            rdbPCoBan.Size = new Size(66, 19);
            rdbPCoBan.TabIndex = 0;
            rdbPCoBan.TabStop = true;
            rdbPCoBan.Text = "Cơ  bản";
            rdbPCoBan.UseVisualStyleBackColor = true;
            // 
            // cmbPSoNguoiToiDa
            // 
            cmbPSoNguoiToiDa.FormattingEnabled = true;
            cmbPSoNguoiToiDa.Location = new Point(131, 190);
            cmbPSoNguoiToiDa.Margin = new Padding(3, 2, 3, 2);
            cmbPSoNguoiToiDa.Name = "cmbPSoNguoiToiDa";
            cmbPSoNguoiToiDa.Size = new Size(133, 23);
            cmbPSoNguoiToiDa.TabIndex = 2;
            cmbPSoNguoiToiDa.SelectedIndexChanged += cmbPSoNguoiToiDa_SelectedIndexChanged;
            // 
            // txtPGhiChu
            // 
            txtPGhiChu.Location = new Point(108, 291);
            txtPGhiChu.Margin = new Padding(3, 2, 3, 2);
            txtPGhiChu.Name = "txtPGhiChu";
            txtPGhiChu.Size = new Size(192, 23);
            txtPGhiChu.TabIndex = 1;
            // 
            // txtPSoNguoiDangO
            // 
            txtPSoNguoiDangO.Location = new Point(131, 223);
            txtPSoNguoiDangO.Margin = new Padding(3, 2, 3, 2);
            txtPSoNguoiDangO.Name = "txtPSoNguoiDangO";
            txtPSoNguoiDangO.Size = new Size(133, 23);
            txtPSoNguoiDangO.TabIndex = 1;
            // 
            // txtPTienThue
            // 
            txtPTienThue.Location = new Point(108, 256);
            txtPTienThue.Margin = new Padding(3, 2, 3, 2);
            txtPTienThue.Name = "txtPTienThue";
            txtPTienThue.Size = new Size(192, 23);
            txtPTienThue.TabIndex = 1;
            // 
            // txtPMaNha
            // 
            txtPMaNha.Location = new Point(108, 96);
            txtPMaNha.Margin = new Padding(3, 2, 3, 2);
            txtPMaNha.Name = "txtPMaNha";
            txtPMaNha.Size = new Size(192, 23);
            txtPMaNha.TabIndex = 1;
            // 
            // txtPTenPhong
            // 
            txtPTenPhong.Location = new Point(108, 56);
            txtPTenPhong.Margin = new Padding(3, 2, 3, 2);
            txtPTenPhong.Name = "txtPTenPhong";
            txtPTenPhong.Size = new Size(192, 23);
            txtPTenPhong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 291);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 0;
            label8.Text = "Ghi chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 228);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 0;
            label5.Text = "Số người đang ở";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 258);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 0;
            label7.Text = "Tiền thuê";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 196);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 0;
            label6.Text = "Số người ở tối đa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 88);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 0;
            label4.Text = "Mã nhà";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 56);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Tên Phòng";
            // 
            // txtPMaPhong
            // 
            txtPMaPhong.Location = new Point(108, 19);
            txtPMaPhong.Margin = new Padding(3, 2, 3, 2);
            txtPMaPhong.Name = "txtPMaPhong";
            txtPMaPhong.Size = new Size(192, 23);
            txtPMaPhong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Phòng";
            // 
            // grbPDanhSachPhong
            // 
            grbPDanhSachPhong.Controls.Add(dgvPDanhSachPhong);
            grbPDanhSachPhong.Location = new Point(382, 40);
            grbPDanhSachPhong.Margin = new Padding(3, 2, 3, 2);
            grbPDanhSachPhong.Name = "grbPDanhSachPhong";
            grbPDanhSachPhong.Padding = new Padding(3, 2, 3, 2);
            grbPDanhSachPhong.Size = new Size(623, 278);
            grbPDanhSachPhong.TabIndex = 2;
            grbPDanhSachPhong.TabStop = false;
            grbPDanhSachPhong.Text = "Danh Sách Phòng";
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
            dgvPDanhSachPhong.Size = new Size(617, 258);
            dgvPDanhSachPhong.TabIndex = 0;
            dgvPDanhSachPhong.CellContentClick += dgvPDanhSachPhong_CellContentClick;
            // 
            // btnPTimKiem
            // 
            btnPTimKiem.Location = new Point(102, 30);
            btnPTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnPTimKiem.Name = "btnPTimKiem";
            btnPTimKiem.Size = new Size(101, 32);
            btnPTimKiem.TabIndex = 3;
            btnPTimKiem.Text = "Tìm Kiếm";
            btnPTimKiem.UseVisualStyleBackColor = true;
            btnPTimKiem.Click += btnPTimKiem_Click;
            // 
            // panelPButton
            // 
            panelPButton.Controls.Add(btnPThoat);
            panelPButton.Controls.Add(btnPTimKiem);
            panelPButton.Location = new Point(384, 322);
            panelPButton.Margin = new Padding(3, 2, 3, 2);
            panelPButton.Name = "panelPButton";
            panelPButton.Size = new Size(620, 82);
            panelPButton.TabIndex = 4;
            // 
            // btnPThoat
            // 
            btnPThoat.Location = new Point(350, 30);
            btnPThoat.Margin = new Padding(3, 2, 3, 2);
            btnPThoat.Name = "btnPThoat";
            btnPThoat.Size = new Size(101, 32);
            btnPThoat.TabIndex = 4;
            btnPThoat.Text = "Thoát";
            btnPThoat.UseVisualStyleBackColor = true;
            btnPThoat.Click += button5_Click;
            // 
            // errorP
            // 
            errorP.ContainerControl = this;
            // 
            // Form_QLPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 422);
            Controls.Add(panelPButton);
            Controls.Add(grbPDanhSachPhong);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_QLPhong";
            Text = "Form_QLPhong";
            Load += Form_QLPhong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbPLoaiPhong.ResumeLayout(false);
            grbPLoaiPhong.PerformLayout();
            grbPDanhSachPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPDanhSachPhong).EndInit();
            panelPButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox grbPDanhSachPhong;
        private DataGridView dgvPDanhSachPhong;
        private TextBox txtPMaPhong;
        private Label label2;
        private Button btnPTimKiem;
        private Panel panelPButton;
        private TextBox txtPGhiChu;
        private TextBox txtPTienThue;
        private TextBox txtPMaNha;
        private TextBox txtPTenPhong;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private GroupBox grbPLoaiPhong;
        private RadioButton rdbPVip;
        private RadioButton rdbPThuong;
        private RadioButton rdbPCoBan;
        private ComboBox cmbPSoNguoiToiDa;
        private Button btnPSua;
        private Button btnPThem;
        private Button btnPXoa;
        private Button btnPThoat;
        private TextBox txtPSoNguoiDangO;
        private Label label5;
        private ErrorProvider errorP;
    }
}