namespace Ejemplo1;

class Program
{
    static void Main(string[] args)
    {
        // AND Y OR.....NOT
        //AND {Y} Operador: &&
        //OR {O} Operador: ||

        int edad = 30;
        char inicial = 'A';

        if(!(inicial == 'H' || inicial == 'J') && edad > 20 ){
            Console.WriteLine("21 OFF...");
        }

        Console.WriteLine("Fin del Programa");
    
    }
}

