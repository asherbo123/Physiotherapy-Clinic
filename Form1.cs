using System.Drawing;

namespace Physiotherapy_Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin"
                && txtpassword.Text == "1234")
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or Password is incorrect," +
                    "Try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible = true;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}