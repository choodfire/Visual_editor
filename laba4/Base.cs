using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba4
{
    public class Base
    {
        protected int size; // радиус в круге, сторона в квадрате
        protected Point point;
        protected bool isSelected;
        protected Color color;

        public virtual int getSize()
        {
            return size;
        }
        public virtual void setSelection(bool sel)
        {
            this.isSelected = sel;
        }
        public virtual Point getPoint()
        {
            return point;
        }
        public virtual void setColor(Color color)
        {
            this.color = color;
        }

        public virtual bool getSelection()
        {
            return isSelected;
        }

        public virtual Color getColor()
        {
            return color;
        }

        public virtual void move(int xOffset, int yOffset, int canvas_width, int canvas_height)
        {
            if (canItMove(xOffset, yOffset, canvas_width, canvas_height) == true)
            {
                point.X += xOffset;
                point.Y += yOffset;
            }
        }
        public virtual bool canItMove(int xOffset, int yOffset, int canvas_width, int canvas_height)
        {
            if (point.X + xOffset + size / 2 < canvas_width && point.X + xOffset - size / 2 > 0 &&
                point.Y + yOffset + size / 2 < canvas_height && point.Y + yOffset - size / 2 > 0)
            {
                return true;
            }
            return false;
        }

        public virtual void resize(bool sign)
        {
            if (CanItResize(sign) == true) 
            {
                if (sign == true)
                {
                    size = Convert.ToInt32(size * 1.1);
                }
                else
                    size = Convert.ToInt32(size / 1.1);
            }
        }
        public virtual bool CanItResize(bool sign)
        {
            if (sign == true)
            {
                if (point.X - size * 0.55 > 0 && point.X + size * 0.55 < 800 &&
                    point.Y - size * 0.55 > 0 && point.Y + size * 0.55 < 600)
                {
                    return true;
                }
            }
            else if (size > 40)
                return true;
            return false;
        }

        public virtual bool check_location(Point p)
        {
            if (p.X < this.point.X + size &&
                p.X > this.point.X - size &&
                p.Y < this.point.Y + size &&
                p.Y > this.point.Y - size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void drawSelection(Graphics g) { }

        public virtual void draw(Graphics g) { }

        public virtual void save(StreamWriter sw) { }
        public virtual void load(StreamReader stream, factory f) { }
        public virtual string getClassname() 
        {
            return "Base";
        }
    }
}
