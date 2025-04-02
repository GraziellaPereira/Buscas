using System;

namespace BuscaLinear_MaiorMenor
{
    class Program
    {
        static void EncontrarMaiorMenor(int[] array, out int maiorNum, out int menorNum)
        {
            maiorNum = array[0];
            menorNum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maiorNum)
                {
                    maiorNum = array[i];
                }
                else if (array[i] > maiorNum)
                {
                    menorNum = array[i];
                }
            }
        }

        static void Main()
        {
            int[] numeros = { 10, 25, 30, 40, 55, 60, 40, 40, 40 };
            int maiorNum, menorNum;
            EncontrarMaiorMenor(numeros, out maiorNum, out menorNum);
            Console.WriteLine($"Maior elemento: {maiorNum}");
            Console.ReadKey();
            Console.WriteLine($"Menor elemento: {menorNum}");
            Console.ReadKey();
        }
    }

}
