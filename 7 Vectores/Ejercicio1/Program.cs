using System.Data;

namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y
        //  su posición dentro del vector.[]

        //Creo un vector llamado numeros, de tipo entero, con 10 posiciones
        int[] numeros = new int[10];

        //Cargo el vector
        for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                numeros[x] = int.Parse(Console.ReadLine());
            }
        //Declaro e Inicializo las variables maximo y posición
        int maximo = numeros[0];
        int posicion = 0;

        for (int x = 0; x < 10; x++)
        {
            if(numeros[x] > maximo)
            {
                maximo =  numeros[x];
                posicion = x;
            }
        }
        Console.WriteLine("El máximo es: " + maximo);
        Console.WriteLine("Está en la posición: " + ( posicion + 1));
        
    }
}
