using System;
internal class Program
{
  static void Main()
  {
    // karim mahmoud safan | physics & CS | level 01
    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine()); // 2
    Console.Write("Enter X: ");
    int x = int.Parse(Console.ReadLine());// 2

    double sum = 0;
    int fact = 1;

    for(int i = 1; i <= n; i++)
    {
      fact = fact * i;
      sum += fact / Math.Pow(x, i);
    }

    Console.WriteLine(sum + 1);
  }
}

