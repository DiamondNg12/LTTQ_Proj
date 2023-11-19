using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            dataGridViewSinhVien.DataSource = dc.dataTable("Select * from SinhVien");
            DataTable ques = dc.dataTable("Select * from Que");
            foreach (DataRow que in ques.Rows)
            {
                inputSVMaQue.Items.Add($"{que["MaQue"]} - {que["TenQue"]}");
            }
        }
    }
}
