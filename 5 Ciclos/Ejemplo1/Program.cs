using System.Security.Cryptography.X509Certificates;

namespace Ejemplo1;

class Program
{
    static void Main(string[] args)
    {
        // CICLO FOR
        
       // for(int x = 0; x < 5; x++){

       //     Console.WriteLine("Hello, World!" + (x + 1));}

       int n = 0, promedio, suma = 0;

       for (int x = 0; x < 10; x++){

            Console.WriteLine("Ingrese la nota: ");
            n = int.Parse(Console.ReadLine());
            suma += n;
       }
       promedio = suma / 5;
       Console.WriteLine("El promedio de notas es: " + promedio);
    }
}
