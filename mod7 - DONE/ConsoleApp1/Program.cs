using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        ~Program()
        {
            Console.WriteLine("Destructor called");
        }

        public static void CreateTrash()
        { 
            Program program = new Program();
        }
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string type = stringBuilder.GetType().ToString();

            Console.WriteLine(type);

            int input = 10;
            bool output = Convert.ToBoolean(input);
            Console.WriteLine(output);

            CreateTrash();
            GC.Collect();
            Console.Read();
        }
    }
}
