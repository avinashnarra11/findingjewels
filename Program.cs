using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace findingjewels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the jewels");
            string[] jewels = Console.ReadLine().Split(',');
            Console.WriteLine("Enter the stones");
           string[] stones = Console.ReadLine().Split(',');
            List<int> jewls = new List<int>();
            List<int> stons = new List<int>();
            foreach(string j in jewels)
            {
                jewls.Add(int.Parse(j));
            }
            foreach (string k in stones)
            {
                stons.Add(int.Parse(k));
            }

            Console.WriteLine(numJewelsInStones(jewls.ToArray(), stons.ToArray()));
            Console.ReadKey();
        }
        public static int numJewelsInStones(int[] jewels, int[] stones)
        {
            int counter = 0;
            for (int i=0;i< jewels.Length;i++)
            {
                for(int j=0;j< stones.Length;j++)
                {
                    if (jewels[i]==stones[j])
                    {
                        counter++;
                    }
                         
                }
            }
            return counter;
        }
    }
}
