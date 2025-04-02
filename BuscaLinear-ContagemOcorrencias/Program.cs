using System;

namespace BuscaLinear_ContagemOcorrencias
{
    class Program
    {
        static int ContarOcorrencias(int[] array, int elemento)
        {
            int contagem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    contagem++; // Adiciona mais 1 na contagem
            }
            return contagem;
        }

        static void Main()
        {
            int[] numeros = { 10, 25, 30, 40, 55, 60, 40, 40, 40 };
            int chave = 40;
            int resultado = ContarOcorrencias(numeros, chave);
            Console.WriteLine(resultado > 0 ? $"Elemento encontrado {resultado} vez(es)" : "Elemento não encontrado");
            Console.ReadKey();
        }
    }

}
