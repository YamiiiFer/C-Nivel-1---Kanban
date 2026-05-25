namespace Ejercicio7;

class Program
{
    static void Main(string[] args)
    {
         //🧩 EJERCICIO 2 — Vector tipo artículos (muy parecido)
          // Enunciado

            // Una librería vende 12 tipos de cuadernos.

            // Cada venta registra:

            // número de cuaderno (1 a 12)
            // cantidad vendida

            // Finaliza con número 0.

            // Se pide informar:

            // a) cuál fue el cuaderno más vendido
            // b) cuáles no tuvieron ventas
            // c) cuántas unidades se vendieron del cuaderno 5

            int[] cuadernos = new int[12];

            int numero;
            int cantidad;

            Console.WriteLine("Ingrese el numero de cuaderno: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el numero de cuaderno: ");
                numero = int.Parse(Console.ReadLine());
            }

            int max = cuadernos[0];

            for (int x = 1; x < 12; x++)
            {
                
                if (cuadernos[x] > max)
                {
                    cuadernos[x] = max;
                }
            }
            Console.WriteLine("El cuaderno mas vendido fue el Nro: " + numero );

            for (int x = 0; x < 12; x++)
            {
                if (cuadernos[x] == 0)
                {
                    Console.WriteLine("No tuvo ventas cuaderno nro: " + (numero - 1) );
                }
            }
    }
}
