using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1___Sum_of_Biggest_Neighbor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp2 = { 1, 6, 1, 2, 6, 1, 6, 6 };
            int[] inp = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            Program P = new Program();
            Console.WriteLine(P.Challenge(inp));
            Console.WriteLine(P.Challenge(inp2));
            Console.Read();
        }
        public int Challenge(int[] input)
        {
            int M = 0;
            //your code here
            int[] x = input.Distinct().ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int y in x)
            {               
                int z = input.ToArray().Where(d=> d==y).Count();
                dict.Add(y,z);
                if (z > M)
                {
                    M = z;
                }
            }
            int[] filtered = input;
            foreach (var d in dict.Where(key => key.Value < (M-1)))
            {
                filtered = filtered.Where(val => val != d.Key).ToArray();
            }
            int bigneigh = 0;
            for (int i =0; i < filtered.Count() -1 ;i++)
            {           
                if (bigneigh < filtered[i] + filtered[i + 1])
                {
                    bigneigh = filtered[i] + filtered[i + 1];
                }
            }
            return bigneigh;
        }

    }
}
