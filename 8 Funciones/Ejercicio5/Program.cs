namespace Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función que:
        //reciba un número
        //devuelva su triple

        int n;

        Console.WriteLine("Ingrese un nro para que devolvamos su tripe");
        n = int.Parse(Console.ReadLine());

        int resultado = triple(n);

        Console.WriteLine("El triple de " + n + " es: " + resultado);
    }

    static int triple(int nro)
    {
        return nro * 3;

    }
}

