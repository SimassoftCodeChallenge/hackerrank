using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedMean
{
    class Program
    {
        /// <summary>
        /// Given an array,X, of N integers and an array, W,
        /// representing the respective weights of X's elements, calculate and print
        /// the weighted mean of X's elements.
        /// Your answer should be rounded to a scale of
        /// 1 decimal place (i.e.,12.3 format).
        /// Input Format:
        /// The first line contains an integer,N, denoting the number of elements in arrays
        /// X and W.
        /// The second line contains N space-separated integers describing the respective
        /// elements of array X. 
        /// The third line contains N space-separated integers describing the respective
        /// elements of array W.
        /// Constraints
        /// 5 =< N =< 50
        /// 0 < xi =< 100, where xi is the i(th) element of array X.
        /// 0 < wi =< 100, where wi is the i(th) element of array W.
        /// Output Format
        /// Print the weighted mean on a new line.Your answer should be rounded to a scale of decimal place(i.e., format).
        /// Sample Input
        /// 5
        /// 10 40 30 50 20
        /// 1 2 3 4 5
        ///
        /// Sample Output
        /// 32.0
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int n = 0;
            string x = string.Empty;
            string w = string.Empty;
            int somaNumerador = 0;
            int somaDenominador = 0;
            int numerador = 0;
            int denominador = 0;
            double mw = 0;

            //Entrada de dados
            int.TryParse(Console.ReadLine(),out n);
            x = Console.ReadLine();
            w = Console.ReadLine();

            //Conversao dos valores de x e w em arrays
            string[] arrayX = x.Split(' ');
            string[] arrayW = w.Split(' ');            

            //Iteracao dos valores
            for(int i = 0;i < n;i++){
                numerador = int.Parse(arrayX[i]) * int.Parse(arrayW[i]);                
                denominador = int.Parse(arrayW[i]);
                somaNumerador += numerador;
                somaDenominador += denominador;
            }

            mw = (double)somaNumerador / somaDenominador;
            Console.WriteLine(string.Format("{0}",mw.ToString("F1")));
            Console.ReadKey();
        }
    }
}
