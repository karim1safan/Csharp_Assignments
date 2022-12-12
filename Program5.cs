using System;
internal class Program
{
  static void Main()
  {
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Enter third number: ");
    int c = int.Parse(Console.ReadLine());
    Console.Write("Enter fourth number: ");
    int d = int.Parse(Console.ReadLine());
    Console.Write("Enter fifth number: ");
    int e = int.Parse(Console.ReadLine());

    if (a > b && a > c && a > d && a > e)
    {
      Console.WriteLine("{0} is the biggest.", a);
    }
    else if (b > a && b > c && b > d && b > e)
    {
      Console.WriteLine("{0} is the biggest.", b);
    }
    else if (c > a && c > b && c > d && c > e)
    {
      Console.WriteLine("{0} is the biggest.", c);
    }
    else if (d > a && d > b && d > c && d > e)
    {
      Console.WriteLine("{0} is the biggest.", d);
    }
    else if (e > a && e > b && e > c && e > d)
    {
      Console.WriteLine("{0} is the biggest.", e);
    }
    else
    {
      Console.WriteLine("All numbers are equal.");
    }
  }
}

