using System;
internal class Program
{
  static void Main()
  {
    // karim mahmoud safan | physics & CS | Level 01
    Console.Write("Enter the bonus points: ");
    int scores = int.Parse(Console.ReadLine());

    if(scores >= 1 && scores <= 9)
    {
      if(scores >= 1 && scores <= 3)
      {
        scores = scores * 10;
        Console.WriteLine("New Scores: {0}",scores);
      }
      else if(scores >= 4 && scores <= 6)
      {
        scores = scores * 100;
        Console.WriteLine("New Scores: {0}", scores);
      }
      else if (scores >= 7 && scores <= 9)
      {
        scores = scores * 1000;
        Console.WriteLine("New Scores: {0}", scores);
      }
    }
    else if (scores == 0 || scores > 9)
    {
      Console.WriteLine("Error you should enter number in the range.");
    }
    else
    {
      Console.WriteLine("Enter positive value.");
    }
  }
}

