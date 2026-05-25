namespace CadenaCaracteres;

class Program
{
    static void Main(string[] args)
    {
        /*CADENAS DE CARACTERES
        
        // vector de char: |P|A|A|P|A||||||||P| en el cual puedo guerdar caracteres

        // CARACTER BARRA CERO \0 marca la finalización de la cadena de caracteres
        
        //frases[5] = '\0';

        //CADENA DE CARACTERES: Es un vector de char en el cual puedo guardar caracteres
        //que los voy a ordenar con un sentido de palabra de frase etc. y esta cadena de
        //caracteres no importa el tamaño que tenga, pero le voy a definir un FIN con \0.

        // |H|O|L|A||Q|U|E||T|A|L|?|\0||||||||

        char[] nombre = new char[10];
        char letra;
        int indice = 0;
        
        Console.WriteLine("Ingrese su nombre letra por letra...(termina con punto)");
        letra = char.Parse(Console.ReadLine());

        while (letra != '.' && indice < 10 )
        {
            nombre[indice] = letra;
            letra = char.Parse(Console.ReadLine());
            indice++;
        }
        nombre[indice] = '\0';

        Console.Write("Hola ");
        indice =  0;
        while (nombre[indice] != '\0')
        {
            Console.Write(nombre[indice]);
            indice++;
        }*/
        string nombre;
        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);
    }
}
