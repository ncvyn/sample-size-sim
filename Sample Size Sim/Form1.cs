namespace Sample_Size_Sim
{
    public partial class Form1 : Form
    {
        private enum Formula { Cochran, Slovin }
        Formula formula = Formula.Cochran;

        private GridPanel gridPanel;
        private readonly Random rnd = new();
        private readonly int examplePopulation = 500;
        private readonly int exampleSample = 218;

        public Form1()
        {
            InitializeComponent();
            int SECOND_ITEM_INDEX = 1;
            MEComboBox.SelectedIndex = SECOND_ITEM_INDEX;
            ZSComboBox.SelectedIndex = SECOND_ITEM_INDEX;

            Size size = new(500, 400);
            gridPanel = new GridPanel
            {
                Location = new Point(40, 130),
                Size = size,
                MinimumSize = size,
                MaximumSize = size,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
            };

            Controls.Add(gridPanel);
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
                    case "NPButton1":
                        NPTextBox.Enabled = radioButton.Checked;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateFormula(object sender, EventArgs e)
        {
            formula = CochranButton.Checked ? Formula.Cochran : Formula.Slovin;

            ZSGroupBox.Enabled = formula == Formula.Cochran;
            NPGroupBox.Enabled = formula == Formula.Cochran;
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
        private int[] GetUniqueIndices(int maxExclusive, int count)
        {
            if (maxExclusive <= 0) throw new ArgumentOutOfRangeException(nameof(maxExclusive));
            if (count < 0 || count > maxExclusive) throw new ArgumentOutOfRangeException(nameof(count));

            int[] indices = Enumerable.Range(0, maxExclusive).ToArray();

            // Fisher–Yates shuffle
            for (int i = indices.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (indices[i], indices[j]) = (indices[j], indices[i]);
            }

            if (count == maxExclusive) return indices;
            int[] result = new int[count];
            Array.Copy(indices, result, count);
            return result;
        }

        private async void SimpleRandom(object sender, EventArgs e)
        {
            int[] unique = GetUniqueIndices(examplePopulation, exampleSample);
            await RunAnimationAsync(unique, idx =>
                {
                    gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Red);
                }, 1, true);
        }

        private async void Systematic(object sender, EventArgs e)
        {
            IEnumerable<int> evens = Enumerable.Range(0, examplePopulation).Where(i => i % 2 == 0);
            await RunAnimationAsync(evens, idx =>
                {
                    gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Red);
                }, 1, regenerateColors: true);
        }

        private async void StratifiedRandom(object sender, EventArgs e)
        {
            await RunAnimationAsync(Enumerable.Range(0, examplePopulation), idx =>
                {
                    if (idx < examplePopulation / 2)
                        gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Blue);
                    else
                        gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Green);
                },
                0, true, false);


            int[] blueUnique = GetUniqueIndices(examplePopulation / 2, exampleSample / 2);
            int[] greenUnique = GetUniqueIndices(examplePopulation / 2, exampleSample / 2);

            await RunAnimationAsync(blueUnique, idx =>
                {
                    gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Red);
                }, 1, false, false);
            await RunAnimationAsync(greenUnique.Select(x => x + 250), idx =>
                {
                    gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Red);
                }, 1, false, true);
        }

        private async void Cluster(object sender, EventArgs e)
        {
            IEnumerable<int> selection = Enumerable
                .Range(0, examplePopulation / 4)
                .Concat(Enumerable.Range(examplePopulation / 2, examplePopulation / 4));
            await RunAnimationAsync(selection, idx =>
            {
                gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Red);
            }, 1, true);
        }

        /// <summary>
        /// Generalized helper function to run an animated sequence of actions on grid cells.
        /// </summary>
        /// <param name="indices">sequence of circle indices (0..499)</param>
        /// <param name="action">what to do for each index (row/col can be computed from idx)</param>
        /// <param name="delayMs">milliseconds to sleep after each update</param>
        /// <param name="regenerateColors">if true call RegenerateColors() and initial Refresh()</param>
        /// <param name="showSelectedCells">if true call ShowSelectedCells() and final Refresh()</param>
        private async Task RunAnimationAsync(
            IEnumerable<int> indices,
            Action<int> action,
            int delayMs = 5,
            bool regenerateColors = true,
            bool showSelectedCells = true
        )
        {
            if (regenerateColors)
            {
                gridPanel.RegenerateColors();
                gridPanel.Refresh();
            }

            await Task.Delay(500); // brief pause before starting

            foreach (int idx in indices)
            {
                action(idx);

                // Invalidate only the affected cell
                int row = idx / 25;
                int col = idx % 25;
                gridPanel.InvalidateCell(row, col);

                await Task.Delay(Math.Max(0, delayMs));
            }

            if (showSelectedCells)
            {
                gridPanel.ShowSelectedCells();
                gridPanel.Refresh();
            }
        }
    }
}
