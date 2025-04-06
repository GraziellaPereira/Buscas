using System;

namespace BuscaBinaria_UltimaOcorrencia
{
    class Program
    {
        static int UltimaOcorrencia(int[] array, int elemento)
        {
            int inicio = 0, fim = array.Length - 1;
            int resultado = -1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;

                if (array[meio] == elemento)
                {
                    resultado = meio;
                    inicio = meio + 1; //decarta a metade à esquerda
                }
                else if (array[meio] < elemento)
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }
            }

            return resultado;
        }

        static void Main()
        {
            int[] numeros = { 10, 20, 20, 20, 20, 20, 30, 40 };
            int x = 20;

            int posicao = UltimaOcorrencia(numeros, x);

            Console.WriteLine(posicao != -1 ? $"Última ocorrência de {x} na posição {posicao}" : $"Número {x} não encontrado");

            Console.ReadKey();
        }
    }
}
