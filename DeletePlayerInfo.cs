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
    public partial class DeletePlayerInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=Player;Integrated Security=True");
        public DeletePlayerInfo()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnForDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Delete from footballer";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
           
            MessageBox.Show("Successfully all information deleted");
        }
        public void displayData()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from footballer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            dataGridViewDelete.DataSource = dt;
            con.Close();
        }

        private void DeletePlayerInfo_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnGoToTheMainAdminPanel_Click(object sender, EventArgs e)
        {
            AdminMainPanel a = new AdminMainPanel();
            this.Hide();
            a.Show();
        }
    }
}
