/*Un robot industrial realiza movimientos en cinco direcciones diferentes dentro de una planta automatizada. 
El equipo de ingeniería necesita calcular la magnitud total del vector de movimiento para validar la trayectoria recorrida.*/


double[] movimientos = new double[5];
double[] MagnitudTotal = new double[5];
double sumaCuadrados = 0;


Console.WriteLine("Ingrese los movimientos del robot en 5 direcciones diferentes:");
for (int i = 0; i < movimientos.Length; i++)
{
    try
    {
        Console.Write($"Dirección {i + 1}: ");
        movimientos[i] = double.Parse(Console.ReadLine()!);   
    }
    catch (Exception e)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        i--; // Volver a pedir la entrada para la misma dirección
    }
}

for (int i = 0; i < movimientos.Length; i++)
{
    MagnitudTotal[i] = movimientos[i] * movimientos[i];
    sumaCuadrados += MagnitudTotal[i];
}

double magnitud = Math.Sqrt(sumaCuadrados);
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"La magnitud total del vector de movimiento es: {magnitud:F2}");
Console.ResetColor();