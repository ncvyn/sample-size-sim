using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;
using System.Threading;

namespace Sample_Size_Sim
{
    public partial class Form1 : Form
    {
        private enum Formula { Cochran, Slovin }
        Formula formula = Formula.Cochran;

        private GridPanel gridPanel;
        private Random rnd = new();

        public Form1()
        {
            InitializeComponent();
            Int32 SECOND_ITEM_INDEX = 1;
            MEComboBox.SelectedIndex = SECOND_ITEM_INDEX;
            ZSComboBox.SelectedIndex = SECOND_ITEM_INDEX;

            // create and place the grid panel below the group boxes with a fixed 200x200 size
            Size size = new(500, 400);
            gridPanel = new GridPanel
            {
                Location = new Point(40, 140),
                Size = size,
                MinimumSize = size,
                MaximumSize = size,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
            };

            this.Controls.Add(gridPanel);
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
            formula = this.CochranButton.Checked ? Formula.Cochran : Formula.Slovin;

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

        private void B1_Click(object sender, EventArgs e)
        {
            // Animate 50 unique indices set to Red
            int[] unique = GetUniqueIndices(maxExclusive: 100, count: 50);
            //RunAnimatedIndexAction(unique, idx => gridPanel.ChangeCircleStrokeColor(idx / 10, idx % 10, Color.Red), delayMs: 25, regenerateColors: true);
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
                int tmp = indices[j];
                indices[j] = indices[i];
                indices[i] = tmp;
            }

            if (count == maxExclusive) return indices;
            int[] result = new int[count];
            Array.Copy(indices, result, count);
            return result;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            // Animate all even indices to Red (skip odds)
            IEnumerable<int> evens = Enumerable.Range(0, 100).Where(i => i % 2 == 0);
            //RunAnimatedIndexAction(evens, idx => gridPanel.ChangeCircleStrokeColor(idx / 10, idx % 10, Color.Red), delayMs: 25, regenerateColors: true);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            // Phase 1: set fills (first 50 Blue, next 50 Green) with small delay
            await RunAnimatedIndexActionAsync(Enumerable.Range(0, 500),
                idx =>
                {
                    if (idx < 250)
                        gridPanel.ChangeCircleColor(idx / 25, idx % 25, Color.Blue);
                    else
                        gridPanel.ChangeCircleColor(idx / 25, idx % 25, Color.Green);
                },
                delayMs: 1, regenerateColors: true, applyTransformations: false);


            // Phase 2: pick unique indices within each half and set strokes to Red
            int[] blueUnique = GetUniqueIndices(maxExclusive: 250, count: 109);
            int[] greenUnique = GetUniqueIndices(maxExclusive: 250, count: 109);

            await RunAnimatedIndexActionAsync(blueUnique, idx => gridPanel.ChangeCircleStrokeColor(idx / 25, idx % 25, Color.Red), delayMs: 5, regenerateColors: false, applyTransformations: false);
            await RunAnimatedIndexActionAsync(greenUnique.Select(x => x + 250), idx => gridPanel.ChangeCircleStrokeColor(idx / 25, idx % 25, Color.Red), delayMs: 5, regenerateColors: false, applyTransformations: true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Animate indices 0..24 and 50..74 to Red
            IEnumerable<int> selection = Enumerable.Range(0, 25).Concat(Enumerable.Range(50, 25));
            //RunAnimatedIndexAction(selection, idx => gridPanel.ChangeCircleStrokeColor(idx / 10, idx % 10, Color.Red), delayMs: 25, regenerateColors: true);
        }

        // Generalized helper to run an animated sequence of per-index actions.
        // - indices: sequence of circle indices (0..99)
        // - action: what to do for each index (row/col can be computed from idx)
        // - delayMs: milliseconds to sleep after each update
        // - regenerateColors: if true call RegenerateColors() and initial Refresh()
        // - applyTransformations: if true call ApplyStrokeBasedTransformations() and final Refresh()
        private async Task RunAnimatedIndexActionAsync(IEnumerable<int> indices, Action<int> action, int delayMs = 25, bool regenerateColors = true, bool applyTransformations = true)
        {
            if (regenerateColors)
            {
                gridPanel.RegenerateColors();
                gridPanel.Refresh(); // initial full redraw
            }

            await Task.Delay(500); // brief pause before starting

            foreach (int idx in indices)
            {
                action(idx);

                // Invalidate only the affected cell; allow the UI thread to paint it.
                int row = idx / 25;
                int col = idx % 25;
                gridPanel.InvalidateCell(row, col, refresh: false);

                await Task.Delay(Math.Max(0, delayMs));
            }

            if (applyTransformations)
            {
                gridPanel.ApplyStrokeBasedTransformations();
                gridPanel.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
