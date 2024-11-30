using System;

public class Program
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();
        string[] inputElements = inputLine.Split(' ');
        long[] array = new long[input];
        bool ans = true;

        for (long i = 0; i < input; i++)
        {
            array[i] = long.Parse(inputElements[i]);
        }

        for (long i = 0; i < input - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] % 2 == array[i + 1] % 2)
            {
                ans = false;
                break;
            }
            else if(array[i] > array[i + 1] && array[i] == array[i+1]+1 && input %2 == 0)
            {
                ans = false;
                 break;
            }
        }

        if (ans)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}