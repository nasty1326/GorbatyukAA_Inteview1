using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorbatyukAA_Inteview
{
    internal class GradientProcess : DataGridView
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void PaintBackground(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);

            System.Drawing.Drawing2D.LinearGradientBrush b = new System.Drawing.Drawing2D.LinearGradientBrush(clipBounds, ColorTop, ColorBottom, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            graphics.FillRectangle(b, clipBounds);
        }
    }
}
