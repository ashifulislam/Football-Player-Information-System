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
    public partial class AdminMainPanel : Form
    {
        public AdminMainPanel()
        {
            InitializeComponent();
        }

        private void btnForPlayerProfile_Click(object sender, EventArgs e)
        {
            AddToThePlayer a = new AddToThePlayer();
            
            this.Hide();
            a.Show();
        }

        private void btnForPlayerStatistics_Click(object sender, EventArgs e)
        {
            UpdateToThePlayer u = new UpdateToThePlayer();
            this.Hide();
            u.Show();
        }

        private void btnForDelete_Click(object sender, EventArgs e)
        {
            DeletePlayerInfo d = new DeletePlayerInfo();
            this.Hide();
            d.Show();
        }

        private void btnForView_Click(object sender, EventArgs e)
        {
            ViewForThePlayer v = new ViewForThePlayer();
            this.Hide();
            v.Show();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Hide();
            m.Show();
        }
    }
}
