using System.Reflection.Metadata;
using System.Transactions;

namespace mod1
{
    enum Figures {Square, Cicrle, Cone}
    struct Fdata
    {
        public int x0, y0;
        public int color;
        public Figures type;
    }

    class Program 
    {
        static void Main()
        {
            Fdata fd = new();
            fd.x0 = 1;
            fd.y0 = 1;
            fd.color=0x2727FF;
            fd.type=Figures.Square;

            Console.WriteLine($"Shape data : {fd.type}");
            Console.WriteLine($"Shape position : x = {fd.x0}, y = {fd.y0}");
            Console.WriteLine($"Shape color : 0x{fd.color:x8}");
        }
    }

    

}
