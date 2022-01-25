using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace laba4
{
    class ccircle: Base
    {
        //private int radius;
        //private Point point;
        //private bool isSelected;
        //private Color color;
        //private Graphics g;

        public ccircle(Point point, int radius, Color color) 
        {
            this.point = point;
            this.isSelected = true;
            this.size = radius;
            this.color = color;
        }

        public override void draw(Graphics g) 
        {
            SolidBrush bb = new SolidBrush(this.color);
            g.FillEllipse(bb, this.point.X - size / 2, this.point.Y - size / 2, size, size);
        }
        public override void drawSelection(Graphics g)
        {
            g.FillEllipse(Brushes.Red, this.point.X - (size + 10) / 2, this.point.Y - (size + 10) / 2, size + 10, size + 10);
        }

        //public int getRadius()
        //{
        //    return size;
        //}

        //public Point getPoint()
        //{
        //    return point;
        //}

        //public void setSelection(bool sel)
        //{
        //    this.isSelected = sel;
        //}

        //public void setColor(Color color)
        //{
        //    this.color = color;
        //}

        //public bool getSelection()
        //{
        //    return isSelected;
        //}

        //public void resize(bool sign)
        //{
        //    if (sign == true) 
        //    {
        //        if (point.X - radius * 0.55 > 0 && point.X + radius * 0.55 < 800 && 
        //            point.Y - radius * 0.55 > 0 && point.Y + radius * 0.55 < 600)
        //        {
        //            radius = Convert.ToInt32(radius * 1.1);
        //            Console.WriteLine("point x = " + point.X + " r = " + radius);
        //        }
        //    }
        //    else if (radius > 40)
        //        radius = Convert.ToInt32(radius / 1.1);
        //}



        //public void move(int xOffset, int yOffset)
        //{
        //    if (point.X + xOffset + radius / 2 < 800 && point.X + xOffset - radius / 2 > 0 &&
        //        point.Y + yOffset + radius / 2 < 600 && point.Y + yOffset - radius / 2 > 0)
        //    {
        //        point.X += xOffset;
        //        point.Y += yOffset;
        //    }
        //}

        //public bool check_location(Point p) 
        //{
        //    if (p.X < this.point.X + radius &&
        //        p.X > this.point.X - radius &&
        //        p.Y < this.point.Y + radius &&
        //        p.Y > this.point.Y - radius)
        //    {
        //        return true;
        //    }
        //    else 
        //    {
        //        return false;
        //    }
        //}
    }
}
