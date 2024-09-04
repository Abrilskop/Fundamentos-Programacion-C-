using System;

class Variables
{
    static void Main() // aqui va cuerpo del programa 
    {
        //---------------------VERSION 1---------------------------

        //// Declaramos las variables
        //int numA;
        //int numB;


        //// Ingresamos datos
        ////Console.Readline() devuelve un dato q es texto
        //Console.WriteLine("Ingresa el primer numero");
        //numA = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Ingresa el segundo numero");
        //numB = Convert.ToInt32(Console.ReadLine());

        //// resultado
        //Console.WriteLine("La suma es: ");
        //Console.WriteLine(numA+numB);

        //--------------------VERSION MEJORADA---------------------

        //// Declaramos las variables
        //int numA, numB;


        //// Ingresamos datos
        ////Console.Readline() devuelve un dato q es texto
        //Console.Write("Ingresa el primer numero: ");
        //numA = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Ingresa el segundo numero: ");
        //numB = Convert.ToInt32(Console.ReadLine());

        //// resultado
        //Console.Write("La suma es: ");
        //Console.WriteLine(numA + numB);

        //-------------------Ejercicio propuesto-------------------

        // Pide al usuario 2 numeros enteros. Calcula (y muestra)
        // cuanto es su division entera y el resto de esa division

        // Declaramos 2 numeros
        int n1, n2;

        // Ingresamos los datos
        Console.Write("Ingresa n1: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa n2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        // Imprimimos respuesta
        Console.Write("La division es: ");
        Console.WriteLine(n1 / n2);

        Console.Write("El resto de la division es: ");
        Console.WriteLine(n1 % n2);

    }
        
}
//Variable en la que gaurdamos la info, se le asigna un nombre y un tipo de dato siempre.