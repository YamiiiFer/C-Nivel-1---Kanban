namespace Ejemplo2;

class Program
{
    static void Main(string[] args)
    {
        int dia;
        double temperatura;
        double acu = 0;
        //Declaro los Vectores
        double[] muestraMatutina = new double[31];
        double[] muestraVespertina = new double[31];
        double[] muestraNocturna = new double[31];

        //Cruce
        //Cargo los Vectores
        Console.WriteLine("Cargue el registro Matutino");
        for (int x = 0; x < 31; x++)
        {
            Console.WriteLine("Ingrese día: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraMatutina[dia - 1] = temperatura;
        }
        for (int x = 0; x < 31; x++)
        {
            
        }
        for (int x = 0; x < 31; x++)
        {
            
        }
        //Leer Vectores
        for (int x = 0; x < 31; x++)
        {
            acu += muestraMatutina[x];
        }
    }
}
