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
        long maxSwaps = ((input * (input - 1)) / 2) - 1;

        for (long i = 0; i < input; i++)
        {
            array[i] = long.Parse(inputElements[i]);
        }

        long swaps = MergeSort(array, 0, input - 1, maxSwaps);

        for (long i = 0; i < input - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                ans = false;
                break;
            }
        }

        if (ans && swaps <= maxSwaps)
            Console.WriteLine("MITONE");
        else
            Console.WriteLine("NEMITONE");
    }

    static long MergeSort(long[] array, long left, long right, long maxSwaps)
    {
        long swaps = 0;

        if (left < right)
        {
            long mid = (left + right) / 2;

            swaps += MergeSort(array, left, mid, maxSwaps - swaps);
            swaps += MergeSort(array, mid + 1, right, maxSwaps - swaps);

            swaps += Merge(array, left, mid, right, maxSwaps - swaps);
        }

        return swaps;
    }

    static long Merge(long[] array, long left, long mid, long right, long maxSwaps)
    {
        long[] temp = new long[right - left + 1];
        long i = left;
        long j = mid + 1;
        long k = 0;
        long swaps = 0;

        while (i <= mid && j <= right && swaps <= maxSwaps)
        {
            if (array[i] <= array[j])
            {
                temp[k] = array[i];
                i++;
            }
            else
            {
                temp[k] = array[j];
                j++;
                swaps += mid - i + 1; 
            }
            k++;
        }

        while (i <= mid)
        {
            temp[k] = array[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            temp[k] = array[j];
            j++;
            k++;
        }

        for (long m = 0; m < temp.Length; m++)
        {
            array[left + m] = temp[m];
        }

        return swaps;
    }
}
