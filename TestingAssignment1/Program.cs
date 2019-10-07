using System;

namespace TestingAssignment1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string uInput = string.Empty;
            int a, b, c;
            do
            {
                Console.WriteLine(" 1. Enter triangle dimensions \n 2. Exit");
                Console.Write("Enter your choice:");
                uInput = Console.ReadLine();
            
            
            if (uInput=="1")
            {
                Console.Write("Enter dimension1: ");
                int.TryParse(Console.ReadLine(),out a);

                Console.Write("Enter dimension2: ");
                int.TryParse(Console.ReadLine(), out b);

                Console.Write("Enter dimension3: ");
                int.TryParse(Console.ReadLine(), out c);

                Console.WriteLine(TriangleSolver.Analyze(a, b, c));
            }
            else 
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
            } while (! (uInput == "2"));
        }
    }
}
