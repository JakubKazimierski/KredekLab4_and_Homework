using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadDomLab4JakubKazimierski.Models;
using ZadDomLab4JakubKazimierski.Repositories;

namespace ZadDomLab4JakubKazimierski
{
    public partial class AgentsMenu : Form
    {
        private readonly IFBIgeneric<FBIagentsList> _agents;
        private readonly IFBIgeneric<FBIagentsType> _agentsType;
        public AgentsMenu()
        {
            InitializeComponent();

            _agents = new FBIgeneric<FBIagentsList>();
            _agentsType = new FBIgeneric<FBIagentsType>();

            LoadAgents();
        }

        private void  LoadAgents()
        {
            AgentsDataGridView.DataSource = _agents.GetAll();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            var agentFirstName = InsertNameTextButton.Text;
            var agentLastName = InsertSurnameTextBox.Text;
            var agentBirthdate = InsertBirthTextBox.Text;
            var TypeId = InsertRankTextBox.Text;

            FBIagentsList newAgent = new FBIagentsList()
            {
                FirstName = agentFirstName,
                LastName = agentLastName,
                Birthdate = Convert.ToDateTime(agentBirthdate),
                AgentTypeId = Int32.Parse(TypeId)
            };

            _agents.Create(newAgent);
            _agents.Save();

            LoadAgents();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (AgentIdTextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != "" && RankTextBox.Text != "")
            {
                var agentId = Int32.Parse(AgentIdTextBox.Text);
                var updateAgent = _agents.GetById(agentId);

                updateAgent.FirstName = NameTextBox.Text;
                updateAgent.LastName = SurnameTextBox.Text;
                updateAgent.AgentTypeId = Int32.Parse(RankTextBox.Text);

                _agents.Update(updateAgent);
                _agents.Save();

                LoadAgents();
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedAgentIndex = Int32.Parse(DeleteIdTextBox.Text);
            var deleteAgent = _agents.GetById(selectedAgentIndex);


            _agents.DeleteById(deleteAgent.Id);
            _agents.Save();



            LoadAgents();
        }
    }
}
