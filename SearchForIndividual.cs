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
    public partial class SearchForIndividual : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=Player;Integrated Security=True");
        public SearchForIndividual()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from footballer where playerName='" + txtBoxForPlayerName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            dataGridViewforSearch.DataSource = dt;
            ad.Fill(dt);
            con.Close();
            
        }
        public void searchByClubName()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            string current_club = ddlForCurrentClub.SelectedItem.ToString();
            cmd.CommandText = "select * from footballer where CurrentClub='" + current_club + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            dataGridViewforSearch.DataSource = dt;
            ad.Fill(dt);
            con.Close();

        }
        private void btnBackUserPanel(object sender, EventArgs e)
        {
            UserPanelForm u = new UserPanelForm();
            this.Hide();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchByClubName();
        }
    }
}
