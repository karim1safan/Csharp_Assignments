using System;
internal class Program
{
  static void Main()
  {
    // karim mahmoud safan | physics & CS | Level 01
    Console.WriteLine("Each element multiplied by 5");
    int[] arr = new int[20];
    
    for(int i = 0; i < arr.Length; i++)
    {
      arr[i] = i * 5;
      Console.WriteLine(arr[i]);
    }
  }
}

