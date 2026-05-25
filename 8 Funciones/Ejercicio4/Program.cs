namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
        //  que reciba un número por valor y una variable por referencia.
        //  Que analice el número y escriba la variable recibida por referencia con:

        //a. 1 si el número es positivo.
        //b. -1 si el número es negativo.
        //c. 0 si el número es cero.

        int numero = -5;
        int resultado = 0;

        positivoNegativoCero(numero, ref resultado);

        Console.WriteLine(resultado);
    }

    static void positivoNegativoCero(int numero, ref int resultado)
    {
        if (numero > 0)
        {
            resultado = 1;
        }
        else if (numero < 0)
        {
            resultado = -1;
        }
        else
        {
            resultado = 0;
        }
    }
}
