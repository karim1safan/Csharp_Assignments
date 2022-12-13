using System;
internal class Program
{
  static void Main()
  {
    // karim mahmoud safan | Physics & CS | Level 01
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    if(num > 1 && num < 100)
    {
      for(int i = 2; i < num; i++)
      {
        if(num % i == 0)
        {
          Console.WriteLine("{0} is not prime.",num);
          return; // to exist from loop when find the number.
        }
      }
      Console.WriteLine("{0} is prime.", num);
    }
  }
}
// prime number accept on itself and 1.
// 7 > 2 - 6 = is prime.
// 8 > 2 - 7 = isn't prime accept on 4.
