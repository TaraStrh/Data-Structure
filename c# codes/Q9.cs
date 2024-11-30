using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string input1 = Console.ReadLine().Trim();
        string input2 = Console.ReadLine().Trim();

        if (input1.Length != input2.Length)
        {
            Console.WriteLine("False");
        }
        else
        {
            HashSet<char> charSet = new HashSet<char>(input1);

            foreach (char c in charSet)
            {
                int count1 = count(input1, c);
                int count2 = count(input2, c);

                if (count1 != count2)
                {
                    Console.WriteLine("False");
                    return;
                }
            }

            Console.WriteLine("True");
        }
    }

    static int count(string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
                count++;
        }
        return count;
    }
}