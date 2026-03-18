using System.ComponentModel.DataAnnotations;

namespace Ejercicio22;

class Program
{
    static void Main(string[] args)
    {
        //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
       //  Se pide determinar e informar:

    //a) El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    //b) Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

    int n, conImp, conNros, porImp, porMax, grupoImpMax = 0, min, conOrd = 0;
    bool banOrd;

    for (int x = 0; x < 5; x++)
    {
        Console.WriteLine("Grupo: " + (x+1));
        conImp = 0;
        conNros = 0;
        porMax = 0;
        banOrd = true;

        Console.WriteLine("Ingrese un nro");
        n = int.Parse(Console.ReadLine());

        min = n;
        
        while (n != 0)
        {

            if (n % 2 != 0)
            {
                conImp++;
            }
            conNros++;

            if (n <= min)
            {
                min = n;
            }else
            {
                banOrd = false;
            }

            Console.WriteLine("Ingrese un nro");
            n = int.Parse(Console.ReadLine());
        }
        porImp = conImp * 100 / conNros;
        Console.WriteLine("Porcentaje de Impares: " + porImp);
  
        if (porImp > porMax)
        {
            porMax = porImp;
            grupoImpMax = x + 1;
        }
        if (banOrd)
        {
            conOrd++;
        }
    }
    Console.WriteLine("El grupo con mayor porcentaje de nros impares es: " + grupoImpMax);
    Console.WriteLine("Hay " + conOrd + " grupos ordenados de mayor a menor.");
    }
}
