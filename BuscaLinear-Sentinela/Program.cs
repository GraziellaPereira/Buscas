using System;

namespace BuscaLinear_entinela
{
    class Program
    {
        static int BuscaLinearSentinela(int[] array, int elemento)
        {
            int n = array.Length;
            int ultimo = array[n - 1]; 
            array[n - 1] = elemento;  

            int i = 0;
            while (array[i] != elemento)
            {
                i++;
            }

            array[n - 1] = ultimo; 

            
            if (i < n - 1 || (array[n - 1] == elemento && ultimo == elemento))
                return i;

            return -1;
        
    }
    

        static void Main()
        {
            int[] numeros = { 10, 25, 30, 40, 55, 60 };
            int chave = 40;
            int resultado = BuscaLinearSentinela(numeros, chave);
            Console.WriteLine(resultado != -1 ? $"Elemento encontrado na posição {resultado}" : "Elemento não encontrado");
            Console.ReadKey();
        }
    }

}

