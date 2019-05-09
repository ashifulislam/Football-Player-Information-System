using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballPlayerInformatio
{
    public partial class UserPanelForm : Form
    {
        DataTable table;

        public UserPanelForm()
        {
           
            InitializeComponent();
            
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void receiveValueFromAdminPanel(DataTable t)
        {
            table = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void btnForPlayerProfile_Click(object sender, EventArgs e)
        {
            showAllPlayerProfile s = new showAllPlayerProfile();
            s.receivePlayerInfoFromAdminPanel(table);
            this.Hide();
            s.Show();
        }

        private void btnForSearch_Click(object sender, EventArgs e)
        {
            SearchForIndividual s = new SearchForIndividual();
            this.Hide();
            s.Show();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Hide();
            m.Show();
        }
    }
}
