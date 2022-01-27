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
        private int size; // общий размер
        private Base[] arr;

        public cgroup()
        {
            arr = null;
        }
        public cgroup(int size)
        {
            this.size = size;
            arr = new Base[size];
        }
        public Base this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        public void addToGroup(Base obj)
        {
            if (size == 0)
            {
                arr = new Base[1];
                arr[0] = obj;
                size = 1;
            }
            else
            {
                Base[] new_arr = new Base[size + 1];
                for (int i = 0; i < size; i++)
                {
                    new_arr[i] = arr[i];
                }
                new_arr[size] = obj;
                arr = new_arr;
                size += 1;
            }
        }
        public void deleteFromGroup(int index)
        {
            Base[] new_arr = new Base[size - 1];
            for (int i = 0; i < index; i++)
                new_arr[i] = arr[i];
            for (int i = index + 1; i < size; i++)
                new_arr[i - 1] = arr[i];
            arr = new_arr;
            size -= 1;
        }

        public int getGroupSize() //вернуть размер
        {
            return size;
        }

        public override void draw(Graphics g)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i].draw(g);
            }
            //g.FillEllipse(Brushes.Red, 411, 442, 50, 60);
            //Console.WriteLine("bro wtf");

        }
        public override void drawSelection(Graphics g)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i].drawSelection(g);
            }
        }

        public override void move(int xOffset, int yOffset, int canvas_width, int canvas_height)
        {
            bool can = true;
            for (int i = 0; i < size; i++)
            {
                can = can && arr[i].canItMove(xOffset, yOffset);
            }
            if (can == true) 
            {
                for (int i = 0; i < size; i++)
                {
                    arr[i].move(xOffset, yOffset, canvas_width, canvas_height);
                }
            }

        }
        public override bool canItMove(int xOffset, int yOffset)
        {
            bool can = true;
            for (int i = 0; i < size; i++)
            {
                can = can && arr[i].canItMove(xOffset, yOffset);
            }
            return can;
        }
        public override void resize(bool sign)
        {
            bool can = true;
            for (int i = 0; i < size; i++)
            {
                can = can && arr[i].CanItResize(sign);
            }
            if (can == true)
            {
                for (int i = 0; i < size; i++)
                {
                    arr[i].resize(sign);
                }
            }
        }
        public override bool CanItResize(bool sign)
        {
            bool can = true;
            for (int i = 0; i < size; i++)
            {
                can = can && arr[i].CanItResize(sign);
            }
            return can;
        }
        public override bool check_location(Point p) 
        {
            bool ok = false;
            for (int i = 0; i < size; i++)
            {
                ok = ok || arr[i].check_location(p);
            }
            return ok;
        }
        public override string getClassname()
        {
            return "Group";
        }
        public override void save(StreamWriter sw)
        {
            //string path = @"C:\Users\zzzly\Desktop\oop.txt";
            //string text = getClassname() + "\n" + size.ToString();
            sw.WriteLine(getClassname());
            sw.WriteLine(size.ToString());

            for (int i = 0; i < size; i++)
            {
                arr[i].save(sw);
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