/*Ejercicio 4: Serie factorial

csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        long factorial = CalcularFactorial(numero);

        Console.WriteLine("El factorial de " + numero + " es: " + factorial);

        Console.ReadLine();
    }

    static long CalcularFactorial(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        else
        {
            long factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
