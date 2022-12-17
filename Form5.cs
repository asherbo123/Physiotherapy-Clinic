using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physiotherapy_Clinic
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string photopath;
        byte[] binaryphoto;

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg|Jpegs|*.Jpegs|png|*.png|GIf|*.Gif|Bitmaps|*.Bitmaps";
            file.Title = "Please Select an Image";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Action<Control.ControlCollection> func = null;
            //func = (controls) =>
            //{
            //    foreach (Control control in controls)
            //    {
            //        if (control is TextBox)
            //        {
            //            (control as TextBox).Clear();
            //        }
            //        else
            //        {
            //            func(control.Controls);
            //        }
            //    }
            //};
            //func(Controls);
            txtname.Clear();
            txtid.Clear();
            txtnationalid.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            combGender.Text = String.Empty;
            combSection.Text = String.Empty;
            MessageBox.Show("Clear!");
            txtPName.Clear();
            txtPContact.Clear();
            txtname.Focus();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
