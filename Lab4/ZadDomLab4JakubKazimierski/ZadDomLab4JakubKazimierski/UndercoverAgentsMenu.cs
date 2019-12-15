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
        //initialization interfaces for agentsUndercover and criminals
        //because of foreign key between this two tables
        //later we need to use both due to connection between those tables
        private readonly IFBIgeneric<FBIagentsUndercover> _agentsUndercover;
        private readonly IFBIgeneric<FBIcriminalsList> _criminalsUndercover;


        /// <summary>
        /// constructor
        /// </summary>
        public UndercoverAgentsMenu()
        {
            InitializeComponent();

            _agentsUndercover = new FBIgeneric<FBIagentsUndercover>();
            _criminalsUndercover = new FBIgeneric<FBIcriminalsList>();

            LoadAgents();
            LoadCriminals();
        }

        /// <summary>
        /// load criminals data on grid view
        /// </summary>
        private void LoadCriminals()
        {
            CriminalsUndercoverdataGridView.DataSource = _criminalsUndercover.GetAll();
        }
        /// <summary>
        /// load agents data on grid view
        /// </summary>
        private void LoadAgents()
        {
            UndercoverAgentsDataGridView.DataSource = _agentsUndercover.GetAll();
        }

        /// <summary>
        /// method of event of insert button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //assertion of text boxes
            if (InsertNameTextButton.Text != "" && InsertSurnameTextBox.Text != "" && InsertCriminalIdTextBox.Text != "" )
            {
                
                //variables needed to insert new data
                var agentFirstName = InsertNameTextButton.Text;
                var agentLastName = InsertSurnameTextBox.Text;
                var TypeId = InsertCriminalIdTextBox.Text;

                var selectedCriminalIndex = Int32.Parse(InsertCriminalIdTextBox.Text);
                var findCriminal = _criminalsUndercover.GetById(selectedCriminalIndex);

                //new object
                FBIagentsUndercover newAgent = new FBIagentsUndercover()
                {
                    FirstName = agentFirstName,
                    LastName = agentLastName,
                    AgentCriminalId = Int32.Parse(TypeId)
                };

                //assertion of non existing foreign key
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

            //clear text boxes
            InsertNameTextButton.Text = "";
            InsertSurnameTextBox.Text = "";
            InsertCriminalIdTextBox.Text = "";

        }

        /// <summary>
        /// event method of update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //assertion of text boxes
            if (AgentIdTextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != "")
            {
                //variables needed to update table
                var agentId = Int32.Parse(AgentIdTextBox.Text);
                var updateAgent = _agentsUndercover.GetById(agentId);

                //assertion of non existing ID
                if (updateAgent != null)
                {


                    updateAgent.FirstName = NameTextBox.Text;
                    updateAgent.LastName = SurnameTextBox.Text;


                    _agentsUndercover.Update(updateAgent);
                    _agentsUndercover.Save();



                    LoadAgents();
                    LoadCriminals();
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

            //clear text box
            AgentIdTextBox.Text = "";
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";

        }

        //event of delete button method
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //assertion of text box
            if (DeleteIdTextBox.Text != "")
            {
                var selectedAgentIndex = Int32.Parse(DeleteIdTextBox.Text);
                var deleteAgent = _agentsUndercover.GetById(selectedAgentIndex);

                //assertion of non exsting ID
                if (deleteAgent != null)
                {
                    var deleteCriminal = _criminalsUndercover.GetById(deleteAgent.AgentCriminalId);


                    _criminalsUndercover.DeleteById(deleteCriminal.Id);
                    _criminalsUndercover.Save();



                    LoadAgents();
                    LoadCriminals();
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
