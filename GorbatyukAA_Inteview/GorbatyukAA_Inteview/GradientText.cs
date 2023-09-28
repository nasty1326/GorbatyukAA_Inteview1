using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GorbatyukAA_Inteview
{
    public partial class GradientText :Label
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            StringFormat sForm = new StringFormat();
            Int32 lNum = (Int32)Math.Log((Double)TextAlign, 2);
            sForm.LineAlignment = (StringAlignment)(lNum / 4);
            sForm.Alignment = (StringAlignment)(lNum % 4);

            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, 135F);
            e.Graphics.DrawString(Text, Font, brush, ClientRectangle, sForm);
            // base.OnPaint(e);
        }
    }
}
