namespace Ejemplo5;

class Program
{
    static void Main(string[] args)
    {
        //CORTE DE CONTROL
        //Manejar lotes de datos agrupados
        //legajo, edad, sueldo,codigo de equipo(numerico entre 1 y 50)

        int legajo,edad, codigoEquipo, equipoActual;
        float sueldo;

        //1 river
        //2 boca
        //3 racing

        Console.WriteLine("Ingrese el legajo");
        legajo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el sueldo");
        sueldo = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el codigo de equipo");
        codigoEquipo = int.Parse(Console.ReadLine());
        
        while (sueldo > 0 )
        {
            equipoActual = codigoEquipo;
            while (codigoEquipo == equipoActual)
            {
                
                Console.WriteLine("Ingrese el legajo");
                legajo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el sueldo");
                sueldo = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el codigo de equipo");
                codigoEquipo = int.Parse(Console.ReadLine());

                //Mostrar lo que necesite mostrar
            }
            //Mostrar lo que necesite mostrar
        }
        //Mostrar lo que necesite mostrar
    }
}
