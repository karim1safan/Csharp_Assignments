using System;
internal class Program
{
  static void Main()
  {
    // Karim Mahmoud Safan
    Console.Write("A: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("B: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("H: ");
    double h = double.Parse(Console.ReadLine());

    double area = (0.5) * (a + b) * h;

    Console.WriteLine("Area: {0}",area);

  }
}

