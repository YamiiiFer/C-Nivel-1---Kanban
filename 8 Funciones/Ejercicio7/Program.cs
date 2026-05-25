namespace Ejercicio7;

class Program
{
    static void Main(string[] args)
    {
        //Dado este código, decí qué imprime:
        int x = 20;

        Cambiar(ref x);

        Console.WriteLine(x);
    }
     static void Cambiar(ref int n)
        {
            n = 100;
            
        }
}
