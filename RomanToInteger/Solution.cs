using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s) {
            int result = 0;
            int cache = 0;
            IDictionary<string, int> romanTable = new Dictionary<string, int>();

            romanTable.Add("I", 1);
            romanTable.Add("V", 5);
            romanTable.Add("X", 10);
            romanTable.Add("L", 50);
            romanTable.Add("C", 100);
            romanTable.Add("D", 500);
            romanTable.Add("M", 1000);

            for(int i = 0; i <= s.Length - 1; i++)
            {
                int current = romanTable[s[i].ToString()];
                int next = 0;

                if(i < s.Length - 1)
                {
                    next = romanTable[s[i+1].ToString()];
                }

                if(cache != 0)
                {
                    result -= cache;
                    cache = 0;
                }

                if(current >= next)
                {
                    result += romanTable[s[i].ToString()];
                }
                else
                {
                    cache += current;
                }
            }

            return result;
        }
    }
}