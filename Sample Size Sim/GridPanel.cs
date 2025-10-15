using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
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
                    cellColors[r, c] = (rng.Next(2) == 0) ? Color.Blue : Color.Green;
                    strokeColors[r, c] = Color.Black; // default stroke
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

        // Public API to re-randomize colors if you want to call it later.
        public void RegenerateColors()
        {
            GenerateColors();
        }

        // Change a single circle's fill color without triggering a repaint.
        // Call Invalidate()/Refresh() externally once all updates are applied.
        public void ChangeCircleColor(int row, int col, Color color)
        {
            if (row < 0 || row >= rows) throw new ArgumentOutOfRangeException(nameof(row));
            if (col < 0 || col >= cols) throw new ArgumentOutOfRangeException(nameof(col));

            if (InvokeRequired)
            {
                Invoke(new Action(() => ChangeCircleColor(row, col, color)));
                return;
            }

            cellColors[row, col] = color;

            // NOTE: Intentionally do NOT call Invalidate here so callers can batch updates.
        }

        // Change a single circle's stroke (outline) color without triggering a repaint.
        public void ChangeCircleStrokeColor(int row, int col, Color color)
        {
            if (row < 0 || row >= rows) throw new ArgumentOutOfRangeException(nameof(row));
            if (col < 0 || col >= cols) throw new ArgumentOutOfRangeException(nameof(col));

            if (InvokeRequired)
            {
                Invoke(new Action(() => ChangeCircleStrokeColor(row, col, color)));
                return;
            }

            strokeColors[row, col] = color;
        }

        /// <summary>
        /// Invalidate the painted region for a single cell (circle).
        /// Thread-safe and optionally forces an immediate Refresh.
        /// </summary>
        /// <param name="row">Row index of the cell (0-based).</param>
        /// <param name="col">Column index of the cell (0-based).</param>
        /// <param name="refresh">If true, calls <see cref="Refresh"/> after invalidation to force synchronous repaint.</param>
        public void InvalidateCell(int row, int col, bool refresh = false)
        {
            if (row < 0 || row >= rows) throw new ArgumentOutOfRangeException(nameof(row));
            if (col < 0 || col >= cols) throw new ArgumentOutOfRangeException(nameof(col));

            if (InvokeRequired)
            {
                Invoke(new Action(() => InvalidateCell(row, col, refresh)));
                return;
            }

            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
            {
                // Nothing meaningful to compute; invalidate whole control
                Invalidate();
                if (refresh) Refresh();
                return;
            }

            int cellW = ClientSize.Width / cols;
            int cellH = ClientSize.Height / rows;

            if (cellW <= 0 || cellH <= 0)
            {
                Invalidate();
                if (refresh) Refresh();
                return;
            }

            int diameter = Math.Max(2, Math.Min(cellW, cellH) - 4);
            int x = col * cellW + (cellW - diameter) / 2;
            int y = row * cellH + (cellH - diameter) / 2;

            // Add padding to include stroke thickness and some anti-aliasing margin.
            int pad = 4; // covers 2.5f pen width and a small margin
            var rect = new Rectangle(x - pad, y - pad, diameter + pad * 2, diameter + pad * 2);
            rect = Rectangle.Intersect(rect, this.ClientRectangle);

            if (!rect.IsEmpty)
                Invalidate(rect);
            else
                Invalidate(); // fallback

            if (refresh)
                Refresh();
        }

        // Apply rules across the whole grid:
        // - If a circle's stroke is Black -> set both its fill and stroke to LightGray.
        // - If a circle's stroke is Red   -> change its stroke to Black (leave fill unchanged).
        // This method is thread-safe and does NOT invalidate/refresh the control so callers can batch UI updates.
        public void ApplyStrokeBasedTransformations()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ApplyStrokeBasedTransformations));
                return;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var currentStroke = strokeColors[r, c];

                    if (currentStroke.ToArgb() == Color.Black.ToArgb())
                    {
                        cellColors[r, c] = Color.LightGray;
                        strokeColors[r, c] = Color.LightGray;
                    }
                    else if (currentStroke.ToArgb() == Color.Red.ToArgb())
                    {
                        strokeColors[r, c] = Color.Black;
                    }
                }
            }
        }
    }
}