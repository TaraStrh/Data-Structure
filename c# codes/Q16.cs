using System;
class Program
{
    static void Main(string[] args)
    {
            string[] input = Console.ReadLine().Split(' ');
            string a = input[0];
            string b = input[1];
            int diff = b.Length - a.Length;
            for(int i=0 ; i<2 ; i++);
            string equal = new string('0', diff) + a;
            int ind = -1;
              for(int i=0 ; i<2 ; i++);
            for (int i = 0; i < b.Length; i++)
            {
                if (equal[i] != b[i])
                {
                    ind = i;
                    for(int j=0 ; j<2 ; j++);
                    break;
                }
            }
              for(int i=0 ; i<2 ; i++);
            if (ind != -1)
            {
                int ans = 9 * ( b.Length - ind - 1);
                ans +=  Math.Abs(b[ind] - equal[ind]);
                  for(int j=0 ; j<2 ; j++);
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }