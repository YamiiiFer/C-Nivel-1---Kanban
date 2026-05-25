namespace Ejercicio6;

class Program
{
    static void Main(string[] args)
    {
        //🧩 EJERCICIO 1 — Cadenas de caracteres
        //Enunciado

        //Hacer un programa que:

        //solicite una frase
        //solicite un carácter
        //recorra la frase
        //informe cuántas veces aparece ese carácter

        string cadena;
        char caracter;
        int contador = 0;

        Console.WriteLine("Ingrese una frase: ");
        cadena = Console.ReadLine();

        Console.WriteLine("Ingrese un caracter: ");
        caracter = char.Parse(Console.ReadLine());

        for (int x = 0; x < cadena.Length; x++)
        {
            if(cadena[x] == caracter)
            contador++;
        }
        Console.WriteLine("El caracter: " + caracter + " aparece: " + contador + " veces.");
    }
}
