// C# 007
// Autor: Skopx
// Fecha: 1/09/2024
// Ejercicio: Haz un programa que pida al usuario una cantidada de metros y la convierta a millas(1 milla terrestre = 1609.344 metros).
//  Debe incluir dos comentarios de una linea al principio del programa
// uno que recuerde que hacer el programa y otro con tu nombre.
using System;

class Program
{
    static void Main()
    {
        int metros;
        double millas = 1609.344;

        Console.Write("Ingrese una cantidad de metros: ");
        metros = Convert.ToInt32(Console.ReadLine());

        Console.Write("Esa cantidad en millas es: ");
        Console.WriteLine(metros / millas);
    }
}