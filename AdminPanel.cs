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

namespace FootballPlayerInformatio
{
    public partial class AddToThePlayer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=Player;Integrated Security=True");
        public AddToThePlayer()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void button5_Click(object sender, EventArgs e)
        {
            UserPanelForm u = new UserPanelForm();
            u.receiveValueFromAdminPanel(table);
            
            this.Hide();
            u.Show();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            





        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
          /*  table.Columns.Add("Player Name", typeof(string));
            table.Columns.Add("Current Club", typeof(string));
            table.Columns.Add("Shirt Number", typeof(int));
            table.Columns.Add("Nick Name", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("BirthYear", typeof(long));
            table.Columns.Add("Age", typeof(string));
            table.Columns.Add("Height", typeof(string));
            table.Columns.Add("weight", typeof(string));
          */  dataGridViewAdd.DataSource = table;
            displayData();
        }
       

        private void btnForAdd_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            footballer f = new footballer();
            int birth_Year = int.Parse(txtBoxBirthYear.Text);
            int age = f.ageCalculate(birth_Year);
            var gender = "";
            var country = "";
            var current_club = "";
            if(ddlForCurrentClub.SelectedItem!=null)
            {
                current_club = current_club + ddlForCurrentClub.SelectedItem.ToString();
            }
            if (rdoButtonForMale.Checked)
            {
                gender = gender + rdoButtonForMale.Text.ToString();
            }
            if (rdoButtonForFemale.Checked)
            {
                gender = gender + rdoButtonForFemale.Text.ToString();
            }
            if (ddlCountryList.SelectedItem != null)
            {
                country = country + ddlCountryList.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select one catagory");

            }
            table.Rows.Add(txtBoxForPlayerName.Text, current_club.ToString(), txtBoxForShirtNumber.Text, txtBoxForNickName.Text, gender.ToString(), country.ToString(), birth_Year.ToString(), age.ToString(), txtBoxForHeight.Text, txtBoxForWeight.Text
               );
            dataGridViewAdd.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control crt in this.Controls)
            {
                if (crt.GetType() == typeof(TextBox))
                {
                    crt.Text = "";
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminMainPanel a = new AdminMainPanel();
            this.Hide();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string currentClub=ddlForCurrentClub.SelectedItem.ToString();
            string gender="";
            
            if (rdoButtonForMale.Checked)
            {
                gender = gender + rdoButtonForMale.Text.ToString();
            }
            if (rdoButtonForFemale.Checked)
            {
                gender = gender + rdoButtonForFemale.Text.ToString();
            }
            string countryName=ddlCountryList.SelectedItem.ToString();
            int year = int.Parse(txtBoxBirthYear.Text);
            Player p = new Player();
            int age=  p.ageCalculate(year);
            cmd.CommandText="insert into footballer values('"+ txtBoxForPlayerName.Text+"','"+ currentClub+ "','"+ txtBoxForShirtNumber.Text+"','"+ txtBoxForNickName.Text+"','"+gender+"','"+countryName+"','"+year + "','"+txtBoxForHeight.Text+"','"+txtBoxForWeight.Text+"','"+age+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Inserted successfully into database");
        }
      
        public void displayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from footballer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewAdd.DataSource = dt;


            con.Close();

        }

    }
}
