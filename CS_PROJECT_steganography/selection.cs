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
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fileInImage newForm = new fileInImage();
            newForm.ShowDialog();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            homepage newForm = new homepage();
            newForm.ShowDialog();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            homepage newForm = new homepage();
            newForm.ShowDialog();
            this.Hide();
        }
    }
}
