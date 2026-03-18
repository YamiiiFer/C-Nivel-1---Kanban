namespace Ejemplo1;

class Program
{
    static void Main(string[] args)
    {
        //Ciclos Combinados

        //For con For
        //Calcular el promedio de edad de cada equipo de futbol

        int n, promedio, acu;

        for (int y = 0; y < 2; y++)
        {   
            acu = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu += n;
            }
            promedio = acu/5;

            Console.WriteLine("El promedio de edad es: " + promedio);
        }
    }
}
