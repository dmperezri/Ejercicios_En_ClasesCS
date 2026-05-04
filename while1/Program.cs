// Ejerciicicio 1:
// Leer un numero y mostrar el cuadrado de sus antecesores.

using System;

Console.Title = "Ejercicio 1 - Cuadrado de los antecesores";

Console.Clear();
int numero;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------------------------------");
    Console.WriteLine("   Ingrese un numero entero: ");
    Console.WriteLine("------------------------------");
    Console.ResetColor();
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine($"El numero ingresado es: {numero}");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        Console.ResetColor();
    }


}

Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"  El cuadrado de los antecesores de {numero} es:");
Console.WriteLine("-----------------------------------------------");
Console.ResetColor();


int cont = 1;
while (cont <= numero)
{
    Console.WriteLine("El cuadrado de " + cont + " es: " + Math.Pow(cont, 2));
    cont++;
}
Console.WriteLine();