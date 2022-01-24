﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace laba4
{
    class ctriangle: Base
    {
        public Point point1;
        public Point point2;
        public Point point3;
        public Point point1s;
        public Point point2s;
        public Point point3s;
        public Point[] points;
        public Point[] pointsForSelection;

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

        public override void move(int xOffset, int yOffset)
        {
            if (point.X + xOffset + size < 800 && point.X + xOffset - size > 0 &&
                point.Y + yOffset + size < 600 && point.Y + yOffset - size > 0)
            {
                point.X += xOffset;
                point.Y += yOffset;

                point1.X += xOffset;
                point1.Y += yOffset;
                point2.X += xOffset;
                point2.Y += yOffset;
                point3.X += xOffset;
                point3.Y += yOffset;

                point1s.X += xOffset;
                point1s.Y += yOffset;
                point2s.X += xOffset;
                point2s.Y += yOffset;
                point3s.X += xOffset;
                point3s.Y += yOffset;

                points = new Point[3] { point1, point2, point3 };
                pointsForSelection = new Point[3] { point1s, point2s, point3s };
            }
        }
        public override void resize(bool sign) // тут надо и points i pointsforsel
        {
            if (sign == true)
            {
                if (point.X - size - 10 > 0 && point.X + size + 10 < 800 &&
                    point.Y - size - 10 > 0 && point.Y + size + 10 < 600)
                {
                    size = Convert.ToInt32(size + 10);

                    point1.Y = point1.Y - 10;
                    point2.X = point2.X + 10;
                    point2.Y = point2.Y + 10;
                    point3.X = point3.X - 10;
                    point3.Y = point3.Y + 10;

                    point1s.Y -= 10;
                    point2s.X += 10;
                    point2s.Y += 10;
                    point3s.X -= 10;
                    point3s.Y += 10;

                    points = new Point[3] { point1, point2, point3 };
                    pointsForSelection = new Point[3] { point1s, point2s, point3s };
                }
            }
            else if (size > 40)
            {
                size = Convert.ToInt32(size - 10);

                point1.Y = point1.Y + 10;
                point2.X = point2.X - 10;
                point2.Y = point2.Y - 10;
                point3.X = point3.X + 10;
                point3.Y = point3.Y - 10;

                point1s.Y += 10;
                point2s.X -= 10;
                point2s.Y -= 10;
                point3s.X += 10;
                point3s.Y -= 10;

                points = new Point[3] { point1, point2, point3 };
                pointsForSelection = new Point[3] { point1s, point2s, point3s };
            }
        }
    }
}