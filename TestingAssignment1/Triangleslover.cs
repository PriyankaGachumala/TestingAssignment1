using System;
using System.Collections.Generic;
using System.Text;

namespace TestingAssignment1
{
   public static class TriangleSolver
    {
       public static void Analyze()
        {
            string dimensionString1, dimensionString2, dimensionString3;
            int dimension1, dimension2, dimension3;
            int userInput = 0;
            string uInput = string.Empty;
            do
            {
                Console.WriteLine(" 1. Enter triangle dimensions \n 2. Exit");
                Console.Write("Enter your choice:");
                uInput = Console.ReadLine();
            } while (!(int.TryParse(uInput, out userInput)));


            if (userInput == 1)
            {
                Console.Write("Enter dimension1: ");
                dimensionString1 = Console.ReadLine();
                dimension1 = Convert.ToInt32(dimensionString1);

                Console.Write("Enter dimension2: ");
                dimensionString2 = Console.ReadLine();
                dimension2 = Convert.ToInt32(dimensionString2);

                Console.Write("Enter dimension3: ");
                dimensionString3 = Console.ReadLine();
                dimension3 = Convert.ToInt32(dimensionString3);
                // all the given sides should be equal
                if (dimensionString1 == dimensionString2 && dimensionString2 == dimensionString3 && dimensionString1 == dimensionString3)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                // for isosceles any two sides should be equal 
                else if (dimensionString1 == dimensionString2 || dimensionString2 == dimensionString3 || dimensionString1 == dimensionString3)
                {
                    Console.WriteLine("isosceles triangle");
                }
                else
                {
                    Console.WriteLine("Scalene Triangle");
                }
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }
}
