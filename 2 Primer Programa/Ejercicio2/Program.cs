namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = numero * numero * numero;

        Console.WriteLine("El número elevado al cubo es: " + resultado);
    
    }
}
