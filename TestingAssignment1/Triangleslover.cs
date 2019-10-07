using System;
using System.Collections.Generic;
using System.Text;

namespace TestingAssignment1
{
   public static class TriangleSolver
    {
       public static string Analyze(int a, int b, int c)
        {
            String result = String.Empty;
            if (((a + b) > c) && ((c + b) > a) && ((a + c) > b)) {
                result = "";
                
                // all the given sides should be equal
                 if (a == b && b == c && c == a)
                {
                    // Console.WriteLine(TriangleType.Equilateral);
                    result+= "Equilateral Triangle";
                }
                // for isosceles any two sides should be equal 
                else if (a == b || b == c || a == c)
                {
                    //Console.WriteLine(TriangleType.isosceles);
                    result += "Isosceles Triangle";
                }
                
                else 
                {
                    //Console.WriteLine(TriangleType.Scalene);
                    result += "Scalene Triangle";
                }
               
            }
              
            else
            {
                // Console.WriteLine(TriangleType.NotaTriangle);
                result= "Not a Triangle";
            }
            return result;
        }
    }
}
