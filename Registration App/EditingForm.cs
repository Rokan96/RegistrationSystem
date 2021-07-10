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
using System.Configuration;

namespace Registration_App
{
    public partial class EditingForm : Form
    {
        
        public EditingForm()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["Sdb"].ConnectionString;

      
        private void btnSearchEditing_Click(object sender, EventArgs e)
        {

                if (txtSearchEditing.Text == "")
                {

                    MessageBox.Show("عليك ادخال الرقم التسلسلي او الاسم اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                //Clear All TextBoxes
                
                txtFullName.Text = ""; txtFatherFullName.Text = ""; txtBirthGoverCB.Text = ""; txtCurrentGover.Text = ""; txtBirthQadaa.Text = ""; txtBirthNahia.Text = ""; txtIdNumber.Text = "";
                txtIdMadeDes.Text = ""; txtNationNum.Text = ""; txtNationMadeDes.Text = ""; txtUIdNum.Text = ""; txtUIdMadeDes.Text = ""; txtSuppliesIdNum.Text = ""; txtSuppliesMadeDes.Text = "";
                txtCurrentQadaa.Text = ""; txtCurrentNahia.Text = ""; txtCurrentMahala.Text = ""; txtNationality.Text = ""; txtSuppliesMadeDate.Text = ""; txtNationMadeDate.Text = "";
                txtNationalism.Text = ""; txtReligion.Text = ""; txtZuqaq.Text = ""; txtDOB.Text = ""; txtUIdMadeDate.Text = ""; txtIdMadeDate.Text = "";
                txtHouseNum.Text = ""; txtNuqtaDala.Text = ""; txtPhoneNum.Text = "";
                txtGradSchool.Text = ""; txtSchoolLocation.Text = ""; txtHighSchoolType.Text = ""; txtCollegeAccType.Text = ""; txtMotherFullN.Text = ""; txtMotherTabaiaa.Text = ""; txtMotherNationalism.Text = "";
                txtMokhtarFN.Text = ""; txtCollegeAccYear.Text = ""; txtCollegeGradYear.Text = ""; txtKafeelFN.Text = ""; txtKafeelJob.Text = ""; txtKafeelLocation.Text = "";
            }

                else
                {
             
                    try
                    {
                  
                    using (SqlConnection sqlcon = new SqlConnection(conn))
                        {

                            if (sqlcon.State == ConnectionState.Closed)
                                sqlcon.Open();

                                 using (SqlCommand cmd = new SqlCommand("select stdFullName , stdFatherFN , stdDOB , stdBirthGover , stdBirthQadaa , stdBirthNahia , stdIdNumber , stdIdMadeDate , stdIdMadeDes , stdNationNum , stdNationMadeDate ,stdNatioMadeDes , stdUIdNum , stdUIdMadeDate , stdUIdMadeDes , stdSuppliesIdNum , stdSuppliesIdMadeDate , stdSuppliesIdMadeDes , stdNationality , stdNationalism , stdReligion , stdCurrentGover , stdCurrentQadaa , stdCurrentNahia , stdCurrentMahala , stdZuqaq , stdHouseNum , stdNuqtaDalla , stdPhoneNumber , stdGradSchool , stdSchoolLocation , stdHighSType , stdCollegeAccType , stdMotherFullName , stdMotherTabaiaa , stdMotherNationalism , stdMokhtarFullN , stdAcceptYear , stdGraduationYear , stdKafeelFullN , stdKafeelJob , stdKafeelLocation FROM StudentTbl WHERE  stdId  like '" + txtSearchEditing.Text + "' or  stdFullName like '%" + txtSearchEditing.Text+"%' "  , sqlcon))
                                {
                                  

                                using (SqlDataReader SDR = cmd.ExecuteReader())

                                {

                                while (SDR.Read())

                                {

                                    txtFullName.Text = SDR.GetValue(0).ToString();
                                    txtFatherFullName.Text = SDR.GetValue(1).ToString();
                                    txtDOB.Text = SDR.GetValue(2).ToString();
                                    txtBirthGoverCB.Text = SDR.GetValue(3).ToString();
                                    txtBirthQadaa.Text = SDR.GetValue(4).ToString();
                                    txtBirthNahia.Text = SDR.GetValue(5).ToString();
                                    txtIdNumber.Text = SDR.GetValue(6).ToString();
                                    txtIdMadeDate.Text = SDR.GetValue(7).ToString();
                                    txtIdMadeDes.Text = SDR.GetValue(8).ToString();
                                    txtNationNum.Text = SDR.GetValue(9).ToString();
                                    txtNationMadeDate.Text = SDR.GetValue(10).ToString();
                                    txtNationMadeDes.Text = SDR.GetValue(11).ToString();
                                    txtUIdNum.Text = SDR.GetValue(12).ToString();
                                    txtUIdMadeDate.Text = SDR.GetValue(13).ToString();
                                    txtUIdMadeDes.Text = SDR.GetValue(14).ToString();
                                    txtSuppliesIdNum.Text = SDR.GetValue(15).ToString();
                                    txtSuppliesMadeDate.Text = SDR.GetValue(16).ToString();
                                    txtSuppliesMadeDes.Text = SDR.GetValue(17).ToString();
                                    txtNationality.Text = SDR.GetValue(18).ToString();
                                    txtNationalism.Text = SDR.GetValue(19).ToString();
                                    txtReligion.Text = SDR.GetValue(20).ToString();
                                    txtCurrentGover.Text = SDR.GetValue(21).ToString();
                                    txtCurrentQadaa.Text = SDR.GetValue(22).ToString();
                                    txtCurrentNahia.Text = SDR.GetValue(23).ToString();
                                    txtCurrentMahala.Text = SDR.GetValue(24).ToString();
                                    txtZuqaq.Text = SDR.GetValue(25).ToString();
                                    txtHouseNum.Text = SDR.GetValue(26).ToString();
                                    txtNuqtaDala.Text = SDR.GetValue(27).ToString();
                                    txtPhoneNum.Text = SDR.GetValue(28).ToString();
                                    txtGradSchool.Text = SDR.GetValue(29).ToString();
                                    txtSchoolLocation.Text = SDR.GetValue(30).ToString();
                                    txtHighSchoolType.Text = SDR.GetValue(31).ToString();
                                    txtCollegeAccType.Text = SDR.GetValue(32).ToString();
                                    txtMotherFullN.Text = SDR.GetValue(33).ToString();
                                    txtMotherTabaiaa.Text = SDR.GetValue(34).ToString();
                                    txtMotherNationalism.Text = SDR.GetValue(35).ToString();
                                    txtMokhtarFN.Text = SDR.GetValue(36).ToString();
                                    txtCollegeAccYear.Text = SDR.GetValue(37).ToString();
                                    txtCollegeGradYear.Text = SDR.GetValue(38).ToString();
                                    txtKafeelFN.Text = SDR.GetValue(39).ToString();
                                    txtKafeelJob.Text = SDR.GetValue(40).ToString();
                                    txtKafeelLocation.Text = SDR.GetValue(41).ToString();

                                  
                                }

                                if (SDR.HasRows == false)
                                {

                                    MessageBox.Show("لا يوجد تطابق ، حاول مجددا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtSearchEditing.Text = "";
                                }

                                sqlcon.Close();
                             
                                } 

                                }
                            }
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (txtSearchEditing.Text == "")
            {

                MessageBox.Show("عليك ادخال الرقم التسلسلي اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                try
                {

                    using (SqlConnection sqlcon = new SqlConnection(conn))
                    {

                        if (sqlcon.State == ConnectionState.Closed)
                            sqlcon.Open();

                        using (SqlCommand cmd = new SqlCommand(" update StudentTbl set stdFullName ='" + txtFullName.Text + "' , stdFatherFN ='" + txtFatherFullName.Text + "' , stdDOB ='" + txtDOB.Value.ToString("yyyy-MM-dd") + "' , stdBirthGover ='" + txtBirthGoverCB.SelectedItem.ToString() + "' , stdBirthQadaa ='" + txtBirthQadaa.Text + "' , stdBirthNahia ='" + txtBirthNahia.Text + "' , stdIdNumber ='" + txtIdNumber.Text + "'  , stdIdMadeDate ='" + txtIdMadeDate.Value.ToString("yyy-MM-dd") + "'  , stdIdMadeDes ='" + txtIdMadeDes.Text + "'  , stdNationNum ='" + txtNationNum.Text + "'  , stdNationMadeDate ='" + txtNationMadeDate.Value.ToString("yyy-MM-dd") + "'  , stdNatioMadeDes ='" + txtNationMadeDes.Text + "', stdUIdNum ='" + txtUIdNum.Text + "'  , stdUIdMadeDate ='" + txtUIdMadeDate.Value.ToString("yyy-MM-dd") + "'  , stdUIdMadeDes ='" + txtUIdMadeDes.Text + "'  ,stdSuppliesIdNum ='"+ txtSuppliesIdNum.Text + "'  , stdSuppliesIdMadeDate ='" + txtSuppliesMadeDate.Value.ToString("yyy-MM-dd") + "'  , stdSuppliesIdMadeDes ='" + txtSuppliesMadeDes.Text + "'  ,stdNationality ='" + txtNationality.Text + "', stdNationalism ='" + txtNationalism.Text + "', stdReligion ='" + txtReligion.Text + "', stdCurrentGover ='" + txtCurrentGover.SelectedItem.ToString() + "'  , stdCurrentQadaa ='" + txtCurrentQadaa.Text + "'  , stdCurrentNahia ='" + txtCurrentNahia.Text + "'  , stdCurrentMahala ='" + txtCurrentMahala.Text + "'  , stdZuqaq ='" + txtZuqaq.Text + "'  , stdHouseNum ='" + txtHouseNum.Text + "'  , stdNuqtaDalla ='" + txtNuqtaDala.Text + "'  , stdPhoneNumber ='" + txtPhoneNum.Text + "'  , stdGradSchool ='" + txtGradSchool.Text + "'  , stdSchoolLocation ='" + txtSchoolLocation.Text + "'  , stdHighSType ='" + txtHighSchoolType.Text + "'  , stdCollegeAccType ='" + txtCollegeAccType.Text + "'  , stdMotherFullName ='" + txtMotherFullN.Text + "'  , stdMotherTabaiaa ='" + txtMotherTabaiaa.Text + "'  , stdMotherNationalism ='" + txtMotherNationalism.Text + "'  , stdMokhtarFullN ='" + txtMokhtarFN.Text + "' , stdAcceptYear ='" + txtCollegeAccType.Text + "' , stdGraduationYear ='" + txtCollegeGradYear.Text + "'  , stdKafeelFullN ='" + txtKafeelFN.Text + "', stdKafeelJob ='" + txtKafeelJob.Text + "'  , stdKafeelLocation ='" + txtKafeelLocation.Text + "' Where stdFullName like  '%"+txtSearchEditing.Text+ "%' or stdId like '%"+txtSearchEditing.Text+"%'; ", sqlcon))
                        {

                            cmd.ExecuteNonQuery();


                        }
                        MessageBox.Show("تم التعديل بنجاح" , "نجح التعديل",MessageBoxButtons.OK,MessageBoxIcon.None);
                        sqlcon.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (txtSearchEditing.Text == "")
            {

                MessageBox.Show("لا يوجد شيء لحذفه ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                DialogResult res = MessageBox.Show("هل انت متأكد من حذف السجل لهذا الطالب؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
                    try
                    {
                    if (res == DialogResult.Yes)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(conn))
                        {

                            if (sqlcon.State == ConnectionState.Closed)
                                sqlcon.Open();

                            using (SqlCommand cmd = new SqlCommand(" DELETE StudentTbl WHERE stdFullName = '%" + txtSearchEditing.Text + "%' OR stdId LIKE '%" + txtSearchEditing.Text + "%'; ", sqlcon))
                            {

                                cmd.ExecuteNonQuery();


                            }
                            MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.None);
                            sqlcon.Close();

                            txtFullName.Text = ""; txtFatherFullName.Text = ""; txtBirthGoverCB.Text = ""; txtCurrentGover.Text = ""; txtBirthQadaa.Text = ""; txtBirthNahia.Text = ""; txtIdNumber.Text = "";
                            txtIdMadeDes.Text = ""; txtNationNum.Text = ""; txtNationMadeDes.Text = ""; txtUIdNum.Text = ""; txtUIdMadeDes.Text = ""; txtSuppliesIdNum.Text = ""; txtSuppliesMadeDes.Text = "";
                            txtCurrentQadaa.Text = ""; txtCurrentNahia.Text = ""; txtCurrentMahala.Text = ""; txtNationality.Text = ""; txtSuppliesMadeDate.Text = ""; txtNationMadeDate.Text = "";
                            txtNationalism.Text = ""; txtReligion.Text = ""; txtZuqaq.Text = ""; txtDOB.Text = ""; txtUIdMadeDate.Text = ""; txtIdMadeDate.Text = "";
                            txtHouseNum.Text = ""; txtNuqtaDala.Text = ""; txtPhoneNum.Text = "";
                            txtGradSchool.Text = ""; txtSchoolLocation.Text = ""; txtHighSchoolType.Text = ""; txtCollegeAccType.Text = ""; txtMotherFullN.Text = ""; txtMotherTabaiaa.Text = ""; txtMotherNationalism.Text = "";
                            txtMokhtarFN.Text = ""; txtCollegeAccYear.Text = ""; txtCollegeGradYear.Text = ""; txtKafeelFN.Text = ""; txtKafeelJob.Text = ""; txtKafeelLocation.Text = "";
                            txtSearchEditing.Text = "";

                        }
                    }
                    else 
                    {
                        
                    }
                    }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    

        private void txtSearchEditing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchEditing.PerformClick();
            }
        }

        private void txtSearchEditing_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEditing.Text == "")
            {
                txtFullName.Text = ""; txtFatherFullName.Text = ""; txtBirthGoverCB.Text = ""; txtCurrentGover.Text = ""; txtBirthQadaa.Text = ""; txtBirthNahia.Text = ""; txtIdNumber.Text = "";
                txtIdMadeDes.Text = ""; txtNationNum.Text = ""; txtNationMadeDes.Text = ""; txtUIdNum.Text = ""; txtUIdMadeDes.Text = ""; txtSuppliesIdNum.Text = ""; txtSuppliesMadeDes.Text = "";
                txtCurrentQadaa.Text = ""; txtCurrentNahia.Text = ""; txtCurrentMahala.Text = ""; txtNationality.Text = ""; txtSuppliesMadeDate.Text = ""; txtNationMadeDate.Text = "";
                txtNationalism.Text = ""; txtReligion.Text = ""; txtZuqaq.Text = ""; txtDOB.Text = ""; txtUIdMadeDate.Text = ""; txtIdMadeDate.Text = "";
                txtHouseNum.Text = ""; txtNuqtaDala.Text = ""; txtPhoneNum.Text = "";
                txtGradSchool.Text = ""; txtSchoolLocation.Text = ""; txtHighSchoolType.Text = ""; txtCollegeAccType.Text = ""; txtMotherFullN.Text = ""; txtMotherTabaiaa.Text = ""; txtMotherNationalism.Text = "";
                txtMokhtarFN.Text = ""; txtCollegeAccYear.Text = ""; txtCollegeGradYear.Text = ""; txtKafeelFN.Text = ""; txtKafeelJob.Text = ""; txtKafeelLocation.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home hom = new Home();
            this.Hide();
            hom.ShowDialog();
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
    

