using System;
using System.Linq;
using System.Collections.Generic;
namespace MST
{
    public class MSTByKruskal
    {
        public static int[] parent;
        public static int Root(int vertex)
        {
            while (parent[vertex] != vertex)
            {
                parent[vertex] = parent[parent[vertex]];
                vertex = parent[vertex];
            }
            return vertex;
        }

        public static int SecondMinimumSpanningTree(List<Tuple<int, int, int>> edgesInfo, int vertexNum)
        {
            List<int> spanningTrees_weight = new List<int>();
            List<Tuple<int, int, int>> mstEdges = MinimumSpanningTree(edgesInfo, vertexNum);
            int first_min_weight = mstEdges.Sum(x => x.Item3);
            int min_weight = 0;
            for (int i = 0; i < mstEdges.Count; i++)
            {
                edgesInfo.RemoveAll(item => item.Item1 == mstEdges[i].Item1 && item.Item2 == mstEdges[i].Item2 && item.Item3 == mstEdges[i].Item3);
                min_weight = MinimumSpanningTree(edgesInfo, vertexNum).Sum(x => x.Item3);
                if(min_weight >= first_min_weight)
                    spanningTrees_weight.Add(min_weight);
                edgesInfo.Add(new Tuple<int, int, int>(mstEdges[i].Item1, mstEdges[i].Item2, mstEdges[i].Item3));
            }
            if (spanningTrees_weight.Count == 0)
                return -1;
            else
                return spanningTrees_weight.Min();
        }
        public static void Union(int src, int des)
        {
            int edge_source = Root(src);
            int edge_destination = Root(des);
            parent[edge_source] = parent[edge_destination];
        }
        public static List<Tuple<int, int, int>> MinimumSpanningTree(List<Tuple<int, int, int>> edgesInfo, int vertxNum)
        {
            List<Tuple<int, int, int>> mstEdges = new List<Tuple<int, int, int>>();
            parent = new int[vertxNum + 1];
            for (int i = 0; i < vertxNum; i++)
                parent[i] = i;
            var orderdEdges_by_weight = edgesInfo.OrderBy(t => t.Item3).ToList();
            for (int i = 0; i < edgesInfo.Count; i++)
            {
                if (Root(orderdEdges_by_weight[i].Item1) != Root(orderdEdges_by_weight[i].Item2))
                {
                    mstEdges.Add(new Tuple<int, int, int>(orderdEdges_by_weight[i].Item1, orderdEdges_by_weight[i].Item2, orderdEdges_by_weight[i].Item3));
                    Union(orderdEdges_by_weight[i].Item1, orderdEdges_by_weight[i].Item2);
                }
            }
            return mstEdges;
        }
        public static void Main(string[] args)
        {
            var vertexNEdge = Console.ReadLine().Split();
            int vertexNum = int.Parse(vertexNEdge[0]);
            int edgeNum = int.Parse(vertexNEdge[1]);
            List<Tuple<int, int, int>> edgesInfo = new List<Tuple<int, int, int>>();
            for (int i = 0; i < edgeNum; i++)
            {
                var edge_info = Console.ReadLine().Split();
                edgesInfo.Add(new Tuple<int, int, int>(int.Parse(edge_info[0]), int.Parse(edge_info[1]), int.Parse(edge_info[2])));
            }

            Console.WriteLine(SecondMinimumSpanningTree(edgesInfo, vertexNum));
        }

    }

}