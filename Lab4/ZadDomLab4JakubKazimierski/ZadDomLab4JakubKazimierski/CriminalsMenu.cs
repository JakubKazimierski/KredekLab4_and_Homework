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
    public partial class CriminalsMenu : Form
    {
        //initialization of interface criminals
        private readonly IFBIgeneric<FBIcriminalsList> _criminals;

        /// <summary>
        /// constructor
        /// </summary>
        public CriminalsMenu()
        {
            InitializeComponent();

            _criminals = new FBIgeneric<FBIcriminalsList>();

            LoadCriminals();
        }

        //load data from database to grid view
        private void LoadCriminals()
        {
            CriminalsGridView.DataSource = _criminals.GetAll();
        }

        /// <summary>
        /// event method of insert button
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
                    //variables needed to insert new criminal 
                    var criminalFirstName = InsertNameTextButton.Text;
                    var criminalLastName = InsertSurnameTextBox.Text;
                    var criminalBirthdate = InsertBirthTextBox.Text;
                    var TypeId = InsertRankTextBox.Text;
              

                    //new object
                    FBIcriminalsList newCriminal = new FBIcriminalsList()
                    {
                        FirstName = criminalFirstName,
                        LastName = criminalLastName,
                        Birthdate = Convert.ToDateTime(criminalBirthdate),
                        CriminalTypeId = Int32.Parse(TypeId)
                    };

                    //add new element to data base
                    _criminals.Create(newCriminal);
                    _criminals.Save();

                    LoadCriminals();
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
        /// event method of update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //assertion of text boxes
            if (CriminalIdTextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != "" && RankTextBox.Text != "" )
            {
                //variables needed to update criminal
                var criminalId = Int32.Parse(CriminalIdTextBox.Text);
                var updateCriminal = _criminals.GetById(criminalId);

                //assertion of non existing key
                if (updateCriminal != null)
                {
                    if (Int32.Parse(RankTextBox.Text) <= 3)
                    {
                        updateCriminal.FirstName = NameTextBox.Text;
                        updateCriminal.LastName = SurnameTextBox.Text;
                        updateCriminal.CriminalTypeId = Int32.Parse(RankTextBox.Text);

                        //add criminal to data base
                        _criminals.Update(updateCriminal);
                        _criminals.Save();

                        LoadCriminals();
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

            //clear text boxes
            CriminalIdTextBox.Text = "";
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
            //assertion of text box
            if (DeleteIdTextBox.Text != "")
            {
                //variables needed to delete criminal
                var selectedCriminalIndex = Int32.Parse(DeleteIdTextBox.Text);
                var deleteCriminal = _criminals.GetById(selectedCriminalIndex);

                //asssertion of index
                if (deleteCriminal != null)
                {
                    //delete criminal
                    _criminals.DeleteById(deleteCriminal.Id);
                    _criminals.Save();



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
