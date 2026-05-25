namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //Enunciado

        //Hacer un programa que:

        //solicite 8 números enteros
        //los guarde en un vector
        //luego recorra el vector
        //determine cuál es el número menor e informe también en qué posición está.

        //Declaro el vector:
        int[] numeros = new int[8];

        //Guardo los números en un vector

        for (int x = 0; x < 8; x++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[x] = int.Parse(Console.ReadLine());
        } 

        int minimo = numeros[0];
        int posicion = 0;

        for (int x = 0; x < 8; x++)
        {
            if(numeros[x] < minimo)
            {
                minimo = numeros[x];
                posicion = x;
            }
                
        }
        Console.Write("El número mínimo es: " + minimo);
        Console.Write(". Se encuentra en la posición : " + (posicion + 1));
    }
}
