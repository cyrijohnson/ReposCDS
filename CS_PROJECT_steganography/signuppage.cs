using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_PROJECT_steganography
{
    public partial class signuppage : Form
    {
        public signuppage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) | String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox5.Text) | String.IsNullOrEmpty(textBox3.Text))
            {
                label1.Text = "*Please Enter The Missing Credentials to Proceed";
            }
           /* else if (String.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "*Please Enter Username";
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                label1.Text = "*Please Enter Email";
            }
            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                label1.Text = "*Please Enter Password";
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                label1.Text = "*Please Re-enter the password";
            }*/
            else
            {
                selection newForm = new selection();
                newForm.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage newForm = new homepage();
            newForm.Show();
            this.Hide();
        }
    }
}

