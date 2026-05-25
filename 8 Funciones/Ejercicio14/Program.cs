namespace Ejercicio14;

class Program
{
    static void Main(string[] args)
    {

        //Hacer una función que:
        //reciba un número por ref
        //si es negativo → lo convierta a positivo
        //si ya es positivo → lo deje igual

        int a = 5;

        convertir(ref a);
        Console.WriteLine(a);
    }

    static void convertir(ref int n)
    {
        if (n < 0)
        {
            n = (-(n));
        }else
        {
            n = (+n);
        }
    }

}
