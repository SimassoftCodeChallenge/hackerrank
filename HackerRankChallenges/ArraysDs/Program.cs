using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numArray = 0;
            string numeros = string.Empty;            

            Console.Clear();

            numArray = int.Parse(Console.ReadLine());
            numeros = Console.ReadLine();
            string[] resultado = new string[numArray];
            resultado = numeros.Split(' ');
            Array.Reverse(resultado);            

            Console.WriteLine(string.Join(" ",resultado.ToArray()));            
        }
    }
}
