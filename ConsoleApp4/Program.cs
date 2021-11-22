using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static int pesquisaBinaria(int[] vetor, int tl, int chave)
        {
            int ip = 0;
            int ip1 = 0;
            int meio;
            int Min = 0;
            int Max = tl - 1;
            int p = -1;
            do
            {

                meio = (int)(Min + Max) / 2;
                if (vetor[meio] == chave)
                {
                    p = meio;
                    Console.WriteLine(1 + "-interação retirou 0,pois esta no meio ");
                    break;




                }
                else if (chave > vetor[meio])
                {
                    Min = meio + 1;
                }
                else
                {
                    Max = meio - 1;

                }
                for (int i = Min; i <= Max; i++)
                {

                    ip = tl - meio - ip1;
                    ip1 = ip - 1;
                    Console.WriteLine((i + 1) + "-interação retirou " + ip);

                }

            }
            while (Min <= Max);
            return p;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new Int32[x];
            int tl = x;
            int pos = 0;
            int p = -1;

            Console.WriteLine("Informe os valores do vetor");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Vetor posição" + i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Informe os valores que desejar buscar");
            int valor = Convert.ToInt32(Console.ReadLine());

            pos = pesquisaBinaria(vetor, tl, valor);
            if (pos == -1)
            {
                Console.WriteLine("Valor Não encontrado:" + p);
            }
            else
            {
                Console.WriteLine("Valor encontrado na posicao " + pos);
            }

        }


    }
}

