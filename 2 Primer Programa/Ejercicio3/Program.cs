using Microsoft.Win32.SafeHandles;

namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
      float kilometros, velocidad, resultado;

      Console.WriteLine("Ingrese los kilometros existentes entre las ciudades: ");
      kilometros = float.Parse(Console.ReadLine());

      Console.WriteLine("Ingrese la velocidad: ");
      velocidad = float.Parse(Console.ReadLine());

      resultado = kilometros/velocidad;

      Console.WriteLine("El tiempo en llegar es de: " + resultado.ToString("0.00") + " horas");


    }
}
