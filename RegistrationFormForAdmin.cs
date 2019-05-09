using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballPlayerInformatio
{
    public partial class RegistrationFormForAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=registrationForm;Integrated Security=True");
        public RegistrationFormForAdmin()
        {
            InitializeComponent();
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            if(txtBoxForUserName.Text=="" || txtBoxForEmail.Text=="" || txtBoxForPassword.Text=="")
            {
                MessageBox.Show("Please fill up these mandatory feild");
            }
            else if(txtBoxForPassword.Text!=txtBoxForConfirmPassword.Text)
            {
                MessageBox.Show("Password did not match");
            }
            else if(!chkBoxForAgree.Checked)
            {
                MessageBox.Show("Please agree with terms and conditions");
            }
            else
            {
                cmd.CommandText = "insert into tblUser values('" + txtBoxForUserName.Text + "','" + txtBoxForEmail.Text + "','" + txtBoxForPassword.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxForEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxForPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxForUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInFormForAdmin l = new LogInFormForAdmin();
            this.Hide();
            l.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxForConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxForAgree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
