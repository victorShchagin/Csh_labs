using System;

namespace Geometry
{
    abstract class Shape
    {
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
        public virtual void PrintInfo()
        {
            Console.Write(fd.type+":"+fd.x0+","+fd.y0+" color="+fd.color);
        }

        public static bool operator ==(Shape a, Shape b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if ((object)a == null || (object)b == null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Shape sh1, Shape sh2) 
        {
            return !(sh1 == sh2);
        }
    }
}
