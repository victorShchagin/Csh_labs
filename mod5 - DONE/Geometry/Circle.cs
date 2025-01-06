using System;

namespace Geometry
{
    public class Circle
    {
        Fdata fd;

        public int X { get; set; }
        public int Y { get; set; }  

        private int r;
        public int R
        {
            get { return r; }
            set 
            {  
                if (value > 0)
                    this.r = value;
                else
                    Console.WriteLine(new ArgumentException("R out of bounds"));
            }
        }

        public Circle(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(R, 2); 
        }
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Circle : x= {X}, y= {Y}, r= {R}");

        }
    }
}