using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Cost(n));
        }
    }

    static long Cost(long n)
    {
        long[] arr = new long[n];
        long result = 0;

        for (long i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        for (long i = 0; i < n; i++)
        {
            if (i > 0)
            {
                Swap(arr, n - i - 1, n - i);
                arr = arr[0..(int)(n - i)].Concat(arr[(int)(n - i)..].OrderByDescending(x => x).AsEnumerable()).ToArray();
            }

            long add = 0;
            long max = 0;

            for (long j = 0; j < n; ++j)
            {
                add += arr[j] * (j + 1);
                max = Math.Max(max, (j + 1) * arr[j]);
            }

            add -= max;
            result = Math.Max(result, add);
        }

        return result;
    }

    static void Swap(long[] arr, long i, long j)
    {
        long tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}
