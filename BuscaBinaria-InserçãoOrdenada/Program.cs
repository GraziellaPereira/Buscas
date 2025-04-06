using System;

namespace BuscaBinaria_InsercaoOrdenada
{
    class Program
    {
        static int BuscaPosicao(int[] array, int elemento)
        {
            int inicio = 0, fim = array.Length;

            while (inicio < fim)
            {
                int meio = (inicio + fim) / 2;

                if (array[meio] < elemento)
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio;
                }
            }

            return inicio; 
        }

        static void Main()
        {
            int[] numeros = { 10, 20, 30, 50, 70};
            int novoNumero = 60;

            int posicao = BuscaPosicao(numeros, novoNumero);

            Console.WriteLine($"O número {novoNumero} deve ser inserido na posição {posicao}.");
            Console.ReadKey();
        }
    }
}
