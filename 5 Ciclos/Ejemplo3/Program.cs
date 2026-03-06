namespace Ejemplo3;

class Program
{
    static void Main(string[] args)
    {
        // CICLO DO WHILE 
        // PRIMERO HACE LUEGO SIGUE, HACE AL MENOS UNA VUELTA

         int n, con = 0;


        do{
            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());
            con++;
        }while (n != 0 );

        Console.WriteLine("Ingresaste: " + con + " nros.");
    }
}
