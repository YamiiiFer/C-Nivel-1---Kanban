namespace Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
       //5. Hacer un programa que solicite 20 números 
       // y luego emitir por pantalla el máximo de los números pares
       //  y el mínimo de los números impares.

       int n;
       int maxP = 0;
       int minI = 0;
       int conPar = 0;
       int conImp = 0; 

       for (int x = 0; x < 20; x++){

       Console.WriteLine("Ingrese un nro: ");
       n = int.Parse(Console.ReadLine());

       if( n % 2 == 0) //Si es PAR cuenta

            conPar++;

            if(conPar == 1){
                maxP = n; 

            }else if(n > maxP){
                maxP = n;
        }else{

            conImp++;

            if(conImp == 1){
                minI = n;
            }else if(n < minI)
                {
                    minI = n;
                }    
            }
       }
       Console.WriteLine("El maximo Par es: "+ maxP + " y el minimo Impar: " + minI);

    }
}
