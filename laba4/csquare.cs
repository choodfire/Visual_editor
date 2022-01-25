using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace laba4
{
    class csquare : Base
    {
        public csquare(Point point, int side_length, Color color)
        {
            this.point = point;
            this.isSelected = true;
            this.size = side_length;
            this.color = color;
        }

        public override void draw(Graphics g)
        {
            SolidBrush bb = new SolidBrush(this.color);
            g.FillRectangle(bb, this.point.X - size / 2, this.point.Y - size / 2, size, size);
        }
        public override void drawSelection(Graphics g)
        {
            g.FillRectangle(Brushes.Red, this.point.X - (size + 10) / 2, this.point.Y - (size + 10) / 2, size + 10, size + 10);
        }
    }
}
