using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTTQ_Proj
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        DatabaseConnection dc = new DatabaseConnection();

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            // tabpanel SinhVien
            dataGridViewSinhVien.DataSource = dc.dataTable("Select * from SinhVien");

            // combobox inputSVMaQue
            DataTable ques = dc.dataTable("Select * from Que");
            foreach (DataRow que in ques.Rows)
            {
                inputSVMaQue.Items.Add($"{que["MaQue"]} - {que["TenQue"]}");
            }

            // combobox inputSVMaKhoa
            DataTable khoas = dc.dataTable("Select * from Khoa");
            inputSVMaKhoa.DisplayMember = "Text";
            inputSVMaKhoa.ValueMember = "Value";

            foreach (DataRow khoa in khoas.Rows)
            {
                inputSVMaKhoa.Items.Add(new { Text = $"{khoa["MaKhoa"]} - {khoa["TenKhoa"]}", Value = khoa["MaKhoa"] });
            }
        }

        private void inputSVMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = inputSVMaKhoa.SelectedItem.GetType().GetProperty("Value")?.GetValue(inputSVMaKhoa.SelectedItem);

            inputSVMaLop.Items.Clear();
            DataTable lops = dc.dataTable($"Select * from Lop where MaKhoa = N'{selectedValue.ToString()}'");
            foreach (DataRow lop in lops.Rows)
            {
                inputSVMaLop.Items.Add($"{lop["MaLop"]} - {lop["TenLop"]}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSVThem_Click(object sender, EventArgs e)
        {
            string ma_sinh_vien = inputSVMaSinhVien.Text;
            string ten_sinh_vien = inputSVTenSinhVien.Text;
            string gioi_tinh = inputSVGioiTinh.Text;
            string ngay_sinh = inputSVNgaySinh.Text;
            string[] que = inputSVMaQue.Text.Split(" - ");
            string ma_que = que[0];
            string[] khoa = inputSVMaKhoa.Text.Split(" - ");
            string ma_khoa = khoa[0];
            string[] lop = inputSVMaLop.Text.Split(" - ");
            string ma_lop = lop[0];
            if (ma_sinh_vien.Trim() != "" && ten_sinh_vien.Trim() != "" && gioi_tinh.Trim() != "" && ngay_sinh.Trim() != "" && ma_que.Trim() != "" && ma_khoa.Trim() != "" && ma_lop.Trim() != "")
            {
                dc.addSinhVien(ma_sinh_vien, ten_sinh_vien, ngay_sinh, gioi_tinh, ma_que, ma_khoa, ma_lop);
                MessageBox.Show("Thêm Sinh viên thành công");
                dataGridViewSinhVien.DataSource = dc.dataTable("select * from SinhVien");
            } else {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
    }
}
