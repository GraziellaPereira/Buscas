using System;

namespace BuscaLinear_Basico {
    class Program
    {
        static int BuscaLinear(int[] array, int elemento)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    return i; // Retorna o índice do elemento encontrado
            }
            return -1; // Retorna -1 se o elemento não for encontrado
        }

        static void Main()
        {
            int[] numeros = { 10, 25, 30, 40, 55, 60 };
            int chave = 40;
            int resultado = BuscaLinear(numeros, chave);
            Console.WriteLine(resultado != -1 ? $"Elemento encontrado na posição {resultado}" : "Elemento não encontrado");
            Console.ReadKey();
        }
    }

}
