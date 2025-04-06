using System;

namespace BuscaBinaria_NumeroMaisProximo
{
    class Program
    {
        static int NumeroMaisProximo(int[] array, int x)
        {
            int inicio = 0, fim = array.Length - 1;
            int maisProximo = array[0];
            int menorDiferenca = Math.Abs(array[0] - x);

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                int valor = array[meio];
                int diferenca = Math.Abs(valor - x);

                if (diferenca < menorDiferenca ||
                   (diferenca == menorDiferenca && valor < maisProximo)) 
                {
                    maisProximo = valor;
                    menorDiferenca = diferenca;
                }

                if (valor < x)
                    inicio = meio + 1;
                else if (valor > x)
                    fim = meio - 1;
                else
                    return valor; 
            }

            return maisProximo;
        }

        static void Main()
        {
            int[] numeros = { 10, 20, 30, 40, 50, 60, 90};
            int x = 70;

            int resultado = NumeroMaisProximo(numeros, x);

            Console.WriteLine($"Número mais próximo de {x} é: {resultado}");
            Console.ReadKey();
        }
    }
}
