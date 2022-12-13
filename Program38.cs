using System;
internal class Program
{
  static void Main()
  {
    // karim mahmoud safan | physics & CS | Level 01
    bool arrayEqual = true;

    Console.Write("Enter the length of the firts array: ");
    int n = int.Parse(Console.ReadLine()); // length

    int[] arrayA = new int[n];

    for(int i = 0; i < arrayA.Length; i++)
    {
      Console.Write("Enter the element {0}: ",i);
      arrayA[i] = int.Parse(Console.ReadLine()); 
    }

    Console.Write("Enter the length of second array: "); 

    if(n != int.Parse(Console.ReadLine()))
    {
      Console.WriteLine("Arrays have the different length.");
    }
    else
    {
      int[] arrayB = new int[n];

      for(int i = 0; i < arrayB.Length; i++)
      {
        Console.Write("Enter the element {0}: ", i);
        arrayB[i] = int.Parse(Console.ReadLine());
      }
      for(int i = 0; i < arrayA.Length; i++)
      {
        if(arrayA[i] != arrayB[i])
        {
          arrayEqual = false; // exist from programme 
          break;
        }
      }
      if(arrayEqual) // true
      {
        Console.WriteLine("Two arrays are equal.");
      }
    }
  }
}

