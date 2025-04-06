using System;
namespace BuscaBinaria_PalavrasOrdenadas
{
    class Program
    {
        static int BuscaPalavra(string[] array, string elemento)
        {
            int inicio = 0, fim = array.Length - 1;


            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                int comparacao = string.Compare(array[meio], elemento, StringComparison.OrdinalIgnoreCase);

                if (comparacao == 0)
                    return meio;

                if (comparacao < 0)
                    inicio = meio + 1; 
                else
                    fim = meio - 1; 
            }


            return -1; 
        }


        static void Main()
        {
            string[] palavras = {"amor", "cola", "abacate", "fogo", "esqueleto", "torre", "banco", "pé"};
            Array.Sort(palavras);
            string palavraChave = "esqueleto";
            int resultado = BuscaPalavra(palavras, palavraChave);


            Console.WriteLine(resultado != -1 ? $"Palavra encontrada na posição {resultado}" : "Palavra não encontrada");
            Console.ReadKey();
        }
    }
}


