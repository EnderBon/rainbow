using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rainbow
{
    public partial class MyRedTrackBar : System.Windows.Forms.TrackBar
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(b, ClientRectangle);
        }
    }

    public partial class MyBlueTrackBar : System.Windows.Forms.TrackBar
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(b, ClientRectangle);
        }
    }

    public partial class MyGreenTrackBar : System.Windows.Forms.TrackBar
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(b, ClientRectangle);
        }
    }

    public partial class MyBrightTrackBar : System.Windows.Forms.TrackBar
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(b, ClientRectangle);
        }
    }
}
