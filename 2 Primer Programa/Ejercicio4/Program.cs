using System.Drawing;
using System.Runtime.InteropServices;

namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        float sueldoFijo = 15000;
        float comision = 0.05f;
        float totalFacturado;
        float sueldoTotal;

        Console.WriteLine("Ingrese el total facturado: ");
        totalFacturado = float.Parse(Console.ReadLine());
        
        sueldoTotal = sueldoFijo + (totalFacturado * comision);

        Console.WriteLine("El sueldo total es: " + sueldoTotal);

    }
}
