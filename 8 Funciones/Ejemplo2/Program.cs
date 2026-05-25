namespace Ejemplo2;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, resultado;

        Console.WriteLine("Ingrese un número:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un número:");
        n2 = int.Parse(Console.ReadLine());

        resultado = sumar(n1 ,n2);

        Console.WriteLine("El resultado es: " + resultado);

    }
        
    static int sumar(int a, int b)
    {
        int r;
        r = a + b;
        return r;
    }
}
