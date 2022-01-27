using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba4
{
    class cgroup : Base
    {
        private Container<Base> containerr;

        public cgroup()
        {
            containerr = new Container<Base>();
        }
        public Base this[int index]
        {
            get
            {
                return containerr[index];
            }

            set
            {
                containerr[index] = value;
            }
        }
        public void addToGroup(Base obj)
        {
            containerr.addObject(obj);
        }
        public void deleteFromGroup(int index)
        {
            containerr.deleteObject(index);
        }

        public int getGroupSize() //вернуть размер
        {
            return containerr.getSize();
        }

        public override void draw(Graphics g)
        {
            for (int i = 0; i < getGroupSize(); i++)
            {
                containerr[i].draw(g);
            }
        }
        public override void drawSelection(Graphics g)
        {
            for (int i = 0; i < getGroupSize(); i++)
            {
                containerr[i].drawSelection(g);
            }
        }

        public override void move(int xOffset, int yOffset, int canvas_width, int canvas_height)
        {
            bool can = true;
            for (int i = 0; i < getGroupSize(); i++)
            {
                can = can && containerr[i].canItMove(xOffset, yOffset, canvas_width, canvas_height);
            }
            if (can == true) 
            {
                for (int i = 0; i < getGroupSize(); i++)
                {
                    containerr[i].move(xOffset, yOffset, canvas_width, canvas_height);
                }
            }
        }
        public override bool canItMove(int xOffset, int yOffset, int canvas_width, int canvas_height)
        {
            bool can = true;
            for (int i = 0; i < getGroupSize(); i++)
            {
                can = can && containerr[i].canItMove(xOffset, yOffset, canvas_width, canvas_height);
            }
            return can;
        }
        public override void resize(bool sign)
        {
            if (CanItResize(sign) == true) 
            {
                for (int i = 0; i < getGroupSize(); i++)
                {
                    containerr[i].resize(sign);
                }
            }
        }
        public override bool CanItResize(bool sign)
        {
            bool can = true;
            for (int i = 0; i < getGroupSize(); i++)
            {
                can = can && containerr[i].CanItResize(sign);
            }
            return can;
        }
        public override bool check_location(Point p) 
        {
            bool ok = false;
            for (int i = 0; i < getGroupSize(); i++)
            {
                ok = ok || containerr[i].check_location(p);
            }
            return ok;
        }
        public override string getClassname()
        {
            return "Group";
        }
        public override void save(StreamWriter sw)
        {
            sw.WriteLine(getClassname());
            sw.WriteLine(getGroupSize().ToString());

            for (int i = 0; i < getGroupSize(); i++)
            {
                containerr[i].save(sw);
            }
        }
        public override void load(StreamReader s, factory f)
        {
            int numberOfShapes = Convert.ToInt32(s.ReadLine());
            
            for (int i = 0; i < numberOfShapes; i++) 
            {
                Base shape;
                shape = f.createShape(s.ReadLine());

                shape.load(s, f);

                addToGroup(shape);
            }
        }
    }
}
