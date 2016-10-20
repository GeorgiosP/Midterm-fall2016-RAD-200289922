using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200289922
{
    public partial class GenerateNameForm : Form
    {

        // private Instance Object

        private Random _random;
        private string _firstName;
        private string _lastName;
        public AbilityGeneratorForm previousForm;

        
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        private Int32 Roll()
        {
            
         
            int generatedNumber = this._random.Next(FirstNameListBox.Items.Count);


            return generatedNumber;
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = FirstNameListBox.Items[Roll()].ToString();
            LastNameTextBox.Text = LastNameListBox.Items[Roll()].ToString();





        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();

        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this._random = new Random();
        }
    }
}
