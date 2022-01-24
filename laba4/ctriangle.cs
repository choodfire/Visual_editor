using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace laba4
{
    class ctriangle: Base
    {
        private Point point1;
        private Point point2;
        private Point point3;
        private Point point1s;
        private Point point2s;
        private Point point3s;
        Point[] points;
        Point[] pointsForSelection;

        public ctriangle(Point point, int size, Color color)
        {
            this.point = point;
            this.isSelected = true;
            this.size = size;
            this.color = color;

            this.point1 = new Point(point.X, point.Y - 30);
            this.point2 = new Point(point.X + 30, point.Y + 30);
            this.point3 = new Point(point.X - 30, point.Y + 30);

            points = new Point[3] { point1, point2, point3 };

            this.point1s = new Point(point.X, point.Y - 40);
            this.point2s = new Point(point.X + 40, point.Y + 35);
            this.point3s = new Point(point.X - 40, point.Y + 35);

            pointsForSelection = new Point[3] { point1s, point2s, point3s };
        }

        public override void draw(Graphics g, Brush b)
        {
            g.FillPolygon(b, points);
        }
        public override void drawSelection(Graphics g)
        {
            g.FillPolygon(Brushes.Red, pointsForSelection);
        }

        //public override void move(int xOffset, int yOffset)
        //{
        //    if (point.X + xOffset + size / 2 < 800 && point.X + xOffset - size / 2 > 0 &&
        //        point.Y + yOffset + size / 2 < 600 && point.Y + yOffset - size / 2 > 0)
        //    {
        //        point.X += xOffset;
        //        point.Y += yOffset;
        //    }
        //}
    }
}
