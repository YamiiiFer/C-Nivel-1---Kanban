namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
       // 4. Hacer un programa que solicite UN número 
       // y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
       //  Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo.

        int n; 
        int con = 0;

        Console.WriteLine("Ingrese un nro: ");
        n = int.Parse(Console.ReadLine());

        for (int x = 1; x <= n; x++){
            
           if(n % x == 0)
                con++;
                 if(x == 0);

            
        }
       
    }
}
