using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            var add = new AddStudent();
            this.Hide();
            add.ShowDialog();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SearchForm srch = new SearchForm();
            this.Hide();
            srch.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EditingForm edt = new EditingForm();
            this.Hide();
            edt.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            EditingForm edt = new EditingForm();
            this.Hide();
            edt.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var add = new AddStudent();
            this.Hide();
            add.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SearchForm srch = new SearchForm();
            this.Hide();
            srch.ShowDialog();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متأكد من الخروج", "سيتم الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login log = new Login();
                this.Hide();
                log.ShowDialog();
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متأكد من الخروج", "سيتم الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
            {
                Login log = new Login();
                this.Hide();
                log.ShowDialog();
            }
          
        }
    }
}

