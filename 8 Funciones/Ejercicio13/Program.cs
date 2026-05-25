namespace Ejercicio13;

class Program
{
    static void Main(string[] args)
    {
        //Dado este código:

        int x = 5;
        int y = 3;

        prueba(ref x, y);

        Console.WriteLine(x);
        Console.WriteLine(y);

    }
     static void prueba(ref int a, int b)
        {
            a = a + b;
            b = b + 10;
        }
}
