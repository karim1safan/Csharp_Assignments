using System;
internal class Program
{
  static void Main()
  {
    // karim mahmoud safan | physics & CS | Level 01
    int n;
    do
    {
      Console.Write("Length: ");
      n = int.Parse(Console.ReadLine());
    }
    while (n < 1);

    if(n < 20)
    {
      for (int i = 1; i <= n; i++)
      {
        for (int j = 0; j <= n - 1; j++)
        {
          Console.Write(i + j);
        }
        Console.WriteLine();
      }
    }
    else
    {
      Console.WriteLine("Enter the value less than 20");
    }
  }
}
