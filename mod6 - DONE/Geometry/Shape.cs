using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {
        public string Color { get; set; }
        protected Fdata fd;

        public Shape(Fdata fd)
        {
            this.fd = fd;
        }
        public abstract double Area();
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
        }
    }
}
