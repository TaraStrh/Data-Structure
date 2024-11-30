using System;
using System.Collections.Generic;
class Program
{
    static List<List<int>> tree = new List<List<int>>();
    static int[] depth;
    static int[] parent;
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int q = int.Parse(input[1]);
        depth = new int[n + 1];
        parent = new int[n + 1];
        parent[1] = 1; 
        for (int i = 0; i <= n; i++)
        {
            tree.Add(new List<int>());
        }
        input = Console.ReadLine().Split();
        for (int i = 2; i <= n; i++)
        {
            int parentNode = int.Parse(input[i - 2]);
            tree[parentNode].Add(i);
            parent[i] = parentNode;
        }
        SetDepth(1, 0);
        for (int i = 0; i < q; i++)
        {
            input = Console.ReadLine().Split();
            int u = int.Parse(input[0]);
            int v = int.Parse(input[1]);
            while (depth[u] > depth[v]) 
            u = parent[u];
            while (depth[v] > depth[u]) 
            v = parent[v];
            while (u != v)
            {
                u = parent[u];
                v = parent[v];
            }

            Console.WriteLine(u);
        }
    }
    static void SetDepth(int node, int d)
    {
        depth[node] = d;
        foreach (int child in tree[node])
        {
            SetDepth(child, d + 1);
        }
    }
}