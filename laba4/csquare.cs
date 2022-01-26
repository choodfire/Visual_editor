using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace laba4
{
    class csquare : Base
    {
        public csquare(Point point, int side_length, Color color)
        {
            this.point = point;
            this.isSelected = true;
            this.size = side_length;
            this.color = color;
        }

        public override void draw(Graphics g)
        {
            SolidBrush bb = new SolidBrush(this.color);
            g.FillRectangle(bb, this.point.X - size / 2, this.point.Y - size / 2, size, size);
        }
        public override void drawSelection(Graphics g)
        {
            g.FillRectangle(Brushes.Red, this.point.X - (size + 10) / 2, this.point.Y - (size + 10) / 2, size + 10, size + 10);
        }
        public override string getClassname()
        {
            return "Square";
        }
        public override void save()
        {
            string path = @"C:\Users\zzzly\Desktop\oop.txt";
            string text = getClassname() + "\n" + point.X.ToString() + "\n" + point.Y.ToString() + "\n" + color.ToString() + "\n";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(text);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
