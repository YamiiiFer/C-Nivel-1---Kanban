using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Ejercicio8;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función que:
        //reciba dos números por ref
        //intercambie sus valores
        int a = 2;
        int b = 6;

        intercambiar(ref a, ref b);
        Console.WriteLine("a = " +a+ " ,b = "+b);

    }
    static void intercambiar(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }
}
