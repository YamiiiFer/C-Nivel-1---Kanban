using System.Security.Cryptography;

namespace Ejemplo2;

class Program
{
    static void Main(string[] args)
    {
       //For con While
       //Cargo 10 equipos pero no se la cantidad de jugadores 
       // que hay en cada equipo.
       int edad, acu, con, promedio;

       for (int x = 0; x < 10; x++)
       {
            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            acu = 0;
            con = 0;
            while (edad != 0)
            {
                acu += edad;
                con++;
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de edad es: " + promedio);
        }   
    }
}
