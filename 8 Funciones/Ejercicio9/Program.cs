namespace Ejercicio9;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función void que:
        //reciba un número por valor
        //reciba otro por ref
        //guarde en el de ref el doble del primero
        int a = 3;
        int b = 5; 

        doble(a, ref b);

        Console.WriteLine(b);
      
    }
    static void doble(int a, ref int b)
    {
        b = a * 2;
    }
}
