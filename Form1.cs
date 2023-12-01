namespace LTTQ_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = System.Drawing.Color.LightPink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLoginSubmit_Click(object sender, EventArgs e)
        {
            string username = inputLoginUsername.Text;
            string password = inputLoginPassword.Text;
            if (username == "admin" && password == "nhom15")
            {
                var form_quan_ly = new FormQuanLy();
                this.Hide();
                form_quan_ly.Show();
            }
        }
    }
}