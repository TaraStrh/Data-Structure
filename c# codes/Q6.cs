using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] heights = new int[n];
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        string inputLine = Console.ReadLine();
        string[] inputElements = inputLine.Split(' ');

        for (int i = 0; i < n; i++)
        {
            heights[i] = int.Parse(inputElements[i]);
        }
        for(int i=0 ; i< n ; i++)
        {
            while(stack.Count>0 && heights[stack.Peek()] <= heights[i])
            {
                result[stack.Pop()]++;
            }
            if(stack.Count>0)
            result[stack.Peek()]++;

            stack.Push(i);
        }

       
        for (int i = 0; i < n; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}