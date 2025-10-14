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
            Int32 SECOND_ITEM_INDEX = 1;
            MEComboBox.SelectedIndex = SECOND_ITEM_INDEX;
            ZSComboBox.SelectedIndex = SECOND_ITEM_INDEX;
        }

        private void OnRadioButtonCheck(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                switch (radioButton.Name)
                {
                    case "PSButton1":
                        PSTextBox.Enabled = radioButton.Checked;
                        break;
                    case "MEButton1":
                        METextBox.Enabled = radioButton.Checked;
                        break;
                    case "MEButton2":
                        MEComboBox.Enabled = radioButton.Checked;
                        break;
                    case "ZSButton1":
                        ZSTextBox.Enabled = radioButton.Checked;
                        break;
                    case "ZSButton2":
                        ZSComboBox.Enabled = radioButton.Checked;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateFormula(object sender, EventArgs e)
        {
            formula = this.CochranButton.Checked ? Formula.Cochran : Formula.Slovin;
        }
 
        private void ShouldBlockKeyPress(object sender, KeyPressEventArgs e)
        {
            String text = ((TextBox)sender).Text;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !(text.Contains('.')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
