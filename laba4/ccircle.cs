using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO; 
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
        public ccircle()
        {}

        public override void draw(Graphics g) 
        {
            SolidBrush bb = new SolidBrush(this.color);
            g.FillEllipse(bb, this.point.X - size / 2, this.point.Y - size / 2, size, size);
        }
        public override void drawSelection(Graphics g)
        {
            g.FillEllipse(Brushes.Red, this.point.X - (size + 10) / 2, this.point.Y - (size + 10) / 2, size + 10, size + 10);
        }
        public override string getClassname() 
        {
            return "Circle";
        }
        public override void save(StreamWriter sw) 
        {
            //string path = @"C:\Users\zzzly\Desktop\oop.txt";
            //string text = getClassname() + "\n" + point.X.ToString() + "\n" + point.Y.ToString() + "\n" + 
            //color.ToString() + "\n" + size;

            sw.WriteLine(getClassname());
            sw.WriteLine(point.X.ToString());
            sw.WriteLine(point.Y.ToString());
            sw.WriteLine(color.ToString());
            sw.WriteLine(size);
        }
        public override void load(StreamReader s, factory f)
        {
            //string x = s.ReadLine();
            //string y = s.ReadLine();
            //string colorr = s.ReadLine();

            this.point.X = Convert.ToInt32(s.ReadLine());
            this.point.Y = Convert.ToInt32(s.ReadLine());
            string colorr = s.ReadLine();
            size = Convert.ToInt32(s.ReadLine());

            if (colorr == "Color [Blue]")
                color = Color.Blue;
            if (colorr == "Color [Yellow]")
                color = Color.Yellow;
            if (colorr == "Color [Green]")
                color = Color.Green;
        }

    }
}
