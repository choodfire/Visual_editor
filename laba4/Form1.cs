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
        public int currentshape; // 1 - circle, 2 - square

        public Form1()
        {
            InitializeComponent();
            container = new Container<Base>();
            currentcolor = Color.Blue;
            currentshape = 1;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                cgroup group = new cgroup();
                int size = container.getSize();

                for (int i = 0; i < size; i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        Base item = container[i];
                        group.addToGroup(item);
                        container.deleteObject(i);
                        size -= 1;
                        i -= 1;
                    }
                }
                container.addObject(group);
                pictureBox1.Invalidate();
            }
            if (e.KeyCode == Keys.C)
            {
                currentshape = 1;
                label_shape.Text = "Текущая фигура - \nкруг";
            }
            if (e.KeyCode == Keys.S)
            {
                currentshape = 2;
                label_shape.Text = "Текущая фигура - \nквадрат";
            }
            if (e.KeyCode == Keys.T)
            {
                currentshape = 3;
                label_shape.Text = "Текущая фигура - \nтреугольник";
            }
            if (e.KeyCode == Keys.G)
            {
                currentcolor = Color.Green;
                label_color.Text = "Текущий цвет - \nзелёный";
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
                label_color.Text = "Текущий цвет - \nсиний";
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
                label_color.Text = "Текущий цвет - \nжёлтый";
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
                int Size = container.getSize();
                for (int i = 0; i < container.getSize(); i++)
                {
                    if (container[i].getSelection() == true)
                    {
                        container.deleteObject(i);
                        i -= 1;
                        Size -= 1;
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
                if (currentshape == 1)
                {
                    Base item = new ccircle(p, 50, currentcolor);
                    container.addObject(item);
                }
                else if (currentshape == 2)
                {
                    Base item = new csquare(p, 50, currentcolor);
                    container.addObject(item);
                }
                else if (currentshape == 3)
                {
                    Base item = new ctriangle(p, 43, currentcolor);
                    container.addObject(item);
                }


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
                    SolidBrush bruh = new SolidBrush(container[i].getColor());
                    container[i].draw(g, bruh);
                }
                else
                {
                    SolidBrush bruh = new SolidBrush(container[i].getColor());
                    //container[i].draw(g, bruh);
                    container[i].drawSelection(g);
                    
                    container[i].draw(g, bruh);
                }
            }
            pictureBox1.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_shape_Click(object sender, EventArgs e)
        {

        }
    }   
}
