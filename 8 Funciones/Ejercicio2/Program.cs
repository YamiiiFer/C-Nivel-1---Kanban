namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        /*2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
         Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.*/

         int[] numeros = new int[5];

         for (int x = 0; x < 5; x++)
         {
            Console.WriteLine("Ingrese un nro: ");
            numeros[x] = int.Parse(Console.ReadLine());
         }

         int contadorPares = 0;

         for (int x = 0; x < 5; x++)
         {
            contadorPares += par(numeros[x]);

         }
         Console.WriteLine("Cantidad de pares: " + contadorPares);
    }

    static int par(int a)
    {
        if (a % 2 == 0)
        {
            return 1;

        }else
        {
            return 0;
        }
    }
}
