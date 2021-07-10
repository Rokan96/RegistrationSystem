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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {

                disp_data();
                MessageBox.Show("ادخل التسلسل او الاسم اولا", "فارغ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }

            else
            {

                try
                {


                    string conn = ConfigurationManager.ConnectionStrings["Sdb"].ConnectionString;
                    using (SqlConnection sqlcon = new SqlConnection(conn))
                    {

                        if (sqlcon.State == ConnectionState.Closed)
                            sqlcon.Open();
                        using (DataTable dt = new DataTable("StudentTbl"))
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT *FROM StudentTbl where stdId like '" + txtSearch.Text + "' or stdFullName like '%" + txtSearch.Text + "%' ", sqlcon))
                            {

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                dgv.DataSource = dt;
                                if (dt.Rows.Count == 0)
                                {

                                    MessageBox.Show("لا يوجد تطابق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtSearch.Text = "";
                                
                                }
                            }
                        }
                       
                    }

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        public void disp_data()
        {
            string conn = ConfigurationManager.ConnectionStrings["Sdb"].ConnectionString;
            using (SqlConnection sqlcon = new SqlConnection(conn))
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                using (DataTable dt = new DataTable("StudentTbl"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT *FROM StudentTbl ", sqlcon))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dgv.DataSource = dt;

                    }
                }
            }
        }


            private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)13)
                {
                    btnSearch.PerformClick();
                }
            }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
                disp_data();
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                disp_data();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hom = new Home();
            this.Hide();
            hom.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home hom = new Home();
            this.Hide();
            hom.ShowDialog();
            
        }
    }
    } 
