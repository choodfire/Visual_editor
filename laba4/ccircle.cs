using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace laba4
{
    class ccircle: Base
    {
        private int radius;
        private Point point;
        private bool isSelected;
        private Graphics g;

        public ccircle(Point point, int radius) 
        {
            this.point = point;
            this.isSelected = true;
            this.radius = radius;
        }

        public void draw(Graphics g, Brush b) 
        {
            g.FillEllipse(b, this.point.X - radius/2, this.point.Y - radius / 2, radius, radius);
        }

        public void setSelection(bool sel) 
        {
            this.isSelected = sel;
        }

        public bool getSelection()
        {
            return isSelected;
        }

        public int getRadius()
        {
            return radius;
        }

        public Point getPoint()
        {
            return point;
        }

        public bool check_location(Point p) 
        {
            if (p.X < this.point.X + radius &&
                p.X > this.point.X - radius &&
                p.Y < this.point.Y + radius &&
                p.Y > this.point.Y - radius)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
