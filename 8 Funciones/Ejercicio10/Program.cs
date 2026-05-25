namespace Ejercicio10;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función que:
        //reciba un número
        //determine si es par o impar
        //guarde el resultado en una variable por ref
        //(1 = par, 0 = impar)

        int n = 4;
        int resultado = 0;

        parOimpar(n, ref resultado );

        Console.WriteLine(resultado);
        
    }
    static void parOimpar(int nro, ref int res)
    {
        if (nro % 2 == 0)
        {
            res = 1;
        }else
            res = 0;
    }
}
