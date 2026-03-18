namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa para ingresar 10 números. El mismo debe analizar
        //  y mostrar por pantalla cuántos de esos números son primos.

        int n, con;

        int conP = 0;
        // n → guarda el número que ingresa el usuario
        // con → cuenta cuántos divisores tiene ese número
        // conP → cuenta cuántos números primos se ingresaron

        for (int x = 0; x < 10; x++)
        // Este ciclo se repite 10 veces porque el ejercicio pide analizar 10 números
        {
           Console.WriteLine("Ingrese un nro: ");
           n = int.Parse(Console.ReadLine());
        // Se pide al usuario un número y se guarda en la variable n

           con = 0;
        // Se reinicia el contador de divisores para el nuevo número

           for (int y = 1; y <= n; y++)
             // Este ciclo recorre todos los números desde 1 hasta n
            // Sirve para verificar cuáles son divisores del número ingresado
            {
                if(n % y == 0)
                // Si el resto de dividir n por i es 0,
                // significa que i es divisor de n
                {
                    con++;
                    // Aumentamos el contador de divisores
                }
            }
            
            if (con == 2)           
            {
                conP++;
                 // Si el número es primo, aumentamos el contador de números primos
            }
       
        }
         Console.WriteLine("Hay " + conP + " nros primos");
        // Cuando termina el ciclo de los 10 números,
        // mostramos cuántos de ellos eran primos
    }
}
