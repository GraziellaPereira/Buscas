using System;
namespace BuscaBinaria_MaiorNumero
{
    class Program
    {
        static int BuscaMaior(int[] array, int elemento, out int maiorNum)
        {
            int inicio = 0, fim = array.Length - 1;
            maiorNum = int.MaxValue;


            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2; // Calcula o meio


                if (array[meio] <= elemento)
                {
                    
                    inicio = meio + 1;

                }

                else
                {
                    maiorNum = array[meio];
                    fim = meio - 1;
                }
                    
            }


            return maiorNum != int.MaxValue ? maiorNum : -1;
        }

        static void Main()
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70 };
            int x = 40;
            int maiorNum;
            int resultado = BuscaMaior(numeros, x, out maiorNum);

            Console.WriteLine($"Menor número maior que {x} é: {resultado}");
            Console.ReadKey();
        }
    }
}


