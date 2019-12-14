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
        private readonly IFBIgeneric<FBIcriminalsList> _criminals;

        public CriminalsMenu()
        {
            InitializeComponent();

            _criminals = new FBIgeneric<FBIcriminalsList>();

            LoadCriminals();
        }

        private void LoadCriminals()
        {
            CriminalsGridView.DataSource = _criminals.GetAll();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (InsertNameTextButton.Text != "" && InsertSurnameTextBox.Text != "" && InsertRankTextBox.Text != "" && InsertBirthTextBox.Text != "")
            {
                var criminalFirstName = InsertNameTextButton.Text;
                var criminalLastName = InsertSurnameTextBox.Text;
                var criminalBirthdate = InsertBirthTextBox.Text;
                var TypeId = InsertRankTextBox.Text;

                FBIcriminalsList newCriminal = new FBIcriminalsList()
                {
                    FirstName = criminalFirstName,
                    LastName = criminalLastName,
                    Birthdate = Convert.ToDateTime(criminalBirthdate),
                    CriminalTypeId = Int32.Parse(TypeId)
                };

                _criminals.Create(newCriminal);
                _criminals.Save();

                LoadCriminals();
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }

            InsertNameTextButton.Text = "";
            InsertSurnameTextBox.Text = "";
            InsertRankTextBox.Text = "";
            InsertBirthTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CriminalIdTextBox.Text != "" && NameTextBox.Text != "" && SurnameTextBox.Text != "" && RankTextBox.Text != "")
            {
                var criminalId = Int32.Parse(CriminalIdTextBox.Text);
                var updateCriminal = _criminals.GetById(criminalId);

                updateCriminal.FirstName = NameTextBox.Text;
                updateCriminal.LastName = SurnameTextBox.Text;
                updateCriminal.CriminalTypeId = Int32.Parse(RankTextBox.Text);

                _criminals.Update(updateCriminal);
                _criminals.Save();

                LoadCriminals();
            }
            else
            {
                MessageBox.Show("Insert All Data");
            }
            CriminalIdTextBox.Text = "";
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            RankTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteIdTextBox.Text != "")
            {
                var selectedCriminalIndex = Int32.Parse(DeleteIdTextBox.Text);
                var deleteCriminal = _criminals.GetById(selectedCriminalIndex);


                _criminals.DeleteById(deleteCriminal.Id);
                _criminals.Save();



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
