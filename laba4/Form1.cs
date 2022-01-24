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
        private Container<Base> container;
        public Color currentcolor;

        public Form1()
        {
            InitializeComponent();
            container = new Container<Base>();
            currentcolor = Color.Blue;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G)
            {
                currentcolor = Color.Green;
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].setColor(currentcolor);
                        pictureBox1.Invalidate();
                    }
                }
            }

            if (e.KeyCode == Keys.B)
            {
                currentcolor = Color.Blue;
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].setColor(currentcolor);
                    }
                }
                pictureBox1.Invalidate();
            }

            if (e.KeyCode == Keys.Y)
            {
                currentcolor = Color.Yellow;
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].setColor(currentcolor);
                    }
                }
                pictureBox1.Invalidate();
            }

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
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].resize(true);
                        pictureBox1.Invalidate();
                    }
                }
            }

            if (e.KeyCode == Keys.Subtract)
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].resize(false);
                        pictureBox1.Invalidate();
                    }
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].move(0, -5);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].move(0, 5);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].move(-5, 0);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container[i].move(5, 0);
                        pictureBox1.Invalidate();
                    }
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            Point p = e.Location;
            //Console.WriteLine("picbox press - " + p);
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

            if (on_item == true) // на объект
            {
                if (Control.ModifierKeys != Keys.Control)
                {
                    for (int ii = 0; ii < container.getSize(); ii++)
                    {
                        container[ii].setSelection(false);
                    }
                }

                container[index].setSelection(true);
                
                pictureBox1.Invalidate();
            }

            if (on_item == false) // просто на форму
            {
                for (int ii = 0; ii < container.getSize(); ii++)
                {
                    container[ii].setSelection(false);
                }
                Base item = new ccircle(p, 50, currentcolor);
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
                    // make brush of current color somehow
                    SolidBrush bruh = new SolidBrush(container[i].getColor());
                    container[i].draw(g, bruh);
                }
                else
                {
                    SolidBrush bruh = new SolidBrush(container[i].getColor());
                    container[i].draw(g, bruh);
                    container[i].drawSelection(g);
                    // make brush of current color somehow
                    
                    container[i].draw(g, bruh);
                }
            }
        }
    }   
}
