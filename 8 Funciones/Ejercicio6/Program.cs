namespace Ejercicio6;

class Program
{
    static void Main(string[] args)
    {
       //Hacer una función void que:
        //reciba un número por ref
        //lo aumente en 5

        int nro;
        int resultado = aumentar(ref nro);

        Console.WriteLine(nro + " + 5 = " +resultado);

    }
    static void aumentar(ref int n)
    {
        n = n + 5;
    }
}
