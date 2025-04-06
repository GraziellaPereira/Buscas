using System;
namespace BuscaBinaria_Existencia
{
    class Program
    {
        static bool ExisteNoArray(int[] array, int elemento)
        {
            int inicio = 0, fim = array.Length - 1;


            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2; // Calcula o meio


                if (array[meio] == elemento)
                    return true; // Retorna true se encontrou

                if (array[meio] < elemento)
                    inicio = meio + 1; // Busca na metade direita
                else
                    fim = meio - 1; // Busca na metade esquerda
            }


            return false; // Retorna false se o elemento não foi encontrado
        }


        static void Main()
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70 };
            int chave = 12;
            bool existe = ExisteNoArray(numeros, chave);


            Console.WriteLine(existe ? "Elemento existe no array." : "Elemento não existe no array.");
            Console.ReadKey();
        }
    }
}


