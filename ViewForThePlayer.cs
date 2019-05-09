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
    public partial class ViewForThePlayer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=Player;Integrated Security=True");
        public ViewForThePlayer()
        {
            InitializeComponent();
        }

        private void ViewForThePlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnForView_Click(object sender, EventArgs e)
        {
            displayData();
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
            dataGridForView.DataSource = dt;
            con.Close();

        }

        private void btnGoToTheMainAdminPanel_Click(object sender, EventArgs e)
        {
            AdminMainPanel a = new AdminMainPanel();
            this.Hide();
            a.Show();
        }
    }
}
