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

namespace LTTQ_Proj
{
    public partial class Form_QLPhong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        DatabaseConnection DB = new DatabaseConnection();

        public Form_QLPhong()
        {
            InitializeComponent();
        }
        private void addComboBox()
        {
            cmbPSoNguoiToiDa.Items.Add("4");
            cmbPSoNguoiToiDa.Items.Add("6");
            cmbPSoNguoiToiDa.Items.Add("8");
        }

        private void cmbPSoNguoiToiDa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_QLPhong_Load(object sender, EventArgs e)
        {
            addComboBox();
            this.KeyPreview = true;
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-UP0UP9H\SQLEXPRESS;Initial Catalog=QLKiTucXa;Persist Security Info=True;User ID=sa;Password=123456";
            LoadDuLieu("Select * from Phong");
        }
        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvPDanhSachPhong.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
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
            //Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm
            LoadDuLieu(sql);


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

        private void btnPSua_Click(object sender, EventArgs e)
        {
            // Check if connection is open, otherwise open it
            if (con.State != ConnectionState.Open)
                con.Open();

            // Validate input data
            if (txtPMaPhong.Text.Trim() == "")
            {
                errorP.SetError(txtPMaPhong, "Nhập mã phòng");
                return;
            }

            if (txtPTenPhong.Text.Trim() == "")
            {
                errorP.SetError(txtPTenPhong, "Nhập tên phòng");
                return;
            }
            if (txtPMaNha.Text.Trim() == "")
            {
                errorP.SetError(txtPMaNha, "Nhập mã nhà");
                return;
            }
            if (grbPLoaiPhong.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault() == null)
            {
                errorP.SetError(grbPLoaiPhong, "Chọn loại phòng");
                return;
            }
            if (cmbPSoNguoiToiDa.Text.Trim() == "")
            {
                errorP.SetError(cmbPSoNguoiToiDa, "Chọn số người ở tối đa của 1 phòng");
                return;
            }


            if (txtPTienThue.Text.Trim() == "")
            {
                errorP.SetError(txtPTienThue, "Nhập tiền thuê");
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
            SqlCommand cmd = new SqlCommand(sql, con);
            int rowsAffected = cmd.ExecuteNonQuery();
            dgvPDanhSachPhong.DataSource = DB.dataTable("select * from PHONG");
            // Display update success message
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật phòng thành công!");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin phòng");
            }
        }
        private void btnPThem_Click(object sender, EventArgs e)
        {

            string sql = "";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra mã Phòng có bị để trống không
            if (txtPMaPhong.Text.Trim() == "")
            {
                errorP.SetError(txtPMaPhong, "Bạn không để trống mã phòng!");
                return;
            }
            else
            {
                errorP.Clear();
            }

            if (txtPTenPhong.Text.Trim() == "")
            {
                errorP.SetError(txtPTenPhong, "Bạn không để trống tên phòng!");
                return;
            }
            else
            {
                errorP.Clear();
            }

            if (txtPMaNha.Text.Trim() == "")
            {
                errorP.SetError(txtPMaNha, "Bạn không để trống mã nhà!");
                return;
            }
            else
            {
                errorP.Clear();
            }
            if (txtPSoNguoiDangO.Text.Trim() == "")
            {
                errorP.SetError(txtPMaNha, "Bạn không để trống số người đang ở!");
                return;
            }
            else
            {
                errorP.Clear();
            }

            //Kiểm tra xem mã phong đã tồn tại chưa đẻ tránh việc insert mới bị lỗi
            sql = "Select Count(*) From PHONG Where MaPhong ='" + txtPMaPhong.Text + "'";
            cmd = new SqlCommand(sql, con); int val = (int)cmd.ExecuteScalar();
            if (val > 0)
            {
                errorP.SetError(txtPMaPhong, "Mã phòng trùng trong cơ sở dữ liệu");
                return;
            }
            errorP.Clear();
            //////Insert vao CSDL
            //sql = "INSERT INTO tblMatHang(MaPhong,TenPhong,MaNha,LoaiPhong,SoNguoiOToiDa,SoNguoiDangO,TienThue,GhiChu)VALUES (";
            //sql += "N'" + txtPMaPhong.Text + "',N'" + txtPTenPhong.Text + "','" + txtPMaNha.Text + "','" + grbPLoaiPhong.Text
            //+ "',N'" + cmbPSoNguoiToiDa.Text + "'," + txtPSoNguoiDangO.Text + "," + txtPTienThue.Text + ",N'" + txtPGhiChu.Text + "')";

            string loaiPhong = grbPLoaiPhong.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault().Text;
            sql = "INSERT INTO PHONG(MaPhong,TenPhong,MaNha,LoaiPhong,SoNguoiToiDa,SoNguoiDangO,TienThue,GhiChu)VALUES (";
            sql += "N'" + txtPMaPhong.Text + "',N'" + txtPTenPhong.Text + "','" + txtPMaNha.Text + "','" + loaiPhong + "',N'" + cmbPSoNguoiToiDa.Text + "'," + txtPSoNguoiDangO.Text + "," + txtPTienThue.Text + ",N'" + txtPGhiChu.Text + "')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            dgvPDanhSachPhong.DataSource = DB.dataTable("select * from PHONG");
            //Thông báo đã thêm thành công
            MessageBox.Show("Thêm phòng thành công!");

            //Clear các control
            txtPMaPhong.Text = "";
            txtPTenPhong.Text = "";
            txtPMaNha.Text = "";
            txtPSoNguoiDangO.Text = "";
            grbPLoaiPhong.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);
            cmbPSoNguoiToiDa.SelectedIndex = -1;
            txtPTienThue.Text = "";
            txtPGhiChu.Text = "";

            //Đóng kết nối
            con.Close();
        }

        private void btnPXoa_Click(object sender, EventArgs e)
        {
            // Check if connection is open, otherwise open it
            if (con.State != ConnectionState.Open)
                con.Open();

            // Validate input data
            if (txtPMaPhong.Text.Trim() == "")
            {
                errorP.SetError(txtPMaPhong, "Please enter a room ID to delete");
                return;
            }

            // xác nhân xoá hay không xoá
            DialogResult result = MessageBox.Show("Bạn có muốn xoá phòng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

           
            string sql = "DELETE FROM Phong WHERE MaPhong = N'" + txtPMaPhong.Text + "'";

            // Thực thi câu lệnh để xoá
            SqlCommand cmd = new SqlCommand(sql, con);
            int rowsAffected = cmd.ExecuteNonQuery();
            dgvPDanhSachPhong.DataSource = DB.dataTable("select * from PHONG");
            // Hiển thị thông báo khi xoá thành công
            if (rowsAffected > 0)
            {
                MessageBox.Show("Xoá phòng thành công");
            }
            else
            {
                MessageBox.Show("Không thể xoá phòng");
            }
        }
    }


}

