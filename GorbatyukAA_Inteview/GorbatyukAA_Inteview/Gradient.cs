using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorbatyukAA_Inteview
{
    internal class Gradient : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBot { get; set; }
        protected override void OnPaint (PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop ,this.ColorBot,135F);
            Graphics g=e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint (e);
        }
    }
}
