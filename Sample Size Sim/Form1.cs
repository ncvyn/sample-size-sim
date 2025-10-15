namespace Sample_Size_Sim
{
    public partial class Form1 : Form
    {
        private enum Formula { Cochran, Slovin }
        Formula formula = Formula.Cochran;

        private GridPanel gridPanel;
        private readonly Random rng = new();
        private readonly int examplePopulation = 500;
        private readonly int exampleSample = 218;

        public Form1()
        {
            InitializeComponent();

            int SECOND_ITEM_INDEX = 1;
            MEComboBox.SelectedIndex = SECOND_ITEM_INDEX;
            ZSComboBox.SelectedIndex = SECOND_ITEM_INDEX;

            UpdateDescription();

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
                int j = rng.Next(i + 1);
                (indices[i], indices[j]) = (indices[j], indices[i]);
            }

            if (count == maxExclusive) return indices;
            int[] result = new int[count];
            Array.Copy(indices, result, count);
            return result;
        }

        private async void SimpleRandom()
        {
            int[] unique = GetUniqueIndices(examplePopulation, exampleSample);
            await RunAnimationAsync(unique, idx =>
                {
                    gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
                }, 1, true);
        }

        private async void Systematic()
        {
            IEnumerable<int> evens = Enumerable.Range(0, examplePopulation).Where(i => i % 2 == 0);
            await RunAnimationAsync(evens, idx =>
                {
                    gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
                }, 1, regenerateColors: true);
        }

        private async void StratifiedRandom()
        {
            await RunAnimationAsync(Enumerable.Range(0, examplePopulation), idx =>
                {
                    if (idx < examplePopulation / 2)
                        gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Blue);
                    else
                        gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.Green);
                },
                0, true, false);


            int[] blueUnique = GetUniqueIndices(examplePopulation / 2, exampleSample / 2);
            int[] greenUnique = GetUniqueIndices(examplePopulation / 2, exampleSample / 2);

            await RunAnimationAsync(blueUnique, idx =>
                {
                    gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
                }, 1, false, false);
            await RunAnimationAsync(greenUnique.Select(x => x + 250), idx =>
                {
                    gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
                }, 1, false, true);
        }

        private async void Cluster()
        {
            IEnumerable<int> selection = Enumerable
                .Range(0, examplePopulation / 4)
                .Concat(Enumerable.Range(examplePopulation / 2, examplePopulation / 4));
            await RunAnimationAsync(selection, idx =>
            {
                gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
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

            PlayButton.Enabled = true;
        }

        private void SSButton_Click(object sender, EventArgs e)
        {
            if (formula == Formula.Cochran)
            {
                double sampleSize;

                int n = PSButton1.Checked
                    ? int.Parse(PSTextBox.Text)
                    : 0;
                double me = MEButton1.Checked
                    ? double.Parse(METextBox.Text) / 100
                    : double.Parse(MEComboBox.SelectedItem?.ToString()!.TrimEnd('%')!) / 100;
                double zs = ZSButton1.Checked
                    ? double.Parse(ZSTextBox.Text)
                    : double.Parse(ZSComboBox.SelectedItem?.ToString()!);
                double np = NPButton1.Checked
                    ? double.Parse(NPTextBox.Text)
                    : 0.5;

                sampleSize = zs * zs * np * (1 - np) / (me * me);

                if (n > 0)
                    sampleSize = sampleSize / (1 + (sampleSize - 1) / n);

                SSTextBox.Text = sampleSize.ToString("0");
            }
            else // Slovin
            {
                double sampleSize;

                int n = PSButton1.Checked
                    ? int.Parse(PSTextBox.Text)
                    : 0;
                double me = MEButton1.Checked
                    ? double.Parse(METextBox.Text) / 100
                    : double.Parse(MEComboBox.SelectedItem?.ToString()!.TrimEnd('%')!) / 100;

                sampleSize = n / (1 + n * me * me);

                SSTextBox.Text = sampleSize.ToString("0");
            }
        }

        private void DoUpdateDescription(object sender, EventArgs e)
        {
            UpdateDescription();
        }

        private void PlayAnimation(object sender, EventArgs e)
        {
            PlayButton.Enabled = false;

            if (RB1.Checked)
                SimpleRandom();
            else if (RB2.Checked)
                Systematic();
            else if (RB3.Checked)
                StratifiedRandom();
            else if (RB4.Checked)
                Cluster();
            else if (RB5.Checked)
                Convenience();
            else if (RB6.Checked)
                Voluntary();
            else if (RB7.Checked)
                Snowball();
            else if (RB8.Checked)
                Quota();
            else if (RB9.Checked)
                Purposive();

            UpdateDescription();
        }

        private IEnumerable<int> AntiDiagonalTraversal(int maxCount)
        {
            const int cols = 25;
            int rows = Math.Max(1, examplePopulation / cols);

            if (maxCount <= 0) yield break;
            int limit = Math.Min(maxCount, examplePopulation);

            int produced = 0;
            // Iterate anti-diagonals by increasing sum s = r + c.
            for (int s = 0; s <= rows + cols - 2 && produced < limit; s++)
            {
                for (int r = 0; r < rows && produced < limit; r++)
                {
                    int c = s - r;
                    if (c >= 0 && c < cols)
                    {
                        yield return r * cols + c;
                        produced++;
                        if (produced >= limit) yield break;
                    }
                }
            }
        }

        private async void Convenience()
        {
            await RunAnimationAsync(AntiDiagonalTraversal(exampleSample), idx =>
            {
                gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
            }, 1, true);
        }

        private async void Voluntary()
        {
            int[] unique = GetUniqueIndices(examplePopulation, exampleSample);
            await RunAnimationAsync(unique, idx =>
            {
                gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
            }, rng.Next(100), true);
        }

        private async void Snowball()
        {
            int count = 1;
            int[] unique = GetUniqueIndices(examplePopulation, exampleSample);

            gridPanel.RegenerateColors();
            gridPanel.Refresh();

            do
            {
                foreach (int idx in unique.Skip(0).Take(count))
                {
                    gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);

                    int row = idx / 25;
                    int col = idx % 25;
                    gridPanel.InvalidateCell(row, col);

                    await Task.Delay(Math.Max(0, 0));
                }

                gridPanel.Refresh();
                count += rng.Next(5);

                await Task.Delay(100);
            }
            while (count <= exampleSample);

            gridPanel.ShowSelectedCells();
            gridPanel.Refresh();

            PlayButton.Enabled = true;
        }

        private void Quota()
        {
            StratifiedRandom();
        }

        private async void Purposive()
        {
            int[] unique = GetUniqueIndices(examplePopulation, exampleSample);
            int random = rng.Next(100, 150);

            await RunAnimationAsync(unique.Skip(0).Take(random), idx =>
            {
                gridPanel.SetCircleColor(idx / 25, idx % 25, Color.LightGray);
                gridPanel.SetCircleStrokeColor(idx / 25, idx % 25, Color.LightGray);
            }, 0, true, false);

            await RunAnimationAsync(unique.Skip(random).Take(unique.Length + random), idx =>
            {
                gridPanel.SetCircleColor(idx / 25, idx % 25, Color.Red);
            }, 5, false, true);
        }

        private void Credits(object sender, EventArgs e)
        {
            MessageBox.Show("""
                A PETA educational software brought to you by:

                Catoy, Nevan Angelo R.
                Dumaguing, Daniel Dwayne G.
                Eligue, Daniel Josef M.
                Tañola, Ezequel Nathan T.
                Torres, Rance Xander E.
                """, "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDescription()
        {
            var text = "A sampling technique where participants ";

            if (RB1.Checked)
                text += "are randomly chosen by a number generator or ballot.";
            else if (RB2.Checked)
                text += "are chosen at regular intervals.";
            else if (RB3.Checked)
                text += "are seperated into strata and randomly select from each stratum.";
            else if (RB4.Checked)
                text += "are divided into clusters and randomly select them.";
            else if (RB5.Checked)
                text += "are chosen based on their proximity to the researchers.";
            else if (RB6.Checked)
                text += "self-select to participate in the study.";
            else if (RB7.Checked)
                text += "recruit other participants from their network.";
            else if (RB8.Checked)
                text += "are selected by the researchers based on specific traits.";
            else if (RB9.Checked)
                text += "are selected based on the researcher's judgment.";

            DescriptionLabel.Text = text;
        }
    }
}
