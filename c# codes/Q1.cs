
using System.Reflection.Emit;
using System.Data;
using System;
namespace Program{
    public class Program
    {
        static void Main()
        {
            int count=1;
            int vowel=0;
            int max=0;
            string input = Console.ReadLine();
              for (int i = 1; i < input.Length; i++)
        {
        if (input[i - 1] < input[i])
        count++;
        else if (input[i - 1] > input[i])
        {
        vowel = i;
        count = 1;
        }
        if (count == 5)
        {
            if(i-vowel+1>max)
            {
                max = i-vowel+1;
            }
        }
        }
        Console.WriteLine(max);
        }
    } 
}