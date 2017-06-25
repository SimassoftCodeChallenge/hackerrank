using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviation
{
    class Program
    {
        /// <summary>
        /// Objective 
        ///In this challenge, we practice calculating standard deviation.Check out the
        ///Tutorial tab for learning materials and an instructional video!
        ///Task
        ///Given an array, X, N of  integers, calculate and print the standard deviation.
        ///Your answer should be in decimal form, rounded to a scale of  1 decimal
        ///place (i.e., 12.3 format). An error margin of +-0.1 will be tolerated for the
        ///standard deviation.
        ///
        ///Input Format
        ///
        ///The first line contains an integer, N, denoting the number of elements in the
        ///array. 
        ///The second line contains N space-separated integers describing the
        ///respective elements of the array.
        ///
        ///Constraints
        ///- 5 <= N <= 100
        ///- 0 < x [i] <= 10^5, where x [i] is the i^th element of array X.
        ///
        ///Output Format
        ///
        ///Print the standard deviation on a new line, rounded to a scale of 1 decimal
        ///place(i.e., 12.3 format).
        ///
        ///Sample Input
        ///5
        ///10 40 30 50 20
        ///
        ///Sample Output
        ///14.1
        ///
        ///First.We finde the mean:
        ///Mean = (10 + 40 + 30 + 50 + 20) / 5
        ///
        ///Next, we calculate the squared distance from the mean, (x[i] - Mean) ^ 2, for 
        ///each x[i]:
        ///
        ///1. (x[i] - Mean) ^ 2 = (10 - 30) ^ 2 = 400
        ///2. (x[i] - Mean) ^ 2 = (40 - 30) ^ 2 = 100
        ///3. (x[i] - Mean) ^ 2 = (30 - 30) ^ 2 = 0
        ///4. (x[i] - Mean) ^ 2 = (50 - 30) ^ 2 = 400
        ///5. (x[i] - Mean) ^ 2 = (20 - 30) ^ 2 = 100
        ///
        ///Now we can compute Sum((x[i] - Mean) ^ 2) = 400 + 100 + 0 + 400 + 100 = 1000, 
        ///so:
        ///
        ///Sqrt(Sum((x[i] - Mean) ^ 2) / N) = Sqrt(1000 / 5) = Sqrt(200) = 14.1421356
        ///
        ///Once rounded to a scale of 1 decimal place, our result is 14.1

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            int n = 0;
            string x = string.Empty;
            string[] arrayX = new string[] { };
            double mean = 0.0;
            double squaredDistance = 0;
            double sumOfSquaredDistance = 0;
            double standardDeviation = 0.0;
            
            //Entrada de dados
            int.TryParse(Console.ReadLine(),out n);
            x = Console.ReadLine();
            
            //Converte a entrada em um array de Strings através dos espaços
            arrayX = x.Split(' ');

            //Calcula a Média
            mean = arrayX.Sum(p => double.Parse(p)) / n;

            //Agora calculamos a Distância Quadrada para a média para cada item 
            for (int i=0;i < n;i++)
            {
                squaredDistance = Math.Pow(double.Parse(arrayX[i]) - mean,2);
                sumOfSquaredDistance += squaredDistance;
            }

            //Calcula o desvio padrão
            standardDeviation = Math.Sqrt(sumOfSquaredDistance / n);

            Console.WriteLine(standardDeviation.ToString("F1"));
            Console.ReadKey();
        }
    }
}
