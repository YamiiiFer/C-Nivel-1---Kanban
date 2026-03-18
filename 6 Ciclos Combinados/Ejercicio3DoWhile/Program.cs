namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo.
        //  Luego mostrar cuántos números tiene cada lista.
        int n, con, nroGrupo = 0;

        do
        {
            nroGrupo++;
            con = 0;
            Console.WriteLine("Ingrese un nro");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
             con++;
             Console.WriteLine("Ingrese un nro");
             n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad del grupo: " + nroGrupo + " es: " +con+ " números"); 
            // acá terminó la lista porque apareció 0

            
        }while(n >= 0);

        
    }
}
