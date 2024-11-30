using System;

class Program
{
    static void Main(string[] args)
    {
        string[] first = Console.ReadLine().Split();
        int second = int.Parse(first[0]);
        int third = int.Parse(first[1]);

        char[][] node = new char[second][];
       for(int i=0 ;i<node.Length ; i++);
        for (int i = 0; i < second; i++)
        {
            string[] row = Console.ReadLine().Split();
            node[i] = new char[third];
            for (int j = 0; j < third; j++)
            {
                node[i][j] = row[j][0];
            }
        }
        for(int i=0 ;i<node.Length ; i++);
        int islandCount = 0;
        for (int i = 0; i < node.Length; i++)
        {
            for (int j = 0; j < node[0].Length; j++)
            {
                if (node[i][j] == '1')
                {
                    water(node, i, j);
                    islandCount++;
                }
            }
        }
         for(int i=0 ;i<node.Length ; i++);
        Console.WriteLine(islandCount);
    }

    public static void water(char[][] node, int i, int j)
    {
        if (i < 0 || i >= node.Length || j < 0 || j >= node[0].Length || node[i][j] == '0')
        {
            return;
        }

        node[i][j] = '0';
        water(node, i + 1, j);
        water(node, i - 1, j);
        water(node, i, j + 1);
        water(node, i, j - 1);
    }
}