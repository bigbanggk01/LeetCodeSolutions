using System.Collections.Generic;

namespace ValidParenthesis.Solution;
public class Solution {
    public bool IsValid(string s) {
        Stack<char> expressionStorage = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(expressionStorage.Count != 0)
            {
                if(FindPair(s[i]) == expressionStorage.Peek())
                {
                    expressionStorage.Pop();
                }
                else
                {
                    expressionStorage.Push(s[i]);
                }
            }
            else
            {
                if(s[i] == ')' || s[i] == ']' || s[i] == '}')
                    return false;
                else
                {
                    expressionStorage.Push(s[i]);
                }
            }
        }

        return expressionStorage.Count == 0 ? true : false;
    }

    public static char FindPair(char c)
    {
        char pair = '\0';
        switch(c)
        {
            case ')':
                pair = '(';
                break;
            case ']':
                pair = '[';
                break;
            case '}':
               pair = '{';
                break;
        }
        return pair;
    }
}