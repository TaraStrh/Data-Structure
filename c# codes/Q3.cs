using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long c = long.Parse(input[2]);

        
           if(a == b && c%2==1 || a>b)
             Console.WriteLine("naghi");
            else
             Console.WriteLine("arastoo");
            
        }
    }
}