namespace Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
    //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
    //- Número de Artículo (1 a 15)
    //- Cantidad Vendida 

    //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
    //Se pide determinar e informar:
    //a) El número de artículo que más se vendió en total.
    //b) Los números de artículos que no registraron ventas.
    //c) Cuantas unidades se vendieron del número de artículo 10.

        //Voy a guardar los articulos en un vector

        int[] articulos = new int[15];

        int numeroArticulo;
        int cantidad;

        Console.WriteLine("Ingrese número de artículo:");
        numeroArticulo = int.Parse(Console.ReadLine());

        while (numeroArticulo != 0)
        {
            Console.WriteLine("Ingrese cantidad vendida:");
            cantidad = int.Parse(Console.ReadLine());

            articulos[numeroArticulo - 1] += cantidad;

            Console.WriteLine("Ingrese número de artículo:");
            numeroArticulo = int.Parse(Console.ReadLine());

        }
        int max = articulos[0];
        int articuloMax = 1;

        for (int x = 1; x < 15; x++)
        {
            if (articulos[x] > max)                 
            {
                max = articulos[x];
                articuloMax = x + 1;
            }
        }
        Console.WriteLine("Artículo más vendido: " + articuloMax);

        for (int x = 0; x < 15; x++)
        {
            if (articulos[x] == 0)
            {
                 Console.WriteLine("Artículo sin ventas: " + (x + 1));
            }
        }

        Console.WriteLine("Unidades vendidas del artículo 10: " + articulos[9]);

    }
}
