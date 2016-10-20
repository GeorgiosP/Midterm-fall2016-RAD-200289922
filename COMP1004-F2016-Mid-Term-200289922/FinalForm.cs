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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
         * I wrote a method that will take the characters stats and display 
         * them into the next boxs of the final form once its loaded 
         */
        public void CharacterStats()
        {
            StrengthTextBox.Text = Program.character.Strength.ToString();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();
            CharismaTextBox.Text = Program.character.Charisma.ToString();

            FirstNameTextBox.Text = Program.character.FirstName.ToString();
            LastNameTextBox.Text = Program.character.LastName.ToString();

            RaceTextBox.Text = Program.character.Race.ToString();

        }

        /*
         * I call the load method here and place my Character stats method inside 
         */
        private void FinalForm_Load(object sender, EventArgs e)
        {
            CharacterStats();
        }
    }
}
