using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_alused
{
    internal class ulesanned
    {
        public static void Main(int[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int N = random.Next(-100, 100);
            int M = random.Next(-100, 100);
            if (N<M)
            {
                // int i = M-N
                int arv = N;
                int[] arvud = new int[M-N];
                while (arv<M)
                arvud[M-N] = arv;
                arv++;

            }
            else
            {
                int arv = N;
                int[] arvud = new int[M - N];
                while (arv < M)
                    arvud[M - N] = arv;
                arv++;


                public static int[] Arvude_massiv(int N, int M)
            {
                int arv;
                int[] arvud = new int[M - N];
                for (int i = N; i < M; i++)
                {
                    Console.WriteLine("{0} nimi :", i + 1);
                    arv = N;
                    arvud[i] = arv;
                    N++;
                }
                return arvud;
            }
        }




}       



