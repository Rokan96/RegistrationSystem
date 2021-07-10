using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Registration_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["Sdb"].ConnectionString;


        private void btnLogIn_Click(object sender, EventArgs e)
        {


            if (txtUserName.Text == "" && txtPassword.Text != "")
            {
                MessageBox.Show("ادخل اسم المستخدم اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblInvalid.Text = "";
            }
            else if (txtPassword.Text == "" && txtUserName.Text != "")
            {
                MessageBox.Show("ادخل كلمة المرور اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblInvalid.Text = "";
            }

            else if (txtPassword.Text == "" && txtUserName.Text == "")
            {
                MessageBox.Show("ادخل اسم المستخدم و كلمة المرور اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblInvalid.Text = "";
            }
            else
            {
                string conn = ConfigurationManager.ConnectionStrings["Sdb"].ConnectionString;
                using (SqlConnection sqlcon = new SqlConnection(conn))
                {

                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    using (DataTable dt = new DataTable("LoginTbl"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT *FROM loginTbl WHERE username = '" + txtUserName.Text.Trim() + "' AND password = '" + txtPassword.Text.Trim() + "' ", sqlcon))
                        {

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            if (dt.Rows.Count == 1)
                            {
                                Home hom = new Home();
                                this.Hide();
                                hom.ShowDialog();
                            }
                            else
                            {
                                lblInvalid.Text = "اسم المستخدم او كلمة المرور خاطئة";
                            }
                        }
                    }

                }

            }
        }
            
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            lblInvalid.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblInvalid.Text = "";
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblInvalid.Text = "";
           
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogIn.PerformClick();
                
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}
