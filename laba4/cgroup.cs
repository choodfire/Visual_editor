using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba4
{
    class cgroup: Base
    {
        private int size; // общий размер
        //private Base[] arr;
        private Container<Base> containerr;

        public cgroup()
        {
            //arr = null;
            containerr = new Container<Base>();
        }
        public cgroup(int size)
        {
            this.size = size;
            //arr = new Base[size];
            containerr = new Container<Base>(size);
        }
        public Base this[int index]
        {
            get
            {
                //return arr[index];
                return containerr[index];
            }

            set
            {
                //arr[index] = value;
                containerr[index] = value;
            }
        }

        public void addToGroup(Base obj)
        {
            if (size == 0)
            {
                //arr = new Base[1];
                //arr[0] = obj;
                size = 1;
                containerr = new Container<Base>(1);
                containerr[0] = obj;
            }
            else
            {
                //Base[] new_arr = new Base[size + 1];
                //for (int i = 0; i < size; i++)
                //{
                //    new_arr[i] = arr[i];
                //}
                //new_arr[size] = obj;
                //arr = new_arr;

                Container<Base> neww = new Container<Base>(size + 1);
                for (int i = 0; i < size; i++) 
                {
                    neww[i] = containerr[i];
                }
                neww[size] = obj;
                containerr = neww;
                size += 1;


            }
        }
        public void deleteFromGroup(int index)
        {
            //Base[] new_arr = new Base[size - 1];
            //for (int i = 0; i < index; i++)
            //    new_arr[i] = arr[i];
            //for (int i = index + 1; i < size; i++)
            //    new_arr[i - 1] = arr[i];
            //arr = new_arr;

            Container<Base> neww = new Container<Base>(size - 1);
            for (int i = 0; i < index; i++)
            {
                neww[i] = containerr[i];
            }
            for (int i = index + 1; i < size; i++)
                neww[i - 1] = containerr[i];
            containerr = neww;

            size -= 1;
        }

        public int getGroupSize() //вернуть размер
        {
            return size;
        }

        public override void draw(Graphics g, Brush b) 
        {
            for (int i = 0; i < size; i++)
            {
                containerr[i].draw(g, b);
                //this.arr[i].draw(g, b);
                //arr[i].draw(g, b);
            }
        }
        public override void drawSelection(Graphics g)
        {
            for (int i = 0; i < size; i++)
            {
                containerr[i].drawSelection(g);
                //arr[i].drawSelection(g);
            }
        }

        public override void move(int xOffset, int yOffset) 
        {
            for (int i = 0; i < size; i++)
            {
                //arr[i].move(xOffset, yOffset);
            }
        }

        public override void resize(bool sign)
        {
            if (sign == true)
            {
                if (point.X - size * 0.55 > 0 && point.X + size * 0.55 < 800 &&
                    point.Y - size * 0.55 > 0 && point.Y + size * 0.55 < 600)
                {
                    for (int i = 0; i < size; i++)
                    {
                        //arr[i].resize(sign);
                    }
                }
            }
            else if (size > 40)
            {
                for (int i = 0; i < size; i++)
                {
                    //arr[i].resize(sign);
                }
            }
        }

    }
}
