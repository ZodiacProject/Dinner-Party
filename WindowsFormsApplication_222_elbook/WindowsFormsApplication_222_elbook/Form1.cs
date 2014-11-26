using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_222_elbook
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
        
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            Costlabel.Text = Cost.ToString("c");

        }

        private void numericUpDownPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
