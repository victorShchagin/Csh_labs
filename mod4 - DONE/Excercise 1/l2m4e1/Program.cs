namespace l2m4e1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var argument = 0;
            int sumOfArgmunets = 0;

            foreach (var a in args) 
            {
                bool typeCheck = int.TryParse(a, out argument);
                if (typeCheck)
                {
                    Console.WriteLine(a);
                    argument = int.Parse(a);
                    sumOfArgmunets += argument;
                }
                else
                {
                    Console.WriteLine($"Argument \"{a}\" is not an integer");
                } 
            }
            Console.WriteLine(sumOfArgmunets);
        }
    }
}
