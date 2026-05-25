namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
        //  Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
        //  Informar el promedio teniendo en cuenta sólo los números primos.
        int n;
        int acu = 0;
        int con = 0;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            if (primo(n) == 1)
            {
                acu += n;
                con++;
            }
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
        }
        double promedio = (double)acu / con;

        Console.WriteLine("Promedio: " + promedio);


    }
   
    static int primo(int num)
    {
        int con = 0;
        for (int x = 1; x <= num; x++)
        {
            if(num % x == 0)
                {
                    con++;
                }
        }

        if(con == 2)
        {
            return 1;
        }
        else
        {
            return 0;
        }
        
    }
}
