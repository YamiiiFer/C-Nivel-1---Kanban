namespace Ejemplo4;

class Program
{
    static void Main(string[] args)
    {
        //WHILE con WHILE
        int edad, acu, con, n, promedio;

        Console.WriteLine("Ingrese 1 para comenzar");
        n = int.Parse(Console.ReadLine());

        while (n > 0 )
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

            Console.WriteLine("Ingrese 1 p/ continuar o 0 p/ terminar. ");
            n = int.Parse(Console.ReadLine());

        }
            
    }
}
