namespace Ejercicio15;

class Program
{
    static void Main(string[] args)
    {
        /*Hacer una función void que:
        reciba dos números por valor
        reciba una variable por ref
        guarde en esa variable la suma de los dos*/

        int a = 5;
        int b = 3;
        int res = 0;
        suma(a, b, ref res);

        Console.WriteLine(" La suma es: "+ res);
        Console.WriteLine("a = "+a + " b = "+ b);

    }
    static void suma(int a, int b, ref int c)
    {
        c = a + 5 + b; 
    }
}
