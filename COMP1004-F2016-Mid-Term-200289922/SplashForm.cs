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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // if not set to false it i will keep creating splash forms every 3 seconds
            SplashFormTimer.Enabled = false;

            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();

        }
    }
}
