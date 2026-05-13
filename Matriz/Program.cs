//MATRICES

//Las matrices son estructuras de datos que permiten almacenar y organizar información en filas y columnas.
//Aplicaciones: Representación de tablas, imágenes, sistemas de ecuaciones, etc.

//Cuando hay un for dentro de otro for, se llama anidado (nested)
//Y el for más externo se llama bucle externo (outer loop) y el for más interno se llama bucle interno (inner loop)

//Se ejecuta el bucle externo una vez, luego se ejecuta el bucle interno completamente, 
//luego se vuelve a ejecutar el bucle externo, 
//y así sucesivamente hasta que el bucle externo termine de ejecutarse.


float[,] matriz = new float[ 3 , 3 ];

Console.WriteLine("Matrices");
Console.WriteLine("Ingrese las temperaturas:");

int cont = 1;
for (int r = 0; r < 3; r++) // r -> rows (filas)
{
    for (int c = 0; c < 3; c++) // c -> columns (columnas)
    {
        try
        {
            Console.Write($"Dime la temperatura #{cont++}: ");
            matriz[r, c] = float.Parse(Console.ReadLine()!);
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La temperatura ingresada no es válida. Inténtalo de nuevo.");
            Console.ResetColor();
            //Use c-- para volver a pedir la temperatura para la misma posición de la matriz 
            // y cont-- para mantener el contador correcto.   
            c--;
            cont--;
        }

    }
}


Console.Clear();
Console.WriteLine("---------------------------------");
Console.WriteLine("   TEMPERATURAS REGISTRADAS");
Console.WriteLine("---------------------------------");
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {
        if (matriz[f, c] < 35) Console.ForegroundColor = ConsoleColor.Green;
        else if (matriz[f, c] >= 35 && matriz[f, c] < 40) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{matriz[f, c],6} C°");
        Console.ResetColor();
    }
    Console.WriteLine();
}

Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();
Console.Clear();