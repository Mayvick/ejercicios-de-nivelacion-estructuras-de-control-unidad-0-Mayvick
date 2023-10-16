/*Ejercicio 2: Suma de Dígitos

csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        int suma = 0;

        while (numero != 0)
        {
            int digito = numero % 10;
            suma += digito;
            numero /= 10;
        }

        Console.WriteLine("La suma de los dígitos es: " + suma);
        
        Console.ReadLine();
    }
}
