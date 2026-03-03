using System.Diagnostics.CodeAnalysis;

namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
        // si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        int a, b , c, suma, producto;

        Console.WriteLine("Ingrese un numero: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero: ");
        c = int.Parse(Console.ReadLine());
        
        suma = a + b;

        producto = b * c;

        if(suma > producto)
            Console.WriteLine("La suma es mayor al producto");
        else
            Console.WriteLine("La suma no es mayor al producto");
    }     
}
