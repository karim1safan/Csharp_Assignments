using System;

internal class Program
{
  static void Main()
  {
    // N!/K! 

    Console.Write("Enter the num of N: "); // 3
    int n = int.Parse(Console.ReadLine()); 

    Console.Write("Enter the num of K: "); // 4
    int k = int.Parse(Console.ReadLine());

    int fact_n = 1;
    int fact_k = 1;

    // 1<K<N

    do
    {
      Console.Write("Enter the new value of K: ");
      k = int.Parse(Console.ReadLine());
    }
    while (k > n || k < 1);

    for (int i = 1; i <= n; i++)
    {
      fact_n = fact_n * i;
    }
    for (int i = 1; i <= k; i++)
    {
      fact_k = fact_k * i;
    }
      
    Console.WriteLine("{0}! / {1}! = {2}", n, k, fact_n / fact_k);

  }
}

