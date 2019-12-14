using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadDomLab4JakubKazimierski
{
    public partial class MainMenu : Form
    {

        AgentsMenu agentsMenu;
        CriminalsMenu criminalsMenu;
        UndercoverAgentsMenu undercoverAgentsMenu;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void AgentListButton_Click(object sender, EventArgs e)
        {
            agentsMenu = new AgentsMenu();
            agentsMenu.Show();
        }

        private void CriminalsButton_Click(object sender, EventArgs e)
        {
            criminalsMenu = new CriminalsMenu();
            criminalsMenu.Show();
        }

        private void UndercoverAgentsButton_Click(object sender, EventArgs e)
        {
            undercoverAgentsMenu = new UndercoverAgentsMenu();
            undercoverAgentsMenu.Show();

        }
    }
}
