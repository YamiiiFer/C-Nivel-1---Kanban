namespace Ejercicio12;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función que:
        //reciba 3 números por valor
        //reciba una variable por ref
        //guarde en esa variable el mayor de los tres

    int resultado = 0;

    mayornro(4, 8, 7, ref resultado);

    Console.WriteLine("El mayor es: " + resultado);

    }
    static void mayornro(int a, int b, int c, ref int d)
    {
        int m = a;

        if( b > m)
        {
            m = b;

        }if (c > m)
        {
            m = c;
        }

        d = m;
    }
}
