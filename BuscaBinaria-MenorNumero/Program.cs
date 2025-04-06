using System;
namespace BuscaBinaria_MenorNumero
{
    class Program
    {
        static int BuscaMenor(int[] array, int elemento, out int menorNum)
        {
            int inicio = 0, fim = array.Length - 1;
            menorNum = int.MinValue;


            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2; // Calcula o meio


                if (array[meio] < elemento)
                {
                    menorNum = array[meio];
                    inicio = meio + 1; 

                }

                else
                    fim = meio - 1; 
            }


            return menorNum != int.MinValue ? menorNum : -1;
        }

        static void Main()
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70 };
            int x = 40;
            int menorNum;
            int resultado = BuscaMenor(numeros, x, out menorNum);

            Console.WriteLine($"Maior número menor que {x} é: {resultado}");
            Console.ReadKey();
        }
    }
}


