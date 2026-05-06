//Leer 5 edades y mostrar la edad promedio

int[] edades = new int[5];
int suma = 0;
double promedio = 0;

for (int i = 0; i < edades.Length; i++)
{
    try
    {
        Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
        edades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: Ingrese un número válido.");
        i--; // Volver a pedir la misma posición
    }

}

foreach (int edad in edades)
{
    suma += edad;
}

promedio = (double)suma / edades.Length;

Console.WriteLine("La edad promedio es: " + promedio);

