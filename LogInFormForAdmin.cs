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
    public partial class LogInFormForAdmin : Form
    {
        public LogInFormForAdmin()
        {
            InitializeComponent();
        }

        private void btnForLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQPR1LD\\ASHIFULSQL;Initial Catalog=registrationForm;Integrated Security=True");
            string query = "select * from tblUser where UserName='" + txtBoxForUserName.Text.Trim() + "'and Password='" + txtBoxForPassword.Text.Trim() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                AdminMainPanel a = new AdminMainPanel();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
