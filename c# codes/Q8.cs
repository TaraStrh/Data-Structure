using System;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {
        long first = long.Parse(Console.ReadLine().Trim());
        string[] second = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
        long index = long.Parse(second[0]);
        long value = long.Parse(second[1]);

        long[] array = new long[first];
        string[] third = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
        for (long i = 0; i < first; i++)
        {
            array[i] = long.Parse(third[i]);
        }

        array[index] += value;

         for (long i = first ; i >=0; i--)
        {
            MinHeap(array, first, i);
        }

        StringBuilder output = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            output.AppendLine(array[i].ToString());
        }

        Console.Write(output.ToString());
    }
    public static void MinHeap(long[] array, long n, long i)
    {
        long smallest = i;
        long rightChild = 3 * i + 3;
        long leftChild = 3 * i + 1;
        if (rightChild < n && array[rightChild] < array[smallest])
            smallest = rightChild;
        if (leftChild < n && array[leftChild] < array[smallest])
            smallest = leftChild;
        if (smallest != i)
        {
            Swap(array, i, smallest);
            MinHeap(array, n, smallest);
        }
    }

    public static void Swap(long[] array, long i, long j)
    {
        long temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}