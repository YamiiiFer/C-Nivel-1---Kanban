using System.Security.AccessControl;

namespace Ejemplo1;

class Program
{
    static void Main(string[] args)
    {
        //Vectores. Array. Arreglo
        //Es una variable dimencional(le doy un tamaño)
        int n, acu = 0;
        int [] numeros = new int[10]; //Declaración del vector

        //  0 1 2 3 4 5 6 7 8 9
        // |7| | | | | |1| | |32450| 

        numeros[6] = 1; // en el índice 6 voy a guardar 6
        numeros[0] = 7; //Asigno
        numeros[9] = 32450;

        /*a = numeros[0] + numeros[6] + numeros[9] + a;// su los valores de los índices

        Console.WriteLine(numeros[6]);
        Console.WriteLine(numeros[0]);
        Console.WriteLine(numeros[a]);*/

        for (int x = 0; x < 10; x++) //Cargo el vector
        {
            Console.WriteLine("Ingrese la nota...");
            n = int.Parse(Console.ReadLine());

            numeros[x] = n;
        }

        for (int x = 0; x < 10; x++)
        {
            acu += numeros[x];
            Console.WriteLine("El valor es: " + numeros[x]);
        }

        int prom = acu / 10;
        
        Console.WriteLine("El promedio es: " + prom);

    }
}
