namespace Sample_Size_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PSTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys and digits
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Disallow anything else
            e.Handled = true;
        }

        private void PSButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.PSTextBox.Enabled = this.PSButton1.Checked;
        }

        private void MEButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.METextBox.Enabled = this.MEButton1.Checked;
        }

        private void MEButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.MEComboBox.Enabled = this.MEButton2.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MEComboBox.SelectedIndex = 1;
        }

        private void METextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            String text = ((TextBox)sender).Text;

            // Allow control keys and digits...
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            // ...and a single period (.)
            if (e.KeyChar == '.' && !(text.Contains('.')))
            {
                return;
            }

            // Disallow anything else
            e.Handled = true;
        }
    }
}
