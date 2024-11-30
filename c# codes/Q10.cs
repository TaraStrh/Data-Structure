using System;

public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
        long n = long.Parse(input[0]);
        long targetIndex = long.Parse(input[1]);

        string[] bstArray = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
        long[] bst = new long[n];
        for (long i = 0; i < n; i++)
        {
            bst[i] = long.Parse(bstArray[i]);
        }

        long nextIndex = Next(bst, n, targetIndex);
        Console.WriteLine(nextIndex);
    }
     public static long Next(long[] BST, long n, long target)
    {
        if (target == n)
        {
            return -1;
        }
        if (BST[target] == -1)
        {
            return -1;
        }

        long nextIndex = -1;
        long max = long.MaxValue;
        for (long i = 0; i < n; i++)
        {
            if (BST[i] > BST[target] && i != target && BST[i] < max)
            {
                max = BST[i];
                nextIndex = i;
            }
        }

        return nextIndex;
    }

}