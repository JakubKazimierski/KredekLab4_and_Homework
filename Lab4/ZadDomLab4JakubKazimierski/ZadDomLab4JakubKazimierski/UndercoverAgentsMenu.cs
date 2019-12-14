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
    public partial class UndercoverAgentsMenu : Form
    {
        private readonly IFBIgeneric<FBIagentsUndercover> _agentsUndercover;
        private readonly IFBIgeneric<FBIcriminalsList> _criminalsUndercover;


        public UndercoverAgentsMenu()
        {
            InitializeComponent();

            _agentsUndercover = new FBIgeneric<FBIagentsUndercover>();
            _criminalsUndercover = new FBIgeneric<FBIcriminalsList>();

            LoadAgents();
            LoadCriminals();
        }

        private void LoadCriminals()
        {
            CriminalsUndercoverdataGridView.DataSource = _criminalsUndercover.GetAll();
        }
        private void LoadAgents()
        {
            UndercoverAgentsDataGridView.DataSource = _agentsUndercover.GetAll();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (InsertNameTextButton.Text != "" && InsertSurnameTextBox.Text != "" && InsertCriminalIdTextBox.Text != "" )
            {
                
                
                var agentFirstName = InsertNameTextButton.Text;
                var agentLastName = InsertSurnameTextBox.Text;
                var TypeId = InsertCriminalIdTextBox.Text;

                var selectedCriminalIndex = Int32.Parse(InsertCriminalIdTextBox.Text);
                var findCriminal = _criminalsUndercover.GetById(selectedCriminalIndex);


                FBIagentsUndercover newAgent = new FBIagentsUndercover()
                {
                    FirstName = agentFirstName,
                    LastName = agentLastName,
                    AgentCriminalId = Int32.Parse(TypeId)
                };


                if (findCriminal != null)
                {
                    _agentsUndercover.Create(newAgent);
                    _agentsUndercover.Save();

                    LoadAgents();
                    LoadCriminals();

                }                                    
                else
                {
                    MessageBox.Show("Criminal ID doesn't exist in data Base. Make sure to input proper data");
                }

              
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }

            InsertNameTextButton.Text = "";
            InsertSurnameTextBox.Text = "";
            InsertCriminalIdTextBox.Text = "";

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (AgentIdTextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != "")
            {
                var agentId = Int32.Parse(AgentIdTextBox.Text);
                var updateAgent = _agentsUndercover.GetById(agentId);

                var updateCriminal = _criminalsUndercover.GetById(updateAgent.AgentCriminalId);

                updateCriminal.FirstName = NameTextBox.Text;
                updateCriminal.LastName = SurnameTextBox.Text;


                updateAgent.FirstName = NameTextBox.Text;
                updateAgent.LastName = SurnameTextBox.Text;
 

                _agentsUndercover.Update(updateAgent);
                _agentsUndercover.Save();

                _criminalsUndercover.Update(updateCriminal);
                _criminalsUndercover.Save();

                LoadAgents();
                LoadCriminals();
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }

            AgentIdTextBox.Text = "";
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteIdTextBox.Text != "")
            {
                var selectedAgentIndex = Int32.Parse(DeleteIdTextBox.Text);
                var deleteAgent = _agentsUndercover.GetById(selectedAgentIndex);


                var deleteCriminal = _criminalsUndercover.GetById(deleteAgent.AgentCriminalId);

                _criminalsUndercover.DeleteById(deleteCriminal.Id);
                _criminalsUndercover.Save();



                LoadAgents();
                LoadCriminals();
            }
            else
            {
                MessageBox.Show("Insert ID");
            }

            DeleteIdTextBox.Text = "";
        }
    }
}
