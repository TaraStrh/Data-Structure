
using System.Runtime.Serialization;

using System.Reflection.Emit;
using System.Data;
using System;
namespace Program
{
class Program
{
static void Main(string[]args)
{  
    string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int[] arr3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr4 = new int[m];
            if (arr3.Length > n)
            {
                Array.Resize(ref arr3, n);
            }

            int[] intArray;

            if (m == 0)
            {
                intArray = arr3;
            }
            else
            {
                arr4= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                intArray = arr3.Concat(arr4).ToArray();
            }


   int p1 = m-1;
           int p2 = n-1;
           int i = m+n-1;

           while(p1>=0)
           {
               if(p2 >=0 && arr3[p2] > arr4[p1])
                   intArray[i--] = arr3[p2--];
               else
                  intArray[i--]= arr4[p1--];
           }
    Console.WriteLine(string.Join(" ", intArray));
}
}
}
