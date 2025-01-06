using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool factorial(int n, out long fac)
        {
            fac = 1;

            try
            {
                for (int i = 1; i <= n; ++i)
                {
                    checked 
                    {
                        fac *= i;
                    }
                }
                return true;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return false;   
            }
        }

        static void Main(string[] args)
        {
            int validNumber = 14;
            int invalidNumber = 124567;
            long output;

            Console.WriteLine($"{factorial(validNumber, out output)} : {validNumber}! = {output}");
            Console.WriteLine("\n==============\n");
            Console.WriteLine($"{factorial(invalidNumber, out output)} : {invalidNumber}! = {output}");
        }
    }
}
