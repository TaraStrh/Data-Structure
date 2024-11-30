using System;
using System.Data;

class program
{
    static void Main()
    {    
        DataTable calculatorTable = new DataTable();
        int number = int.Parse(Console.ReadLine());
        int[] res = new int[number];

        for (int i = 0; i < number; i++)
        {
            string input = Console.ReadLine();
                double result = EvaluateExpression(input);
                res[i] = (int)result;
        }
        Array.Sort(res, (x, y) => y.CompareTo(x));
        for (int i = 0; i < number; i++)
        {
            Console.Write(res[i] +" ");
        }
          static double EvaluateExpression(string expression)
    {
        return Convert.ToDouble(new DataTable().Compute(expression, null));
    }

    }
}