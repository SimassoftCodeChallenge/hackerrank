using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare  variables: one of type int, one of type double, and one of type
            //String
            int i = 0;
            double d = 0;
            string s = string.Empty;

            // Read and save an integer, double, and String to your variables.
            i = 4;
            d = 4.0;
            s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int segundoi = int.Parse(Console.ReadLine());
            double segundod;
            //= double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out segundod);
            string segundos = Console.ReadLine();            

            // Print the sum of both integer variables on a new line.
            int somai = i + segundoi;
            double somad = d + segundod;
            string somas = s + segundos;
                        
            Console.WriteLine(somai);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(somad.ToString("F1"));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(somas);
            Console.ReadKey();
        }
    }
}
