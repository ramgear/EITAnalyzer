using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EITScope
{
    public partial class ScopeGraph : UserControl
    {
        [Browsable(true)]
        public Color GraphColor { get; set; }

        public int PointPerDiv { get; set; }

        public int XMax { get; set; }
        public int XMin { get; set; }
        public int XDiv { get; set; }
        public int XSubDiv { get; set; }
        public int XPadding { get; set; }

        public int YMax { get; set; }
        public int YMin { get; set; }
        public int YDiv { get; set; }
        public int YSubDiv { get; set; }
        public int YPadding { get; set; }

        private float YRatio;
        private float XRatio;

        public ScopeGraph()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.GraphColor = Color.Green;

            this.PointPerDiv = 10;

            this.XMax = 5000;  // 5000 mV
            this.XMin = 0; ;
            this.XDiv = 5;
            this.XSubDiv = 10;
            this.XPadding = 20;

            this.YMax = 5000;  // 5000 mV
            this.YMin = 0; ;
            this.YDiv = 5;
            this.YSubDiv = 0;
            this.YPadding = 20;

            this.AdjustSize();
        }

        private void AdjustSize()
        {
            this.Height = this.YPadding * 2 + this.YDiv * this.PointPerDiv;
        }

        private void UpdateRatio()
        {
            this.XRatio = (this.Width - this.XPadding * 2) / (this.XMax - this.XMin);
            this.YRatio = (this.Height - this.YPadding * 2) / (this.YMax - this.YMin);
        }

        public void DrawGraph(Byte[] data)
        {
            int size = data.Length;

        }

        private float VoltToY(Byte value)
        {
            return (this.YMax - this.YMin) * value * this.YRatio / Byte.MaxValue;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = this.DisplayRectangle;
            Pen pen = new Pen(Color.Gray);
            Pen penBold = new Pen(pen.Color, 2);

            // draw border
            g.DrawRectangle(pen, rect);

            // draw Y axis
            Point p1 = new Point(this.XPadding - 3, this.YPadding);
            Point p2 = new Point(p1.X, rect.Bottom - this.YPadding);
            g.DrawLine(penBold, p1, p2);

            // draw Y axis div
            p1 = new Point(this.XPadding, this.YPadding);
            p2 = new Point(p1.X + 6, p1.Y);

            for (int i = 0; i <= this.YDiv; i++)
            {
                g.DrawLine(pen, p1, p2);
                p1.Y += this.PointPerDiv;
                p2.Y = p1.Y;
            }

            // draw X axis
            p1 = new Point(this.XPadding, rect.Bottom - this.YPadding - 3);
            p2 = new Point(p1.X, p1.Y + 6);
            g.DrawLine(penBold, p1, p2);

            // draw X axis div
            p1 = new Point(this.XPadding, this.YPadding);
            p2 = new Point(p1.X + 4, p1.Y);

            for (int i = 0; i <= this.XDiv; i++)
            {
                g.DrawLine(pen, p1, p2);
                p1.X += this.PointPerDiv;
                p2.X = p1.Y;
            }
        }

        private void ScopeGraph_Load(object sender, EventArgs e)
        {
            
            if (this.Width > 0 && this.Height > 0)
                this.UpdateRatio();
        }
    }
}
