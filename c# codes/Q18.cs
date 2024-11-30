using System;
class Program {

  public static void Main(string[] args) 
  {

      string[] array = Console.ReadLine().Split(' ');
      int input1 = int.Parse(array[0]);
      int input2 = int.Parse(array[1]);
      int input3 = int.Parse(array[2]);
      if (input1 > input2) {
        Console.WriteLine("First");
      } 
      else if (input1 == input2 && input3 % 2 != 0) 
      {
        Console.WriteLine("First");
      } 
      else 
      {
        Console.WriteLine("Second");
      }
    }
  }

