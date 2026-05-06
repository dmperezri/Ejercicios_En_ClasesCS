//Leer 5 edades y mostrar la edad promedio

int[] edades = new int[5];
int suma = 0;
double promedio = 0;

for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine()!);
}

foreach (int edad in edades)
{
    suma += edad;
}

promedio = (double)suma / edades.Length;

Console.WriteLine("La edad promedio es: " + promedio);

