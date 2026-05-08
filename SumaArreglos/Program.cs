/*Una empresa de logística utiliza un sistema de posicionamiento para registrar desplazamientos realizados por un dron durante cinco intervalos de tiempo. El sistema necesita sumar dos vectores para calcular el desplazamiento total acumulado.

Vectores
A = (2, 4, 6, 8, 10)
B = (1, 3, 5, 7, 9)*/

using System;
//Crear dos arreglos.
int [] vectorA = new int[5];
int [] vectorB = new int[5];

//Guardar los valores indicados en cada vector.
Console.WriteLine("Ingrese los valores para el vector A:");
for (int i = 0; i < vectorA.Length; i++)
{
    try
    {
        Console.Write($"Posición {i}: ");
    vectorA[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--; // Reintentar la misma posición
    }
}

Console.WriteLine("\nIngrese los valores para el vector B:");
for (int i = 0; i < vectorB.Length; i++)
{
    try
    {
        Console.Write($"Posición {i}: ");
        vectorB[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--; // Reintentar la misma posición
    }
}


//Crear un tercer vector para almacenar el resultado.
int[] vectorResultado = new int[5];

//Utilizar un ciclo for para sumar las posiciones correspondientes.
for (int i = 0; i < vectorResultado.Length; i++)
{
    vectorResultado[i] = vectorA[i] + vectorB[i];
}

//Mostrar el vector resultante en pantalla.
Console.WriteLine("------------------------------");
Console.WriteLine("\nEl vector resultante es:");
Console.WriteLine("------------------------------");
for (int i = 0; i < vectorResultado.Length; i++)
{
    Console.Write($"{vectorResultado[i]} ");
}
Console.WriteLine();
