using System;
using System.Collections.Generic;

namespace BuscaBinaria_MultiplosElementos
{
    class Program
    {
        static List<int> BuscaMultiElementos(int[] array, int elemento)
        {
            List<int> posicoes = new List<int>();

            int inicio = 0, fim = array.Length - 1;
            int encontrado = -1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;

                if (array[meio] == elemento)
                {
                    encontrado = meio;
                    break;
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

            // Não encontrou
            if (encontrado == -1)
            {
                return posicoes;
            }
               
            // Adiciona no posicoes o elemento encontrado
            posicoes.Add(encontrado);

            // Verifica à esquerda
            int i = encontrado - 1;
            while (i >= 0 && array[i] == elemento)
            {
                posicoes.Add(i);
                i--;
            }

            // Verifica à direita
            i = encontrado + 1;
            while (i < array.Length && array[i] == elemento)
            {
                posicoes.Add(i);
                i++;
            }

            // Ordena as posições antes de retornar
            posicoes.Sort();
            return posicoes;
        }

        static void Main()
        {
            int[] numeros = { 10, 20, 30, 30, 30, 30, 40, 50, 60, 70 };
            int chave = 30;

            List<int> resultados = BuscaMultiElementos(numeros, chave);

            if (resultados.Count > 0)
            {
                Console.WriteLine($"Elemento {chave} encontrado nas posições: {string.Join(", ", resultados)}");
            }
            else
            {
                Console.WriteLine("Elemento não encontrado.");
            }

            Console.ReadKey();
        }
    }
}
