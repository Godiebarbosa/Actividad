using System;

class Program
{
static void Main()
{
    double longitud, anchura, area;

    Console.Write("Ingrese la longitud del rectángulo: ");
    longitud = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la anchura del rectángulo: ");
    anchura = double.Parse(Console.ReadLine());

    area = longitud * anchura;

    Console.WriteLine("El área del rectángulo es: " + area);
}
}