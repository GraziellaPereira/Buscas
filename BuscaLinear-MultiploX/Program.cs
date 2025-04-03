using System;

namespace BuscaLinear_MultiploX
{
    class Program
    {
        static bool BuscaLinear(int[] array, int elemento, out int multiplo)
        {
            foreach (int num in array)
            {
                if (num %  elemento == 0)
                {
                    multiplo = num;
                    return true;
                }
            }
            multiplo = -1;
            return false;
            
        }

        static void Main()
        {
            int[] numeros = { 10, 25, 30, 40, 55, 60 };
            int chave = 8;
            int multiplo;
            if (BuscaLinear(numeros, chave, out multiplo))
                Console.WriteLine($"Primeiro número múltiplo de {chave} encontrado = {multiplo}.");
            else
                Console.WriteLine($"Nenhum múltiplo de {chave} encontrado.");

        }
    }

}
