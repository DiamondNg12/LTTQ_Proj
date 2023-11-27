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

        private void refreshDgvThuTienPhongData()
        {
            dgvThuTienPhong.DataSource = dc.dataTable("select * from ThuTienPhong");
            dgvThuTienPhong.Columns[0].HeaderText = "Mã Phòng";
            dgvThuTienPhong.Columns[1].HeaderText = "Tháng";
            dgvThuTienPhong.Columns[2].HeaderText = "Năm";
            dgvThuTienPhong.Columns[3].HeaderText = "Tiền nhà";
            dgvThuTienPhong.Columns[4].HeaderText = "Tiền điện";
            dgvThuTienPhong.Columns[5].HeaderText = "Tiền nước";
            dgvThuTienPhong.Columns[6].HeaderText = "Tiền vệ sinh";
            dgvThuTienPhong.Columns[7].HeaderText = "Tiền phạt";
            dgvThuTienPhong.Columns[8].HeaderText = "Ngày hết hạn";
            dgvThuTienPhong.Columns[9].HeaderText = "Ngày đóng";
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


            // Thu Tien Phong
            this.refreshDgvThuTienPhongData();
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

        private void dgvPDanhSachPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPDanhSachPhong.SelectedRows.Count > 0)
            {
                txtPMaPhong.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["MaPhong"].Value.ToString();
                txtPTenPhong.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["TenPhong"].Value.ToString();
                txtPMaNha.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["MaNha"].Value.ToString();
                if (dgvPDanhSachPhong.SelectedRows[0].Cells["LoaiPhong"].Value.ToString() == "Nam")
                {
                    rdbPNam.Checked = true;
                }
                else
                {
                    rdbPNu.Checked = true;
                }
                cmbPSoNguoiToiDa.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["SoNguoiToiDa"].Value.ToString();
                txtPSoNguoiDangO.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["SoNguoiDangO"].Value.ToString();
                txtPTienThue.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["TienThue"].Value.ToString();
                txtPGhiChu.Text = dgvPDanhSachPhong.SelectedRows[0].Cells["GhiChu"].Value.ToString();
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
            string LoaiPhong;
            if (rdbPNam.Checked == true)
            {
                LoaiPhong = "Nam";
            }
            else if (rdbPNu.Checked == true)
            {
                LoaiPhong = "Nữ";
            }
            else
            {
                MessageBox.Show("Chọn loại phòng");
                return;
            }
            if (txtPSoNguoiDangO.Text.Trim() == "")
            {
                errorPhong.SetError(txtPMaNha, "Bạn không để trống số người đang ở ");
                return;
            }
            else
            {
                errorPhong.Clear();
            }
            if (txtPTienThue.Text.Trim() == "")
            {
                errorPhong.SetError(txtPTienThue, "Bạn không để trống tiền thuê");
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
               MessageBox.Show("Mã phòng trùng trong cơ sở dữ liệu");
                return;
     
            }

            //////Insert vao CSDL
            try
            {
                sql = $"INSERT INTO PHONG VALUES (N'{txtPMaPhong.Text}', N'{txtPTenPhong.Text}', N'{txtPMaNha.Text}', N'{LoaiPhong}', {cmbPSoNguoiToiDa.Text}, {txtPSoNguoiDangO.Text}, {txtPTienThue.Text}, N'{txtPGhiChu.Text}')";
                dc.dbQuery(sql);
                dgvPDanhSachPhong.DataSource = dc.dataTable("select * from PHONG");
                //Thông báo đã thêm thành công
                MessageBox.Show("Thêm phòng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
                MessageBox.Show(ex.Message);
            }

            //Clear các control
            txtPMaPhong.Text = "";
            txtPTenPhong.Text = "";
            txtPMaNha.Text = "";
            txtPSoNguoiDangO.Text = "";
            rdbPNam.Checked = false;
            rdbPNu.Checked = false;
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
                dgvPDanhSachPhong.DataSource = dc.dataTable("select * from PHONG");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật thông tin phòng");
            }
            
        }

        private void btnPXoa_Click(object sender, EventArgs e)
        {
            if (txtPMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng");
                return;
            }
            try
            { 
            string delete_phong = $"delete from Phong where MaPhong = N'{txtPMaPhong.Text}'";
                dc.dbQuery(delete_phong);
                MessageBox.Show("Xóa phòng thành công");
                dgvPDanhSachPhong.DataSource = dc.dataTable("select * from Phong");
             }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa phòng không thành công");
            }
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
           if(inputSVMaSinhVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền mã sinh viên");
                return;
            }
            
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
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (inputSVTenSinhVien.Text.Trim() == "")
            {
                errorSV.SetError(inputSVTenSinhVien, "Nhập tên sinh viên");
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (inputSVNgaySinh.Text.Trim() == "")
            {
                errorSV.SetError(inputSVNgaySinh, "Nhập Ngày Sinh");
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (inputSVGioiTinh.Text.Trim() == "")
            {
                errorSV.SetError(inputSVGioiTinh, "Nhập Giới Tính");
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (inputSVMaQue.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaQue, "Nhập Quê");
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (inputSVMaKhoa.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaKhoa, "Nhập Khoa");
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (inputSVMaLop.Text.Trim() == "")
            {
                errorSV.SetError(inputSVMaLop, "Nhập Lớp");
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
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
            }
            else if (check_phong_cho_thue.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy Phòng có mã phòng: {txtMaPhongThue.Text}");
                return;
            }
            else
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


            DataTable danh_sach_thue_phong = dc.dataTable("select * from ThuePhong");
            int new_MST;
            if (danh_sach_thue_phong.Rows.Count == 0)
            {
                new_MST = 1;
            }
            else
            {
                int max_MST = Int32.Parse(danh_sach_thue_phong.Rows[danh_sach_thue_phong.Rows.Count - 1]["MaSoThue"].ToString());
                new_MST = max_MST + 1;
            }
            string MaSoThue = new_MST.ToString().PadLeft(5, '0');

            try
            {
                string insert_sql = $"insert into ThuePhong values (N'{MaSoThue}', N'{txtMSVThue.Text}', N'{txtMaPhongThue.Text}', '{dtpNgayBD.Value}', '{dtpNgayKT.Value}', N'{txtGhiChuThue.Text}')";
                dc.dbQuery(insert_sql);
                MessageBox.Show("Thuê phòng thành công!");
                string update_phong = $"update Phong set SoNguoiDangO = SoNguoiDangO + 1 where MaPhong = N'{txtMaPhongThue.Text}'";
                dc.dbQuery(update_phong);
                string sql = $"select * from Phong where SoNguoiDangO < SoNguoiToiDa";
                dgvDSPhongConTrong.DataSource = dc.dataTable(sql);
                string sql1 = "select * from SinhVien where MaSinhVien not in (select  MaSV from ThuePhong)";
                dvgDSSVThuePhong.DataSource = dc.dataTable(sql1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Thuê phòng không thành công!");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCurentMonth_Click(object sender, EventArgs e)
        {
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String mm = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();

            int current_month = Int32.Parse(mm);
            int next_month = current_month + 1;
            int next_year = Int32.Parse(yy);
            if (current_month == 12)
            {
                next_month = 1;
                next_year += 1;
            }


            // Create a DateTime variable
            DateTime next_date = new DateTime(next_year, next_month, 7);

            DataTable phong_co_nguoi_o_chua_co_hoa_don = dc.dataTable($"select * from Phong where SoNguoiDangO > 0 and MaPhong not in (select MaPhong from ThuTienPhong where Thang = {mm} and Nam = {yy})");
            string insert_sql = $"insert into ThuTienPhong (MaPhong, Thang, Nam, TienNha, NgayHetHan) values ";
            if (phong_co_nguoi_o_chua_co_hoa_don.Rows.Count > 0)
            {
                for (int i = 0; i < phong_co_nguoi_o_chua_co_hoa_don.Rows.Count; i++)
                {
                    insert_sql += $"(N'{phong_co_nguoi_o_chua_co_hoa_don.Rows[i]["MaPhong"]}', {mm}, {yy}, {phong_co_nguoi_o_chua_co_hoa_don.Rows[i]["TienThue"]}, '{next_date.ToString()}')";
                    if (i != phong_co_nguoi_o_chua_co_hoa_don.Rows.Count - 1)
                    {
                        insert_sql += ", ";
                    }
                }
                try
                {
                    dc.dbQuery(insert_sql);
                    MessageBox.Show("Cập nhật hành công");
                    this.refreshDgvThuTienPhongData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Có lỗi xảy ra. Cập nhật không thành công.");
                }
            }
            else
            {
                MessageBox.Show("Các phòng đã được cập nhật từ trước.");
            }
        }

        private void btnTTPExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnThueTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMSVThue.Text.Trim() == "" && txtMaPhongThue.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền Mã Sinh Viên hoặc Mã Phòng cần tìm.");
                return;
            }
            if (txtMSVThue.Text.Trim() != "")
            {
                string select_sql_SV = $"select * from SinhVien where MaSinhVien = N'{txtMSVThue.Text}' and MaSinhVien not in (select  MaSV from ThuePhong)";
                dvgDSSVThuePhong.DataSource = dc.dataTable(select_sql_SV);
            }
            if (txtMaPhongThue.Text.Trim() != "")
            {
                string select_sql_SV = $"select * from Phong where MaPhong = N'{txtMaPhongThue.Text}' and SoNguoiDangO < SoNguoiToiDa";
                dgvDSPhongConTrong.DataSource = dc.dataTable(select_sql_SV);
            }
        }


        private void btnTTPSearch_Click(object sender, EventArgs e)
        {
            if (txtMaPhongThuTien.Text.Trim() == "" && txtThangThuTien.Text.Trim() == "" && txttNamThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền Mã Phòng hoặc Tháng, Năm cần tìm.");
                return;
            }
            bool need_and = false;
            string select_sql = "select * from ThuTienPhong where ";
            if (txtMaPhongThuTien.Text.Trim() != "")
            {
                select_sql += $"MaPhong = N'{txtMaPhongThuTien.Text}' ";
                need_and = true;
            }
            if (txtThangThuTien.Text.Trim() != "")
            {
                if (need_and)
                {
                    select_sql += "and ";
                }
                select_sql += $"Thang = {txtThangThuTien.Text} ";
                need_and = true;
            }
            if (txttNamThuTien.Text.Trim() != "")
            {
                if (need_and)
                {
                    select_sql += "and ";
                }
                select_sql += $"Nam = {txttNamThuTien.Text} ";
            }
            dgvThuTienPhong.DataSource = dc.dataTable(select_sql);
        }

        private void btnTTPHoaDonChuaThanhToan_Click(object sender, EventArgs e)
        {
            dgvThuTienPhong.DataSource = dc.dataTable("select * from ThuTienPhong where NgayDong is null");
        }

        private void dgvThuTienPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThuTienPhong.SelectedRows.Count > 0)
            {
                txtMaPhongThuTien.Text = dgvThuTienPhong.SelectedRows[0].Cells["MaPhong"].Value.ToString();
                txtThangThuTien.Text = dgvThuTienPhong.SelectedRows[0].Cells["Thang"].Value.ToString();
                txttNamThuTien.Text = dgvThuTienPhong.SelectedRows[0].Cells["Nam"].Value.ToString();
                txtTienNha.Text = dgvThuTienPhong.SelectedRows[0].Cells["TienNha"].Value.ToString();
                try
                {
                    dateTimePicker2.Value = DateTime.Parse(dgvThuTienPhong.SelectedRows[0].Cells["NgayHetHan"].Value.ToString());
                }
                catch (Exception ex)
                {

                }
                txtTienDien.Text = dgvThuTienPhong.SelectedRows[0].Cells["TienDien"].Value.ToString();
                txtTienNuoc.Text = dgvThuTienPhong.SelectedRows[0].Cells["TienNuoc"].Value.ToString();
                txtTienVeSinh.Text = dgvThuTienPhong.SelectedRows[0].Cells["TienVeSinh"].Value.ToString();
                txtTienPhat.Text = dgvThuTienPhong.SelectedRows[0].Cells["TienPhat"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhongThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Phòng");
                return;
            }
            if (txtThangThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tháng thu tiền");
                return;
            }
            if (txttNamThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập năm thu tiền");
                return;
            }
            if (txtTienDien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền điện");
                return;
            }
            if (txtTienNuoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền nước");
                return;
            }
            if (txtTienVeSinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền vệ sinh");
                return;
            }

            DataTable check_thu_tien_phong = dc.dataTable($"select * from ThuTienPhong where MaPhong = N'{txtMaPhongThuTien.Text}' and Thang = {txtThangThuTien.Text} and Nam = {txttNamThuTien.Text}");
            if (check_thu_tien_phong.Rows.Count > 0)
            {
                if (check_thu_tien_phong.Rows[0]["NgayDong"].ToString() != "")
                {
                    MessageBox.Show("Hoá đơn này đã được đóng, không thể cập nhật.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hoá đơn");
                return;
            }
            // Sql
            string update_sql = $"Update ThuTienPhong set TienNha = {txtTienNha.Text}, TienDien = {txtTienDien.Text}, TienNuoc = {txtTienNuoc.Text}, TienVeSinh = {txtTienVeSinh.Text}, NgayHetHan = '{dateTimePicker2.Value.ToString()}' where MaPhong = N'{txtMaPhongThuTien.Text}' and Thang = {txtThangThuTien.Text} and Nam = {txttNamThuTien.Text}";
            try
            {
                dc.dbQuery(update_sql);
                dgvThuTienPhong.DataSource = dc.dataTable("select * from ThuTienPhong");
                MessageBox.Show("Cập nhật thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra. Cập nhật không thành công");
                return;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTienDien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền điện");
                return;
            }
            if (txtTienNuoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền nước");
                return;
            }
            if (txtTienVeSinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền vệ sinh");
                return;
            }
            DateTime now = DateTime.Now;
            int tien_phat;
            if (now <= dateTimePicker2.Value)
            {
                txtTienPhat.Text = "0";
                tien_phat = 0;
            }
            else
            {
                tien_phat = (int)now.Subtract(dateTimePicker2.Value).TotalDays * 10000;
                txtTienPhat.Text = (tien_phat).ToString();
            }
            decimal.TryParse(txtTienNha.Text, out decimal tien_nha_decimal);
            decimal.TryParse(txtTienDien.Text, out decimal tien_dien_decimal);
            decimal.TryParse(txtTienNuoc.Text, out decimal tien_nuoc_decimal);
            decimal.TryParse(txtTienVeSinh.Text, out decimal tien_ve_sinh_decimal);

            int tong_tien = (int)tien_nha_decimal + (int)tien_dien_decimal + (int)tien_nuoc_decimal + (int)tien_ve_sinh_decimal + tien_phat;
            txtTongTienPhong.Text = tong_tien.ToString();
        }

        private void btnTTPThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaPhongThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Phòng");
                return;
            }
            if (txtThangThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tháng thu tiền");
                return;
            }
            if (txttNamThuTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập năm thu tiền");
                return;
            }
            if (txtTienDien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền điện");
                return;
            }
            if (txtTienNuoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền nước");
                return;
            }
            if (txtTienVeSinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền vệ sinh");
                return;
            }

            DataTable check_thu_tien_phong = dc.dataTable($"select * from ThuTienPhong where MaPhong = N'{txtMaPhongThuTien.Text}' and Thang = {txtThangThuTien.Text} and Nam = {txttNamThuTien.Text}");
            if (check_thu_tien_phong.Rows.Count > 0)
            {
                if (check_thu_tien_phong.Rows[0]["NgayDong"].ToString() != "")
                {
                    MessageBox.Show("Hoá đơn này đã được đóng, không thể cập nhật.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hoá đơn");
                return;
            }
            DateTime now = DateTime.Now;
            int tien_phat;
            if (now <= dateTimePicker2.Value)
            {
                txtTienPhat.Text = "0";
                tien_phat = 0;
            }
            else
            {
                tien_phat = (int)now.Subtract(dateTimePicker2.Value).TotalDays * 10000;
                txtTienPhat.Text = (tien_phat).ToString();
            }
            string update_sql = $"Update ThuTienPhong set TienNha = {txtTienNha.Text}, TienDien = {txtTienDien.Text}, TienNuoc = {txtTienNuoc.Text}, TienVeSinh = {txtTienVeSinh.Text}, NgayHetHan = '{dateTimePicker2.Value.ToString()}', TienPhat = {tien_phat}, NgayDong = '{now}' where MaPhong = N'{txtMaPhongThuTien.Text}' and Thang = {txtThangThuTien.Text} and Nam = {txttNamThuTien.Text}";
            try
            {
                dc.dbQuery(update_sql);
                MessageBox.Show("Thanh toán hoá đơn thành công.");
                dgvThuTienPhong.DataSource = dc.dataTable("select * from ThuTienPhong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
