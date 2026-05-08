//Un sistema de monitoreo industrial registra diferencias de producción entre dos máquinas durante cinco períodos consecutivos. El departamento técnico necesita calcular la diferencia entre ambos vectores.

using System;

int[] maquina1 = new int[5];
int[] maquina2 = new int[5];
int[] diferencia = new int[5];

Console.WriteLine("Ingresar la producción para la máquina 1:");
for (int i = 0; i < maquina1.Length; i++)
{
    try
    {
        Console.Write($"Período {i + 1}: ");
        maquina1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
        i--;
    }
}

Console.WriteLine("\nIngresar la producción para la máquina 2:");
for (int i = 0; i < maquina2.Length; i++)
{
    try
    {
        Console.Write($"Período {i + 1}: ");
        maquina2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
        i--;
    }
}

for (int i = 0; i < diferencia.Length; i++)
{
    diferencia[i] = maquina1[i] - maquina2[i];
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nDiferencia de producción entre las máquinas:");
Console.ResetColor();
for (int i = 0; i < diferencia.Length; i++)
{
    Console.WriteLine($"Período {i + 1}: {diferencia[i]}");
}


Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
Console.Clear();