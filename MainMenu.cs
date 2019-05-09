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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnUser(object sender, EventArgs e)
        {
            UserPanelForm u = new UserPanelForm();
            this.Hide();
            u.Show();
        }

        private void btnAdmin1(object sender, EventArgs e)
        {
            RegistrationFormForAdmin r = new RegistrationFormForAdmin();
            this.Hide();
            r.Show();
        }
    }
}
