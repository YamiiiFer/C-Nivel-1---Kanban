namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
        //  Mostrar el resultado en pantalla. Ejemplo:
        //CADENA FUENTE: “La mar estaba serena"
        //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        // Pedimos al usuario que ingrese una frase completa
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();
        // Pedimos el carácter que queremos reemplazar
        Console.WriteLine("Ingrese un carácter a reemplazar:");
        char caracter1 = char.Parse(Console.ReadLine());
        // Pedimos el nuevo carácter que va a reemplazar al anterior
        Console.WriteLine("Ingrese el nuevo carácter:");
        char caracter2 = char.Parse(Console.ReadLine());
        // Recorremos toda la cadena carácter por carácter
        //frase.Length: recorrer hasta el último carácter de la frase
        for (int x = 0; x < frase.Length; x++)
        {
            // Si el carácter actual coincide con el carácter a reemplazar
            //frase[x]: tomar una letra puntual de la frase
            if (frase[x] == caracter1)          
            {   // Mostramos el nuevo carácter
                Console.Write(caracter2);
            }
            else
            {    // Si no coincide, mostramos el carácter original
                Console.Write(frase[x]);
            }
        }

        
    }
}
