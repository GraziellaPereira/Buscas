using System;

namespace BuscaLinear_PalavraEmTexto
{
    class Program
    {
        static int BuscaPalavras(string[] array, string elemento)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    return i; 
            }
            return -1;
        }
        static void Main()
        {
            string palavraChave;
            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();
            texto = texto.Replace(",", "")
                         .Replace(".", "")
                         .Replace(";", "")
                         .Replace(":", "")
                         .Replace("!", "")
                         .Replace("?", "")
                         .Replace("\"", "")
                         .Replace("(", "")
                         .Replace(")", "");

            string[] entrada = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Digite a palavra que você deseja buscar: ");
            palavraChave = Console.ReadLine();
            int resultado = BuscaPalavras(entrada, palavraChave);
            Console.WriteLine(resultado != -1 ? $"Palavra \"{palavraChave}\" encontrada na posição {resultado}" : "Elemento não encontrado");

            Console.ReadKey();
        }

        

       
    }

}
