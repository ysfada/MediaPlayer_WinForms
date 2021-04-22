using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinFormsAppMediaPlayer
{
    class RoundButton : Button
    {
        //public RoundButton()
        //{
        //    FlatAppearance.MouseDownBackColor = Color.Transparent;
        //    FlatAppearance.MouseOverBackColor = Color.Transparent;
        //}

        //public bool IsDarkTheme { get; set; } = true;

        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Call parent OnPaint method
            base.OnPaint(pevent);

            // Make edges smooth
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            pevent.Graphics.InterpolationMode = InterpolationMode.High;

            // Make button ellipse
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(grPath);

            // Paint the button
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                pevent.Graphics.FillEllipse(brush, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }
    }
}
