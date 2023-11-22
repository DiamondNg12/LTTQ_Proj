using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        // QLPhong
        private void addComboBox()
        {
            cmbPSoNguoiToiDa.Items.Add("4");
            cmbPSoNguoiToiDa.Items.Add("6");
            cmbPSoNguoiToiDa.Items.Add("8");
        }
        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            //tabpanel Phong
            addComboBox();
            this.KeyPreview = true;
            dgvPDanhSachPhong.DataSource = dc.dataTable("Select * from Phong");
            // tabpanel SinhVien
            dataGridViewSinhVien.DataSource = dc.dataTable("Select * from SinhVien");

            //tabpanel Thue Phong
            ThuePhong();
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
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
        private void btnPThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnPTimKiem_Click(object sender, EventArgs e)
        {
            String sql = "Select * from Phong";
            String dk = "";
            if (txtPMaPhong.Text.Trim() != "")
            {
                dk += " MaPhong like '%" + txtPMaPhong.Text + "%'";
            }
            if (txtPTenPhong.Text.Trim() != "" && dk == "")
            {
                dk += " TenPhong like N'%" + txtPTenPhong.Text + "%'";
            }

            if (txtPTenPhong.Text.Trim() != "" && dk != "")
            {
                dk += " AND TenPhong like N'%" + txtPTenPhong.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }


            dgvPDanhSachPhong.DataSource = dc.dataTable(sql);
        }

        private void dgvPDanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtPMaPhong.Text = dgvPDanhSachPhong[0, e.RowIndex].Value.ToString();
                txtPTenPhong.Text = dgvPDanhSachPhong[1, e.RowIndex].Value.ToString();
                txtPMaNha.Text = dgvPDanhSachPhong[2, e.RowIndex].Value.ToString();
                cmbPSoNguoiToiDa.SelectedIndex = cmbPSoNguoiToiDa.Items.IndexOf(dgvPDanhSachPhong[4, e.RowIndex].Value.ToString());
                txtPSoNguoiDangO.Text = dgvPDanhSachPhong[4, e.RowIndex].Value.ToString();
                txtPTienThue.Text = dgvPDanhSachPhong[5, e.RowIndex].Value.ToString();
                txtPGhiChu.Text = dgvPDanhSachPhong[6, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnPThem_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra mã Phòng có bị để trống không
            if (txtPMaPhong.Text.Trim() == "")
            {
                errorPhong.SetError(txtPMaPhong, "Bạn không để trống mã phòng!");
                return;
            }
            else
            {
                errorPhong.Clear();
            }

            if (txtPTenPhong.Text.Trim() == "")
            {
                errorPhong.SetError(txtPTenPhong, "Bạn không để trống tên phòng!");
                return;
            }
            else
            {
                errorPhong.Clear();
            }

            if (txtPMaNha.Text.Trim() == "")
            {
                errorPhong.SetError(txtPMaNha, "Bạn không để trống mã nhà!");
                return;
            }
            else
            {
                errorPhong.Clear();
            }
            if (txtPSoNguoiDangO.Text.Trim() == "")
            {
                errorPhong.SetError(txtPMaNha, "Bạn không để trống số người đang ở!");
                return;
            }
            else
            {
                errorPhong.Clear();
            }

            //Kiểm tra xem mã phong đã tồn tại chưa đẻ tránh việc insert mới bị lỗi
            DataTable db = dc.dataTable($"Select * from Phong Where MaPhong = N'{txtPMaPhong.Text}'");
            if (db.Rows.Count > 0)
            {
                errorPhong.SetError(txtPMaPhong, "Mã phòng trùng trong cơ sở dữ liệu");
                return;
            }
            errorPhong.Clear();
            //////Insert vao CSDL
            string loaiPhong = grbLoaiPhong.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault().Text;
            //sql = "INSERT INTO PHONG VALUES (";
            //sql += "N'" + txtPMaPhong.Text + "',N'" + txtPTenPhong.Text + "', N'" + txtPMaNha.Text + "','" + loaiPhong + "', "cmbPSoNguoiToiDa.Text + "'," + txtPSoNguoiDangO.Text + "," + txtPTienThue.Text + ",N'" + txtPGhiChu.Text + "')";
            sql = $"INSERT INTO PHONG VALUES (N'{txtPMaPhong.Text}', N'{txtPTenPhong.Text}', N'{txtPMaNha.Text}', N'{loaiPhong}', {cmbPSoNguoiToiDa.Text}, {txtPSoNguoiDangO.Text}, {txtPTienThue.Text}, N'{txtPGhiChu.Text}')";
            dc.dbQuery(sql);
            dgvPDanhSachPhong.DataSource = dc.dataTable("select * from PHONG");
            //Thông báo đã thêm thành công
            MessageBox.Show("Thêm phòng thành công!");

            //Clear các control
            txtPMaPhong.Text = "";
            txtPTenPhong.Text = "";
            txtPMaNha.Text = "";
            txtPSoNguoiDangO.Text = "";
            grbLoaiPhong.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);
            cmbPSoNguoiToiDa.SelectedIndex = -1;
            txtPTienThue.Text = "";
            txtPGhiChu.Text = "";

        }

        private void btnPSua_Click(object sender, EventArgs e)
        {
            // Validate input data
            if (txtPMaPhong.Text.Trim() == "")
            {
                errorPhong.SetError(txtPMaPhong, "Nhập mã phòng");
                return;
            }

            if (txtPTenPhong.Text.Trim() == "")
            {
                errorPhong.SetError(txtPTenPhong, "Nhập tên phòng");
                return;
            }
            if (txtPMaNha.Text.Trim() == "")
            {
                errorPhong.SetError(txtPMaNha, "Nhập mã nhà");
                return;
            }
            if (grbLoaiPhong.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault() == null)
            {
                errorPhong.SetError(grbLoaiPhong, "Chọn loại phòng");
                return;
            }
            if (cmbPSoNguoiToiDa.Text.Trim() == "")
            {
                errorPhong.SetError(cmbPSoNguoiToiDa, "Chọn số người ở tối đa của 1 phòng");
                return;
            }


            if (txtPTienThue.Text.Trim() == "")
            {
                errorPhong.SetError(txtPTienThue, "Nhập tiền thuê");
                return;
            }

            // Construct the SQL update statement
            string sql = "UPDATE Phong SET ";
            sql += "TenPhong = N'" + txtPTenPhong.Text + "',";
            sql += "SoNguoiToiDa = " + cmbPSoNguoiToiDa.Text + ",";
            sql += "SoNguoiDangO = " + txtPSoNguoiDangO.Text + ",";
            sql += "TienThue = " + txtPTienThue.Text + ",";
            sql += "GhiChu = N'" + txtPGhiChu.Text + "' ";
            sql += "WHERE MaPhong = N'" + txtPMaPhong.Text + "'";

            // Execute the SQL update statement
            //SqlCommand cmd = new SqlCommand(sql, con);
            // int rowsAffected = cmd.ExecuteNonQuery();
            try
            {
                dc.dbQuery(sql);
                MessageBox.Show("Cập nhật phòng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật thông tin phòng");
            }
            dgvPDanhSachPhong.DataSource = dc.dataTable("select * from PHONG");
            //// Display update success message
            //if (rowsAffected > 0)
            //{
            //    MessageBox.Show("Cập nhật phòng thành công!");
            //}
            //else
            //{
            //    MessageBox.Show("Không thể cập nhật thông tin phòng");
            //}
        }

        private void btnPXoa_Click(object sender, EventArgs e)
        {

        }

        private void ThuePhong()
        {
            string sql = "Select * from Phong  WHERE (SoNguoiDangO < SoNGuoiToiDa)";
            string sql1 = "select * from SinhVien where MaSinhVien not in (select  MaSV from ThuePhong)";
            dvgDSSVThuePhong.DataSource = dc.dataTable(sql1);
            dgvDSPhongConTrong.DataSource = dc.dataTable(sql);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.SelectedRows.Count > 0)
            {
                if (dataGridViewSinhVien.SelectedRows[0].Cells["MaSinhVien"].Value.ToString() != "")
                {
                    inputSVMaSinhVien.Text = dataGridViewSinhVien.SelectedRows[0].Cells["MaSinhVien"].Value.ToString();
                }
            }
        }
        //private void grbThongTinThue_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridViewSinhVien.SelectedRows.Count > 0)
        //    {
        //        if (dataGridViewSinhVien.SelectedRows[0].Cells["MaSinhVien"].Value.ToString() != "")
        //        {
        //            inputSVMaSinhVien.Text = dataGridViewSinhVien.SelectedRows[0].Cells["MaSinhVien"].Value.ToString();
        //        }
        //    }



        //}


        private void dataGridViewSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.SelectedRows.Count > 0)
            {
                inputSVMaSinhVien.Text = dataGridViewSinhVien.SelectedRows[0].Cells["MaSinhVien"].Value.ToString();
                inputSVTenSinhVien.Text = dataGridViewSinhVien.SelectedRows[0].Cells["TenSinhVien"].Value.ToString();
                inputSVNgaySinh.Text = dataGridViewSinhVien.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                inputSVGioiTinh.Text = dataGridViewSinhVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                inputSVMaQue.Text = dataGridViewSinhVien.SelectedRows[0].Cells["MaQue"].Value.ToString();
                inputSVMaKhoa.Text = dataGridViewSinhVien.SelectedRows[0].Cells["MaKhoa"].Value.ToString();
                inputSVMaLop.Text = dataGridViewSinhVien.SelectedRows[0].Cells["MaLop"].Value.ToString();

            }
        }


        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            //inputSVMaSinhVien.text
            try
            {
                string delete_sql = $"delete from SinhVien where MaSinhVien = N'{inputSVMaSinhVien.Text}'";
                dc.dbQuery(delete_sql);
                MessageBox.Show("Xóa Sinh Viên Thành Công");
                dataGridViewSinhVien.DataSource = dc.dataTable("Select * from SinhVien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Sinh Viên Không Thành Công");
            }



        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            if (inputSVMaSinhVien.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaSinhVien, "Nhập mã sinh viên");
                return;
            }
            if (inputSVTenSinhVien.Text.Trim() == "")
            {
                errorSV.SetError(inputSVTenSinhVien, "Nhập tên sinh viên");
            }
            if (inputSVNgaySinh.Text.Trim() == "")
            {
                errorSV.SetError(inputSVNgaySinh, "Nhập Ngày Sinh");
            }
            if (inputSVGioiTinh.Text.Trim() == "")
            {
                errorSV.SetError(inputSVGioiTinh, "Nhập Giới Tính");
            }
            if (inputSVMaQue.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaQue, "Nhập Quê");
            }
            if (inputSVMaKhoa.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaKhoa, "Nhập Khoa");
            }
            if (inputSVMaLop.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaLop, "Nhập Lớp");
            }

            String update_sql = $"update SinhVien set TenSinhVien =  N'{inputSVTenSinhVien.Text}'," +
            $" NgaySinh = N'{inputSVNgaySinh.Text}'," +
            $" GioiTinh = N'{inputSVGioiTinh.Text}'," +
            $" MaQue = N'{inputSVMaQue.Text}'," +
            $" MaKhoa = N'{inputSVMaKhoa.Text}'," +
            $" MaLop = N'{inputSVMaLop.Text}' where MaSinhVien = N'{inputSVMaSinhVien.Text}'";
            try
            {
                dc.dbQuery(update_sql);
                MessageBox.Show("Sửa Sinh Viên Thành Công");
                dataGridViewSinhVien.DataSource = dc.dataTable("Select * from SinhVien");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Sửa Sinh Viên Không Thành Công");
            }


        }

        private void dvgDSSVThuePhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgDSSVThuePhong.SelectedRows.Count > 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = dvgDSSVThuePhong.SelectedRows[0];

                // Lấy giá trị từ các ô trong dòng đó và Gán giá trị vào TextBox trong GroupBox
                txtMSVThue.Text = selectedRow.Cells["MaSinhVien"].Value.ToString();
                string sql = $"select * from Phong where LoaiPhong = N'{selectedRow.Cells["GioiTinh"].Value.ToString()}' and SoNguoiDangO < SoNguoiToiDa";
                dgvDSPhongConTrong.DataSource = dc.dataTable(sql);
            }
        }

        private void dgvDSPhongConTrong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSPhongConTrong.SelectedRows.Count > 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = dgvDSPhongConTrong.SelectedRows[0];
                // Lấy giá trị từ các ô trong dòng đó và Gán giá trị vào TextBox trong GroupBox
                txtMaPhongThue.Text = selectedRow.Cells["MaPhong"].Value.ToString();
            }
        }
        //thoat Thue Phong
        private void btnTThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        //Thêm Sv muốn thuê vào phòng còn trống
        private void btnTThem_Click(object sender, EventArgs e)
        {
            
            //Kiểm tra điều kiện ngày
            if (dtpNgayBD.Value < DateTime.Now)
            {
                errorThuePhong.SetError(dtpNgayBD, "Ngày bắt đầu không hợp lệ!");
                return;
            }

            if (dtpNgayBD.Value > dtpNgayKT.Value)
            {
                errorThuePhong.SetError(lableKT, "Ngày kết thúc phải sau ngày bắt đầu");
                return;
            }
            errorThuePhong.Clear();
            //Kiểm tra điều kiện thuê phòng
            DataTable check_SV_thue = dc.dataTable($"select * from SinhVien where MaSinhVien = N'{txtMSVThue.Text}'");
            DataTable check_phong_cho_thue = dc.dataTable($"select * from Phong where MaPhong = N'{txtMaPhongThue.Text}'");
            if (check_SV_thue.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy sinh viên có mã sinh viên: {txtMSVThue.Text}");
                return;
            } else if (check_phong_cho_thue.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy Phòng có mã phòng: {txtMaPhongThue.Text}");
                return;
            } else
            {
                if (Int32.Parse(check_phong_cho_thue.Rows[0]["SoNguoiDangO"].ToString()) >= Int32.Parse(check_phong_cho_thue.Rows[0]["SoNguoiToiDa"].ToString()))
                {
                    MessageBox.Show($"Phòng không còn chỗ trống");
                    return;
                }
                if (check_phong_cho_thue.Rows[0]["LoaiPhong"].ToString() != check_SV_thue.Rows[0]["GioiTinh"].ToString()) 
                {
                    MessageBox.Show($"Loại phòng không phù hợp với giới tính Sinh Viên");
                    return;
                }
            }
            //MessageBox.Show($"MSV: {txtMSVThue.Text}, MP: {txtMaPhongThue.Text}, BD: {dtpNgayBD.Value}, KT: {dtpNgayKT.Value}");
            

            //Thông báo đã thêm thành công
            MessageBox.Show("Thêm phòng thành công!");
        }
    }
}
