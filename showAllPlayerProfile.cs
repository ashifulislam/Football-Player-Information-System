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
    public partial class showAllPlayerProfile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=Player;Integrated Security=True");
        DataTable showAllPlayer;
        public showAllPlayerProfile()
        {
            InitializeComponent();
            
        }
        private void add(DataTable showAllPlayerProfile)
        {
            dataGridViewforAllPlayerInformation.DataSource = showAllPlayerProfile;
        }

        private void dataGridViewforAllPlayerInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void receivePlayerInfoFromAdminPanel(DataTable showAllPlayer)
        {
            this.showAllPlayer = showAllPlayer;
            add(showAllPlayer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanelForm u = new UserPanelForm();
            this.Hide();
            u.Show();
        }

        private void showAllPlayerProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnForView_Click(object sender, EventArgs e)
        {
            viewForAll();
        }
        public void viewForAll()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from footballer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            dataGridViewforAllPlayerInformation.DataSource = dt;
            con.Close();
        }
    }
}
