using System;

namespace BuscaLinear_ListaStrings
{
    class Program
    {
        static int BuscaStrings(string[] array, string elemento)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    return i; // Retorna a posição
            }
            return -1;
        }

        static void Main()
        {
            string[] nomes = {"Jessica", "Ana", "Luiz", "Pedro", "Carla", "Eliana", "Claudio"};
            string chave = "Pedro";
            int resultado = BuscaStrings(nomes, chave);
            Console.WriteLine(resultado != -1 ? $"Elemento encontrado na posição {resultado}" : "Elemento não encontrado");
            Console.ReadKey();
        }
    }

}
