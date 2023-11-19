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
            tabControl1.SuspendLayout();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabSinhVien
            // 
            tabSinhVien.Controls.Add(groupBoxSinhVienViewData);
            tabSinhVien.Controls.Add(groupBoxSinhVien2);
            tabSinhVien.Controls.Add(groupBoxSinhVien1);
            tabSinhVien.Location = new Point(4, 24);
            tabSinhVien.Name = "tabSinhVien";
            tabSinhVien.Padding = new Padding(3);
            tabSinhVien.Size = new Size(792, 422);
            tabSinhVien.TabIndex = 1;
            tabSinhVien.Text = "Sinh Viên";
            tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBoxSinhVienViewData
            // 
            groupBoxSinhVienViewData.Controls.Add(dataGridViewSinhVien);
            groupBoxSinhVienViewData.Location = new Point(404, 6);
            groupBoxSinhVienViewData.Name = "groupBoxSinhVienViewData";
            groupBoxSinhVienViewData.Size = new Size(382, 408);
            groupBoxSinhVienViewData.TabIndex = 2;
            groupBoxSinhVienViewData.TabStop = false;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Dock = DockStyle.Fill;
            dataGridViewSinhVien.Location = new Point(3, 19);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowTemplate.Height = 25;
            dataGridViewSinhVien.Size = new Size(376, 386);
            dataGridViewSinhVien.TabIndex = 0;
            // 
            // groupBoxSinhVien2
            // 
            groupBoxSinhVien2.Controls.Add(btnSVThem);
            groupBoxSinhVien2.Location = new Point(8, 304);
            groupBoxSinhVien2.Name = "groupBoxSinhVien2";
            groupBoxSinhVien2.Size = new Size(390, 110);
            groupBoxSinhVien2.TabIndex = 1;
            groupBoxSinhVien2.TabStop = false;
            // 
            // btnSVThem
            // 
            btnSVThem.Location = new Point(66, 22);
            btnSVThem.Name = "btnSVThem";
            btnSVThem.Size = new Size(90, 30);
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
            groupBoxSinhVien1.Location = new Point(8, 6);
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
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormQuanLy";
            Text = "FormQuanLy";
            Load += FormQuanLy_Load;
            tabControl1.ResumeLayout(false);
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
    }
}