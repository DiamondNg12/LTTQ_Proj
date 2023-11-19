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

            dataGridViewSinhVien.DataSource = dc.dataTable("Select * from SinhVien");
        }
        public void OpenForm<Form_QlPhong>() where Form_QlPhong : FormQuanLy, new()
        {
            Form form = tabPage1.Controls.OfType<Form_QlPhong>().FirstOrDefault();
            if (form == null)
            {
                form = new Form_QLPhong();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                tabPage1.Controls.Add(form);
                tabPage1.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                Form_QlPhong form_QlPhong = new Form_QlPhong();
                form_QlPhong.TopLevel = false;
                form_QlPhong.FormBorderStyle = FormBorderStyle.None;
                form_QlPhong.Dock = DockStyle.Fill;
                tabPage1.Controls.Add(form);
                tabPage1.Tag = form;
                form_QlPhong.Show();
                form_QlPhong.BringToFront();
            }
        }
        private void buttonQLPhong_Click(object sender, EventArgs e)
        {
            // Create a new TabPage control.
            TabPage tab = new TabPage();
            tab.Text = "QL_Phong";

            // Add the Form_QlPhong form to the TabPage control.
            Form_QLPhong form_QLPhong = new Form_QLPhong();
            form_QLPhong.TopLevel = false;
            form_QLPhong.FormBorderStyle = FormBorderStyle.None;
            form_QLPhong.Dock = DockStyle.Fill;
            tab.Controls.Add(form_QLPhong);

            // Add the TabPage control to the TabControl control.
            tabControl1.TabPages.Add(tab);

            // Select the new TabPage control.
            tabControl1.SelectedTab = tab;

            // Show the Form_QLPhong form.
            form_QLPhong.Show();
            form_QLPhong.BringToFront();
        }
    }
}
