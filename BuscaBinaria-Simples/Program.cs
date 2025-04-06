using System;
namespace BuscaBinaria_Simples
{
    class Program
    {
        static int BuscaBinaria(int[] array, int elemento)
        {
            int inicio = 0, fim = array.Length - 1;


            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2; // Calcula o meio


                if (array[meio] == elemento)
                    return meio; // Retorna o índice se encontrou

                if (array[meio] < elemento)
                    inicio = meio + 1; // Busca na metade direita
                else
                    fim = meio - 1; // Busca na metade esquerda
            }


            return -1; // Retorna -1 se o elemento não foi encontrado
        }


        static void Main()
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70 };
            int chave = 50;
            int resultado = BuscaBinaria(numeros, chave);


            Console.WriteLine(resultado != -1 ? $"Elemento encontrado na posição {resultado}" : "Elemento não encontrado");
            Console.ReadKey();
        }
    }
}


