using System.Diagnostics;

namespace Ejemplo2;

class Program
{
    static void Main(string[] args)
    {
        //Switch Va a tener una variable a evaluar no una condicion logica

        char letra = 'A';
        switch (letra){
            case 'M':
                Console.WriteLine("TU NOMBRE COMIENZA CON M ");
                break;
            case 'H':
                //HSAGDD
                break;
            default:
                //no coincide con ninguna
                break;
        }
    }
}
