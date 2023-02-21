using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class Slider : UserControl
    {
        public Slider()
        {
            InitializeComponent();
        }

        private bool isDragging = false;
        private Point startPoint;
        private int min = 10;
        private int max = 20;
        private double value = 10;


        private void SliderThumb_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = e.Location;
        }

        private void SliderThumb_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = SliderThumb.Location.X + (e.Location.X - startPoint.X);
                int newY = SliderThumb.Location.Y;

                newX = Math.Max(newX, SliderBody.Location.X);
                newX = Math.Min(newX, SliderBody.Location.X + SliderBody.Size.Width - SliderThumb.Size.Width);

                SliderThumb.Location = new Point(newX, newY);

                int thumbRange = SliderBody.Width - SliderThumb.Width;
                float relativeThumbPosition = (float)(SliderThumb.Location.X - SliderBody.Location.X) / thumbRange;
                int valueRange = max - min;
                value = (relativeThumbPosition * valueRange + min);

                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void SliderThumb_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        public int Minimum
        {
            get { return min; }
            set { min = value; }
        }

        public int Maximum
        {
            get { return max; }
            set { max = value; }
        }

        public double Value
        {
            get { return value; }
            set
            {
                if (value < min)
                {
                    value = min;
                }
                else if (value > max)
                {
                    value = max;
                }
                this.value = value;

                float valueRange = max - min;
                float thumbRange = SliderBody.Width - SliderThumb.Width;
                float valuePos = (float)value - min;
                float thumbPos = valuePos / valueRange * thumbRange;
                SliderThumb.Left = (int)Math.Round(thumbPos);
            }
        }
        public event EventHandler ValueChanged;
    }
}
