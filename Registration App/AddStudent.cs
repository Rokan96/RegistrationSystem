using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Registration_App
{
	public partial class AddStudent : Form
	{
		List<Panel> listPanel = new List<Panel>();
		int index = 0;
		public AddStudent()
		{
			InitializeComponent();

		}
		

		SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=RegistrationDB;Integrated Security=True");
		
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Home hom = new Home();
			this.Hide();
			hom.ShowDialog();
		}


		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (index > 0)
			{
				listPanel[--index].BringToFront();
			
			}
			else
			{
				this.Hide();
				Home hom = new Home();
				hom.ShowDialog();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{

			if (index < listPanel.Count - 1)
			{
				listPanel[++index].BringToFront();
				
			}
		


		}

		private void AddStudent_Load(object sender, EventArgs e)
		{
			listPanel.Add(panel1);
			listPanel.Add(panel2);
			listPanel.Add(panel3);
			listPanel[index].BringToFront();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			if (txtfullName.Text == "" || txtFatherFN.Text == "" || txtBirthQadaa.Text == "" || txtBirthNahia.Text == "" || txtIdNumber.Text == "" ||
				   txtIdMadeDes.Text == "" || txtNationNum.Text == "" || txtNationMadeDes.Text == "" || txtUIdNum.Text == "" || txtUIdMadeDes.Text == "" ||
					txtSuppliesIdNum.Text == ""  || txtSuppliesMadeDes.Text == "" || txtCurrentQadaa.Text == "" || txtCurrentNahia.Text == "" ||
					 txtCurrentMahala.Text == "" || txtNationality.Text == "" || txtNationalism.Text == "" || txtReligion.Text == "" || txtZuqaq.Text == "" || txtHouseNum.Text == "" || txtNuqtaDalla.Text == "" || txtPhoneNum.Text == "" ||
					  txtGradSchool.Text == "" || txtSchoolLocation.Text == "" || txtHighSchoolType.Text == "" || txtCollegeAccType.Text == "" || txtMotherFullN.Text == "" || txtMotherTabaiaa.Text == "" || txtMotherNationalism.Text == "" ||
					   txtMokhtarFullN.Text == "" || txtAcceptYear.Text == "" || txtGraduationYear.Text == "" || txtKafeelFullN.Text == "" || txtKafeeljob.Text == "" || txtKafeelLocation.Text == "")

			{
				
				MessageBox.Show("اكمل جميع الحقول اولا", "خطأ" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);

			}

			else 
			{
				
				try
				{
					Conn.Open();

					string query = " INSERT into StudentTbl VALUES('" + txtfullName.Text + "' ,'" + txtFatherFN.Text + "' , '" + txtDOB.Value.ToString("yyyy-MM-dd") + "' , '" + txtBirthGoverCB.SelectedItem.ToString() + "' , '" + txtBirthQadaa.Text + "' , '" + txtBirthNahia.Text + "' , '" + txtIdNumber.Text + "'  , '" + txtIdMadeDate.Value.ToString("yyy-MM-dd") + "'  , '" + txtIdMadeDes.Text + "'  , '" + txtNationNum.Text + "'  , '" + txtNationMadeDate.Value.ToString("yyy-MM-dd") + "'  , '" + txtNationMadeDes.Text + "','" + txtUIdNum.Text + "'  , '" + txtUIdMadeDate.Value.ToString("yyy-MM-dd") + "'  , '" + txtUIdMadeDes.Text + "'  , '" + txtSuppliesIdNum.Text + "'  , '" + txtSuppliesIdMadeDate.Value.ToString("yyy-MM-dd") + "'  , '" + txtSuppliesMadeDes.Text + "'  ,'"+txtNationality.Text+"', '"+txtNationalism.Text+"', '"+txtReligion.Text+"','"+ txtCurrentGover.SelectedItem.ToString() + "'  , '" + txtCurrentQadaa.Text + "'  , '" + txtCurrentNahia.Text + "'  , '" + txtCurrentMahala.Text + "'  , '" + txtZuqaq.Text + "'  , '" + txtHouseNum.Text + "'  , '" + txtNuqtaDalla.Text + "'  , '" + txtPhoneNum.Text + "'  , '" + txtGradSchool.Text + "'  , '" + txtSchoolLocation.Text + "'  , '" + txtHighSchoolType.Text + "'  , '" + txtCollegeAccType.Text + "'  , '" + txtMotherFullN.Text + "'  , '" + txtMotherTabaiaa.Text + "'  , '" + txtMotherNationalism.Text + "'  , '" + txtMokhtarFullN.Text + "' , '" + txtAcceptYear.Text + "' , '" + txtGraduationYear.Text + "'  , '" + txtKafeelFullN.Text + "', '" + txtKafeeljob.Text + "'  , '" + txtKafeelLocation.Text + "')";

					SqlCommand cmd = new SqlCommand(query, Conn);
					
						
				
						cmd.ExecuteNonQuery();

						MessageBox.Show("تمت الاضافة بنجاح","",MessageBoxButtons.OK);

						Conn.Close();
				
					}
				

				catch (Exception Ex)
				{

					MessageBox.Show(Ex.Message);

				}
				txtfullName.Text = ""; txtFatherFN.Text = ""; txtBirthQadaa.Text = ""; txtBirthNahia.Text = "";  txtIdNumber.Text = "";
				txtIdMadeDes.Text = ""; txtNationNum.Text = "";txtNationMadeDes.Text = ""; txtUIdNum.Text = ""; txtUIdMadeDes.Text = "";txtSuppliesIdNum.Text = "";  txtSuppliesMadeDes.Text = "";  
				txtCurrentQadaa.Text = ""; txtCurrentNahia.Text = "";txtCurrentMahala.Text = "";  txtNationality.Text = ""; 
				txtNationalism.Text = "";  txtReligion.Text = ""; txtZuqaq.Text = "";
				txtHouseNum.Text =""; txtNuqtaDalla.Text = ""; txtPhoneNum.Text = ""; 
				txtGradSchool.Text = "";  txtSchoolLocation.Text = "";txtHighSchoolType.Text = ""; txtCollegeAccType.Text = "";txtMotherFullN.Text =""; txtMotherTabaiaa.Text = "";  txtMotherNationalism.Text = "";
				txtMokhtarFullN.Text =""; txtAcceptYear.Text = ""; txtGraduationYear.Text = ""; txtKafeelFullN.Text = ""; txtKafeeljob.Text = "";  txtKafeelLocation.Text =""; 

			}

		}

        private void label7_Click(object sender, EventArgs e)
        {
			Home hom = new Home();
			this.Hide();
			hom.ShowDialog();
		}
    }
}



	

