using System.Security.Cryptography;

namespace Ejemplo3;

class Program
{
    static void Main(string[] args)
    {
        //while con for
        int edad, acu, con,n, promedio;

        Console.WriteLine("Ingrese 1 p/ continuar o 0 p/ terminar.");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
             acu = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                acu += edad;
            }
            promedio = acu/5;

            Console.WriteLine("El promedio de edad es: " + promedio);
            
            Console.WriteLine("Ingrese 1 p/ continuar o 0 p/ terminar.");
            n = int.Parse(Console.ReadLine());

        }
           
    }
}
