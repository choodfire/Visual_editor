using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba4
{
    class cline: Base
    {
        private Point point1;
        private Point point2;

        public cline(Point point, int radius, Color color)
        {
            this.point = point;
            this.isSelected = true;
            this.size = radius;
            this.color = color;

            this.point1 = new Point(point.X - 25, point.Y - 25);
            this.point2 = new Point(point.X + 25, point.Y + 25);
        }

        public override void draw(Graphics g)
        {
            //g.Fill
        }
        public override void drawSelection(Graphics g)
        {
            //g.FillEllipse(Brushes.Red, this.point.X - (size + 10) / 2, this.point.Y - (size + 10) / 2, size + 10, size + 10);
        }
    }
}
