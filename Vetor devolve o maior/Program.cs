using System;

namespace Vetor_devolve_o_maior
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[7];
            int maior = 0;

            for(int i = 0; i < 7; i++)
            {
                int x = int.Parse(Console.ReadLine());
                v[i] = x;
                if (maior < x)
                {
                    maior = x;
                }
            }
            Console.WriteLine(maior);
        }
    }
}
