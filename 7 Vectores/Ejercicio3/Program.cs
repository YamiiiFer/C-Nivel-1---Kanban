namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio.
        //  Mostrar por pantalla los valores que son mayores al promedio.


        int[] numeros = new int[10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numeros[x] = int.Parse(Console.ReadLine());
        }
        int acu = 0;

        for (int x = 0; x < 10; x++)
        {
            acu += numeros[x];
        }

        double promedio = (double)acu / 10;

        for (int x = 0; x < 10; x++)
        {
            if (numeros[x] > promedio)
                {
                    Console.WriteLine("El número " + numeros[x] + " es mayor al promedio.");
                }
        }
        
        
    }
}
