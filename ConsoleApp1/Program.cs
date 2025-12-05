namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 20;

           
            Console.WriteLine($"Equation: {X} + {Y} = {(X + Y):C}");

          
            double num = 1234.567;
            Console.WriteLine($"Number format (N): {num:N}");

            Console.ReadLine();

        }
    }
}
