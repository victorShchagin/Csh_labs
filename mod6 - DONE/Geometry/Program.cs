using System;

namespace Geometry
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);

            //Ваш код!
            Circle c = new Circle(new Fdata() { x0 = 1, y0 = 1, a = 1 });
            c.Move(-2, 5);

            Shape[] data = {rect, rt, c};

            Print(data);
        }

        public static void Print(Shape[] data)
        {
			foreach(Shape shape in data) {
				shape.PrintInfo();
                Console.WriteLine("\n==========");
			}
        }
    }
}
