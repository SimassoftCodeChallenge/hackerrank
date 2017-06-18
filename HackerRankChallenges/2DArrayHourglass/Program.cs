using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayHourglass
{
    class Program
    {
        /// <summary>
        /// Um solução utilizando a notação O(n^2)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Entrada de dados            
            //int[,] valores = new int[6,6]{
            //    {1,1,1,0,0,0},
            //    {0,1,0,0,0,0},
            //    {1,1,1,0,0,0 },
            //    {0,0,2,4,4,0},
            //    {0,0,0,2,0,0 },
            //    {0,0,1,2,4,0 }
            //};
            int[,] valores = new int[6, 6];
            IList<int> temporario = new List<int>();
            string linhaEntrada = string.Empty;


            //popula os valores no array
            for (int linha = 0; linha < 6; linha++)
            {
                linhaEntrada = Console.ReadLine();
                string[] numArrayLinha = new string[6];
                numArrayLinha = linhaEntrada.Split(' ');                
                for (int coluna = 0; coluna < 6; coluna++)
                {                                                                                
                    valores[linha, coluna] = int.Parse(numArrayLinha[coluna]);
                }                
            }
            
            //[k = 1][k = 2][k = 3] //i = 1
            //       [k = 3]        //i = 2
            //[k = 1][k = 2][k = 3] //i = 3
            //i = linhas, k =colunas
            for (int linha = 0;linha < 4; linha++)
            {
                for(int coluna = 0; coluna < 4; coluna++)
                {
                    temporario.Add(valores[linha, coluna] + valores[linha, coluna + 1] + valores[linha, coluna + 2] //linha 1
                        + valores[linha + 1, coluna + 1] //linha 2
                        + valores[linha + 2, coluna] + valores[linha + 2, coluna + 1] + valores[linha + 2,coluna + 2]); //linha 3
                    //maximo = Math.Max(temporario, maximo);                    
                }
            }
            Console.WriteLine(temporario.Max());
            Console.ReadKey();
        }
    }
}
