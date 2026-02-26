using System.ComponentModel.DataAnnotations;

namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
       // 4. Hacer un programa para ingresar cuatro números distintos y
       //  luego mostrar por pantalla el menor de ellos.

       int n1, n2, n3, n4;
       int menor;

       Console.WriteLine("Ingrese un numero");
       n1 = int.Parse(Console.ReadLine());

       Console.WriteLine("Ingrese un numero");
       n2 = int.Parse(Console.ReadLine());

       Console.WriteLine("Ingrese un numero");
       n3 = int.Parse(Console.ReadLine());

       Console.WriteLine("Ingrese un numero");
       n4 = int.Parse(Console.ReadLine());

       // Asumo que el menor es el primero
       menor = n1;

       // Comparo con los demás
       if(n2 < menor)
          menor = n2;

       if(n3 < menor)
           menor = n3;

       if(n4 < menor)
           menor = n4;
    
       Console.WriteLine("El mayor es: "+ menor);
    }
}
