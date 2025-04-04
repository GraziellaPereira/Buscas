using System;

namespace BuscaLinear_PrimeiroPar
{
    class Program
    {
        static bool BuscaPrimeiroPar(int[] array, out int primeiroPar)
        {
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    primeiroPar = num;
                    return true;
                }
            }
            primeiroPar = -1;
            return false;

        }

        static void Main()
        {
            int[] numeros = { 17, 10, 25, 30, 40, 55, 60 };
            int primeiroPar;
            if (BuscaPrimeiroPar(numeros, out primeiroPar))
                Console.WriteLine($"Primeiro número par encontrado: {primeiroPar}");
            else
                Console.WriteLine($"Nenhum número par encontrado.");

        }
    }

}
