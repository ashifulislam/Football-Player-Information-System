using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FootballPlayerInformatio
{
    public partial class UpdateToThePlayer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=Player;Integrated Security=True");
        public UpdateToThePlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminMainPanel a = new AdminMainPanel();
            this.Hide();
            a.Show();
        }

        private void btnForSaveIntoDatabase_Click(object sender, EventArgs e)
        {
          
        }
        public void displayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from footballer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            dataGridViewUpdate.DataSource = dt;
            con.Close();

        }

        private void UpdateToThePlayer_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnForUpdateAndSave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string currentClub = ddlForCurrentClub.SelectedItem.ToString();
            string gender = "";
            if(rdoButtonForMale.Checked)
            {
                gender = gender + rdoButtonForMale.Text.ToString();
            }
            if(rdoButtonForFemale.Checked)
            {
                gender = gender + rdoButtonForFemale.Text.ToString();
            }
            string countryName = ddlCountryList.SelectedItem.ToString();
            int year = int.Parse(txtBoxBirthYear.Text);
            Player p = new Player();
          int age=  p.ageCalculate(year);
            //  cmd.CommandText = "insert into footballer values('" + txtBoxForPlayerName.Text + "','" + currentClub + "','" + txtBoxForShirtNumber.Text + "','" + txtBoxForNickName.Text + "','" + gender + "','" + countryName + "','" + year + "','" + txtBoxForHeight.Text + "','" + txtBoxForWeight.Text + "','" + age + "')";

            cmd.CommandText = "update footballer set playerName='" + txtBoxForPlayerName.Text + "',currentClub='"+currentClub+"',shirtNumber='"+txtBoxForShirtNumber.Text+"',NickName='"+txtBoxForNickName.Text+"',Gender='"+gender+"',CountryName='"+countryName+"',BirthYear='"+year+"',Height='"+txtBoxForHeight.Text+"',Weight='"+txtBoxForWeight.Text+"',Age='"+age+"'where Player_Id='" +2+ "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Updated successfully");
        }
    }
}
