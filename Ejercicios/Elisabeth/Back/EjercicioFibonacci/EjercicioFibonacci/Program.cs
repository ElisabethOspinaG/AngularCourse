// See https://aka.ms/new-console-template for more information

using System;

public class fibonacci 
{
    public int obtenerNumero () {
        Console.Write("Ingrese un numero: ");
        var num = Convert.ToInt32(Console.ReadLine());
        return num
    }
    public int almacenarSuma (int n1, int n2) {
        var suma = n1 + n2;
        Console.WriteLine($"la suma de los dos numero es : {suma}");
        return suma
    }
    
}

Console.WriteLine("Escriba el valor del primer numero: ");
// How to read from the console. 
var n1 = Console.ReadLine();

Console.WriteLine("Digite el valor del segundo número");
var n2 = Console.ReadLine();

var n3 = n1 + n2;
for (int i = 0; i < 10; i++)

{
    Console.WriteLine($"iteration numero: {i} -  {n1}, {n2}, {n3}");
    n1 = n2;
    n2 = n3;
    var value = n1 + n2;
    Console.WriteLine( "mirar que tal " + n1 + n2 + value);
}


