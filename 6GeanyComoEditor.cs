using System;

class Variables
{
    static void Main()
    {
		//~ Declarar variables
        int n1, n2;

        //EJERCICIO PROPUESTO
        //Crea un rpograma que pida al usuario 2 numeros enteros a y b y muestre el resultado de (a+b)*(a-b) y el resultado de A2-B2
        
        // Ingreso de datos
        Console.Write("Ingresa el primer numero A: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo numero B: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        //~ Resultado
        Console.Write("(A+B)*(A-B)= ");
        Console.WriteLine((n1+n2)*(n1-n2));
        Console.Write("(A+B)*(A-B)= ");
        Console.WriteLine((n1*n1)-(n2*n2)); 
    }
}
