using System;

namespace BuscaLinear_UltimaOcorrencia
{
    class Program
    {
        static void EncontrarUltimoNum(int[] array, out int ultimoNum)
        {
            ultimoNum = array[array.Length - 1];

        }

        static void Main()
        {
            int[] numeros = { 10, 25, 30, 40, 55, 60, 15, 21, 32 };
            int ultimoNum;
            EncontrarUltimoNum(numeros, out ultimoNum);
            Console.WriteLine($"Último número: {ultimoNum}");
            Console.ReadKey();
            
        }
    }

}
