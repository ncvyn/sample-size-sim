using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sample_Size_Sim
{
    public class GridPanel : Panel
    {
        private readonly int rows = 20;
        private readonly int cols = 25;
        private readonly Color[,] cellColors;
        private readonly Color[,] strokeColors;
        private readonly Random rng = new();

        public GridPanel()
        {
            DoubleBuffered = true;
            cellColors = new Color[rows, cols];
            strokeColors = new Color[rows, cols];
            GenerateColors();
        }

        private void GenerateColors()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    cellColors[r, c] = Color.LightGray;
                    strokeColors[r, c] = rng.Next(2) == 0 ? Color.Blue : Color.Green;
                }
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            int cellW = ClientSize.Width / cols;
            int cellH = ClientSize.Height / rows;
            int diameter = Math.Max(2, Math.Min(cellW, cellH) - 4); // small padding

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int x = c * cellW + (cellW - diameter) / 2;
                    int y = r * cellH + (cellH - diameter) / 2;

                    using (var brush = new SolidBrush(cellColors[r, c]))
                    {
                        g.FillEllipse(brush, x, y, diameter, diameter);
                    }

                    using (var pen = new Pen(strokeColors[r, c], 2.5f))
                    {
                        g.DrawEllipse(pen, x, y, diameter, diameter);
                    }
                }
            }
        }

        public void RegenerateColors()
        {
            GenerateColors();
        }

        // Change a single circle's fill color without triggering a repaint.
        public void SetCircleColor(int row, int col, Color color)
        {
            if (row < 0 || row >= rows) throw new ArgumentOutOfRangeException(nameof(row));
            if (col < 0 || col >= cols) throw new ArgumentOutOfRangeException(nameof(col));

            if (InvokeRequired)
            {
                Invoke(new Action(() => SetCircleColor(row, col, color)));
                return;
            }

            cellColors[row, col] = color;
        }

        public void SetCircleStrokeColor(int row, int col, Color color)
        {
            if (row < 0 || row >= rows) throw new ArgumentOutOfRangeException(nameof(row));
            if (col < 0 || col >= cols) throw new ArgumentOutOfRangeException(nameof(col));

            if (InvokeRequired)
            {
                Invoke(new Action(() => SetCircleStrokeColor(row, col, color)));
                return;
            }

            strokeColors[row, col] = color;
        }

        /// <summary>
        /// Invalidate the painted region for a single cell (circle).
        /// Thread-safe.
        /// </summary>
        /// <param name="row">Row index of the cell (0-based).</param>
        /// <param name="col">Column index of the cell (0-based).</param>
        public void InvalidateCell(int row, int col)
        {
            if (row < 0 || row >= rows) throw new ArgumentOutOfRangeException(nameof(row));
            if (col < 0 || col >= cols) throw new ArgumentOutOfRangeException(nameof(col));

            if (InvokeRequired)
            {
                Invoke(new Action(() => InvalidateCell(row, col)));
                return;
            }

            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
            {
                // Nothing meaningful to compute; invalidate whole control
                Invalidate();
                return;
            }

            int cellW = ClientSize.Width / cols;
            int cellH = ClientSize.Height / rows;

            if (cellW <= 0 || cellH <= 0)
            {
                Invalidate();
                return;
            }

            int diameter = Math.Max(2, Math.Min(cellW, cellH) - 4);
            int x = col * cellW + (cellW - diameter) / 2;
            int y = row * cellH + (cellH - diameter) / 2;

            int pad = 4; // covers 2.5f pen width and a small margin
            var rect = new Rectangle(x - pad, y - pad, diameter + pad * 2, diameter + pad * 2);
            rect = Rectangle.Intersect(rect, this.ClientRectangle);

            if (!rect.IsEmpty)
                Invalidate(rect);
            else
                Invalidate(); // fallback
        }

        public void ShowSelectedCells()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ShowSelectedCells));
                return;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var currentFill = cellColors[r, c];

                    if (currentFill.ToArgb() == Color.LightGray.ToArgb())
                    {
                        strokeColors[r, c] = Color.LightGray;
                        cellColors[r, c] = Color.LightGray;
                    }
                    else if (currentFill.ToArgb() == Color.Red.ToArgb())
                    {
                        cellColors[r, c] = Color.White;
                    }
                }
            }
        }
    }
}