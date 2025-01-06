using System;
using System.Reflection;

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

    public static class FigureInspector
    {
        public static void PrintInfo(object figure)
        {
            Type type = figure.GetType();
            MethodInfo print = type.GetMethod("PrintInfo"); // Опустим проверку на Null, т.к. все наши классы содержат PrintInfo.
            print.Invoke(figure, null);
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            //Ваш код!
            Circle circle = new (2, 3, 10);
            circle.Move(3, 1);
            circle.PrintInfo();
            Console.WriteLine(circle.Area());

            object[] data = {rect, rt, circle};
            Print(data);
        }

        public static void Print(object[] data)
        {
            foreach (object figure in data)
            {
                //((Rect)figure).PrintInfo();
                /*
                 * System.InvalidCastException: 'Unable to cast object of type 'Geometry.RightTriangle' to type 'Geometry.Rect'.'
                 * Объекты, созданные нами для фигур, для компилятора никак не связаны, поэтому он не может 
                 * преобразовывать их меджу собой. 
                 * Обратимся к нужным методам при помощи GetMethod(), и отдельного клааса-обработчика FigureInspector
                 */
                FigureInspector.PrintInfo(figure);
            }
        }
    }
}
