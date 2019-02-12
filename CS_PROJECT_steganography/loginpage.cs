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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) & String.IsNullOrEmpty(textBox2.Text))
            {
                label1.Text = "*Please Enter Username and Password";
            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text= "*Please Enter Username";
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                label1.Text = "*Please Enter Password";
            }
            else
            {
                selection newForm = new selection();
                newForm.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            homepage newForm = new homepage();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
