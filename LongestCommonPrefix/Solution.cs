namespace LeetCode.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            return Find(strs);
        }

        public static string Find(string[] strs)
        {
            string result = "";
            string standard = strs[0];
            int standardIndex = 0;

            for(int i = 0; i < strs.Length; i++)
            {
                if(standard.Length > strs[i].Length)
                {
                    standard = strs[i];
                    standardIndex = i;
                }
            }

            for(int i = 0; i < standard.Length; i++)
            {   
                for(int j = 0; j < strs.Length; j++)
                {
                    if(j != standardIndex)
                    {
                        if(strs[j][i] != standard[i])
                        {
                            return result;
                        }
                    }
                }
                result += standard[i];
            }
            return result;
        }
    }
}