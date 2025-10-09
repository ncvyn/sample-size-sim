using System;
using System.Windows.Forms;

namespace Sample_Size_Sim
{
    public partial class Form1 : Form
    {
        private enum Formula { Cochran, Slovin }
        Formula formula = Formula.Cochran;

        public Form1()
        {
            InitializeComponent();
            MEComboBox.SelectedIndex = 1;
        }

        private static bool ShouldBlockKeyPress(object sender, KeyPressEventArgs e)
        {
            String text = ((TextBox)sender).Text;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return false;
            }
            if (e.KeyChar == '.' && !(text.Contains('.')))
            {
                return false;
            }

            return true;
        }

        private void PSTextBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = ShouldBlockKeyPress(sender, e);

        private void PSButton1_CheckedChanged(object sender, EventArgs e) => PSTextBox.Enabled = PSButton1.Checked;
        private void MEButton1_CheckedChanged(object sender, EventArgs e) => METextBox.Enabled = MEButton1.Checked;
        private void MEButton2_CheckedChanged(object sender, EventArgs e) => MEComboBox.Enabled = MEButton2.Checked;
        
        private void METextBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = ShouldBlockKeyPress(sender, e);

        private void SetFormula(Formula option)
        {
            formula = option;
        }

        private void SlovinButton_CheckedChanged(object sender, EventArgs e)
        {
            Formula f = this.SlovinButton.Checked ? Formula.Slovin : Formula.Cochran;
            SetFormula(f);
        }

        private void CochranButton_CheckedChanged(object sender, EventArgs e)
        {
            Formula f = this.CochranButton.Checked ? Formula.Cochran : Formula.Slovin;
            SetFormula(f);
        }
    }
}
