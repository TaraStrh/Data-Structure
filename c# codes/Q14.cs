using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();
        string[] inputElements = inputLine.Split(' ');
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }

        long[] store_score = new long[n];
        long maxScore = 0;

        for (int startIndex = n - 1; startIndex >= 0; startIndex--)
        {
            long score = CalculateScore(arr,store_score, startIndex);
            maxScore = Math.Max(maxScore, score);
        }

        Console.WriteLine(maxScore);
    }

    static long CalculateScore(int[] arr, long[] store_score, int index)
    {
        if (index >= arr.Length)
            return 0;
        if (store_score[index] != 0)
            return store_score[index];
        long score = arr[index] + CalculateScore(arr, store_score, index + arr[index]);
        store_score[index] = score;
        return score;
    }
}