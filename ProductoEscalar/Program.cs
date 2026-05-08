/*Un sistema físico analiza dos conjuntos de fuerzas aplicadas sobre una estructura metálica. 
Cada fuerza está representada mediante un vector de tamaño 5. 
El objetivo es calcular el producto escalar entre ambos vectores para analizar su comportamiento.*/

/*Crear dos arreglos.
Recorrer ambos vectores utilizando un ciclo for.
Multiplicar las posiciones correspondientes.
Acumular el resultado de cada multiplicación.
Mostrar el producto escalar total en pantalla.*/

int[] fuerza1 = new int[5];
int[] fuerza2 = new int[5];
int productoEscalar = 0;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Ingrese los valores del primer vector de fuerzas:");
Console.ResetColor();
for (int i = 0; i < fuerza1.Length; i++)
{
    try
    {
        Console.Write($"Componente {i + 1}: ");
        fuerza1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error al ingresar el valor. Ingrese un número entero válido.");
        Console.ResetColor();
        i--;
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nIngrese los valores del segundo vector de fuerzas:");
Console.ResetColor();
for (int i = 0; i < fuerza2.Length; i++)
{
    try
    {
        Console.Write($"Componente {i + 1}: ");
        fuerza2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error al ingresar el valor. Ingrese un número entero válido.");
        Console.ResetColor();
        i--; 

    }
}


for (int i = 0; i < fuerza1.Length; i++)
{
    productoEscalar += fuerza1[i] * fuerza2[i];
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nEl producto escalar entre los dos vectores de fuerzas es: {0}", productoEscalar);
Console.ResetColor();

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
Console.Clear();
