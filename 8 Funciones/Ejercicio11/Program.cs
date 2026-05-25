namespace Ejercicio11;

class Program
{
    static void Main(string[] args)
    {
       //Simular un cajero:
        //Hacer una función que:
        //reciba un saldo por ref
        //reciba un monto
        //si hay dinero suficiente → lo descuente
        //si no → no haga nada
        int saldo = 400;
        int monto = 500;

        cajero(ref saldo, monto);

        Console.WriteLine(saldo);
    }

    static void cajero( ref int saldo, int monto)
    {
        if (saldo >= monto)
        {
            saldo = saldo - monto;
        }else
        {
            Console.WriteLine("Saldo Insuficiente");
        }
    }
}
