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
        /// <summary>
        /// Initialization of agents table interface
        /// </summary>
        private readonly IFBIgeneric<FBIagentsList> _agents;
      
        /// <summary>
        /// constructor
        /// </summary>
        public AgentsMenu()
        {
            InitializeComponent();

            _agents = new FBIgeneric<FBIagentsList>();
            

            LoadAgents();
        }

        /// <summary>
        /// method to view agents on data gird
        /// </summary>
        private void  LoadAgents()
        {
            AgentsDataGridView.DataSource = _agents.GetAll();
        }

        /// <summary>
        /// event method of button Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //assertion of text boxes
            if (InsertNameTextButton.Text != "" && InsertSurnameTextBox.Text != "" && InsertRankTextBox.Text != "" && InsertBirthTextBox.Text != "")
            {
                if (Int32.Parse(RankTextBox.Text) <= 3)
                {
                    //variables of agent attributes
                    var agentFirstName = InsertNameTextButton.Text;
                    var agentLastName = InsertSurnameTextBox.Text;
                    var agentBirthdate = InsertBirthTextBox.Text;
                    var TypeId = InsertRankTextBox.Text;

                    //new object
                    FBIagentsList newAgent = new FBIagentsList()
                    {
                        FirstName = agentFirstName,
                        LastName = agentLastName,
                        Birthdate = Convert.ToDateTime(agentBirthdate),
                        AgentTypeId = Int32.Parse(TypeId)
                    };

                    //insert new agent to data base
                    _agents.Create(newAgent);
                    _agents.Save();

                    LoadAgents();
                }
                else
                {
                    MessageBox.Show("Insert proper Rank");
                }
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }

            //clear text boxes
            InsertNameTextButton.Text = "";
            InsertSurnameTextBox.Text = "";
            InsertRankTextBox.Text = "";
            InsertBirthTextBox.Text = "";

        }

        /// <summary>
        /// method of event of update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //assertion of text boxes
            if (AgentIdTextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != "" && RankTextBox.Text != "")
            {
                //variabble needed to update table
                var agentId = Int32.Parse(AgentIdTextBox.Text);
                var updateAgent = _agents.GetById(agentId);

                if (updateAgent != null)
                {
                    if (Int32.Parse(RankTextBox.Text) <= 3)
                    {
                        updateAgent.FirstName = NameTextBox.Text;
                        updateAgent.LastName = SurnameTextBox.Text;
                        updateAgent.AgentTypeId = Int32.Parse(RankTextBox.Text);

                        _agents.Update(updateAgent);
                        _agents.Save();

                        LoadAgents();
                    }
                    else
                    {
                        MessageBox.Show("Insert proper Rank");
                    }
                }
                else
                {
                    MessageBox.Show("Insert proper ID");
                }
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }

            //clearing text boxes
            AgentIdTextBox.Text = "";
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            RankTextBox.Text = "";
        }

        /// <summary>
        /// event method of delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //assertion text box
            if (DeleteIdTextBox.Text != "")
            {
                //variables needed to delete agentfrom table
                var selectedAgentIndex = Int32.Parse(DeleteIdTextBox.Text);
                var deleteAgent = _agents.GetById(selectedAgentIndex);

                //assertio n of index
                if (deleteAgent != null)
                {
                    //delete agent
                    _agents.DeleteById(deleteAgent.Id);
                    _agents.Save();




                    LoadAgents();
                }
                else
                {
                    MessageBox.Show("Insert proper ID");
                }
            }
            else
            {
                MessageBox.Show("Insert ID");
            }
            //clear text box
            DeleteIdTextBox.Text = "";
        }
    }
}
