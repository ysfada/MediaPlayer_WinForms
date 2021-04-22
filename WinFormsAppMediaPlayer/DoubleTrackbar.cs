using System.Windows.Forms;

namespace WinFormsAppMediaPlayer
{
    /// <summary>
    /// Tracbar for double precision. Base class is using int.
    /// This change is necessary for smooth trackbar experience.
    /// </summary>
    class DoubleTrackbar : TrackBar
    {
        public double Precision { get; set; } = 0.01f;

        public new double LargeChange
        {
            get => base.LargeChange * Precision;
            set => base.LargeChange = (int)(value / Precision);
        }

        public new double Maximum
        {
            get => base.Maximum * Precision;
            set => base.Maximum = (int)(value / Precision);
        }

        public new double Minimum
        {
            get => base.Minimum * Precision;
            set => base.Minimum = (int)(value / Precision);
        }

        public new double SmallChange
        {
            get => base.SmallChange * Precision;
            set => base.SmallChange = (int)(value / Precision);
        }

        public new double Value
        {
            get => base.Value * Precision;
            set => base.Value = (int)(value / Precision);
        }
    }
}
