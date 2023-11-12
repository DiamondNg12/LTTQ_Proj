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
            tabSinhVien = new TabPage();
            groupBoxSinhVienViewData = new GroupBox();
            dataGridViewSinhVien = new DataGridView();
            groupBoxSinhVien2 = new GroupBox();
            groupBoxSinhVien1 = new GroupBox();
            labelSVNgaySinh = new Label();
            inputSVTenSinhVien = new TextBox();
            labelSVTenSV = new Label();
            inputSVMaSinhVien = new TextBox();
            labelSVMaSV = new Label();
            inputSVNgaySinh = new TextBox();
            labelSVGioiTinh = new Label();
            inputSVGioiTinh = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            tabControl1.SuspendLayout();
            tabSinhVien.SuspendLayout();
            groupBoxSinhVienViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            groupBoxSinhVien1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabSinhVien);
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
            groupBoxSinhVien2.Location = new Point(8, 263);
            groupBoxSinhVien2.Name = "groupBoxSinhVien2";
            groupBoxSinhVien2.Size = new Size(390, 151);
            groupBoxSinhVien2.TabIndex = 1;
            groupBoxSinhVien2.TabStop = false;
            // 
            // groupBoxSinhVien1
            // 
            groupBoxSinhVien1.Controls.Add(comboBox3);
            groupBoxSinhVien1.Controls.Add(comboBox2);
            groupBoxSinhVien1.Controls.Add(comboBox1);
            groupBoxSinhVien1.Controls.Add(inputSVGioiTinh);
            groupBoxSinhVien1.Controls.Add(label3);
            groupBoxSinhVien1.Controls.Add(label2);
            groupBoxSinhVien1.Controls.Add(label1);
            groupBoxSinhVien1.Controls.Add(labelSVGioiTinh);
            groupBoxSinhVien1.Controls.Add(labelSVNgaySinh);
            groupBoxSinhVien1.Controls.Add(inputSVNgaySinh);
            groupBoxSinhVien1.Controls.Add(inputSVTenSinhVien);
            groupBoxSinhVien1.Controls.Add(labelSVTenSV);
            groupBoxSinhVien1.Controls.Add(inputSVMaSinhVien);
            groupBoxSinhVien1.Controls.Add(labelSVMaSV);
            groupBoxSinhVien1.Location = new Point(8, 6);
            groupBoxSinhVien1.Name = "groupBoxSinhVien1";
            groupBoxSinhVien1.Size = new Size(390, 251);
            groupBoxSinhVien1.TabIndex = 0;
            groupBoxSinhVien1.TabStop = false;
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
            // inputSVNgaySinh
            // 
            inputSVNgaySinh.Location = new Point(130, 86);
            inputSVNgaySinh.Name = "inputSVNgaySinh";
            inputSVNgaySinh.Size = new Size(214, 23);
            inputSVNgaySinh.TabIndex = 1;
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
            // inputSVGioiTinh
            // 
            inputSVGioiTinh.FormattingEnabled = true;
            inputSVGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            inputSVGioiTinh.Location = new Point(130, 120);
            inputSVGioiTinh.Name = "inputSVGioiTinh";
            inputSVGioiTinh.Size = new Size(98, 23);
            inputSVGioiTinh.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 156);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Giới tính";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(130, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 190);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Giới tính";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox2.Location = new Point(130, 187);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 23);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 222);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox3.Location = new Point(130, 219);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(98, 23);
            comboBox3.TabIndex = 3;
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
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}