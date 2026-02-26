namespace Ejemplo1;

class Program
{
    static void Main(string[] args)
    {
        //Bloque IF: CONDICIONALES.
        // VALOR OP VALOR -> condicion  logíca

        int edad = 14;

        if(edad > 30)
            Console.WriteLine("30 OFF");
        else if(edad > 20)
            Console.WriteLine("21% OFF");
        else if(edad == 18)
            Console.WriteLine("10% OFF");
        else
            Console.WriteLine("5% OFF");
        Console.WriteLine("Fin del Programa");
    }
}
