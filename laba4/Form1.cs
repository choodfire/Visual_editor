using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace laba4
{
    public partial class Form1 : Form
    {
        private Container<ccircle> container;

        public Form1()
        {
            InitializeComponent();
            container = new Container<ccircle>();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) 
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container.deleteObject(i);
                    }
                }
                //Invalidate();
                pictureBox1.Invalidate();
            }

            if (e.KeyCode == Keys.Add)
            {
                for (int i = 0; i < container.getCapacity(); i++)
                {
                    if (container[i] != null) 
                    {
                        if (container[i].getSelection() == true)
                        {
                            Console.WriteLine("aa");
                            // тут код для увеличения
                            int r = container[i].getRadius();
                            Point p = container[i].getPoint();

                            container.deleteObject(i);

                            ccircle item = new ccircle(p, (int)(r * 1.1));

                            container.addToEnd(ref item);
                            //Invalidate();
                            pictureBox1.Invalidate();
                        }
                    }
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("qwe");
            Point p = e.Location;
            int index = -1;
            bool on_item = false;

            for (int i = 0; i < container.getSize(); i++)
            {
                if (container[i].check_location(p) == true && on_item == false)
                {
                    on_item = true;
                    index = i;
                }
            }

            if (on_item == true)
            {
                if (Control.ModifierKeys != Keys.Control)
                {
                    for (int ii = 0; ii < container.getSize(); ii++)
                    {
                        container[ii].setSelection(false);
                    }
                }

                container[index].setSelection(true);
                //Invalidate();
                pictureBox1.Invalidate();
            }

            if (on_item == false)
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    container[i].setSelection(false);
                }
                ccircle item = new ccircle(p, 50);
                container.addToEnd(ref item);

                //Invalidate();
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < container.getSize(); i++)
            {
                if (container[i].getSelection() == false)
                {
                    container[i].draw(g, Brushes.Blue);
                }
                else
                {
                    container[i].draw(g, Brushes.Red);
                }
            }
        }
    }   
}
