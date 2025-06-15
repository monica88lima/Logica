using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaProgramacao
{
    internal static class ValidParentheses
    {
        public static bool IsValid(string s)
        { 
            Stack<char> pilha= new Stack<char>();
            if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
            {
                return false;
            }


            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pilha.Push(c);
                }
                else
                {
                    if(pilha.Count > 0)
                    {
                        char ultimo = pilha.Pop();
                        if ((ultimo == '(' && c != ')') ||
                            (ultimo == '{' && c != '}') ||
                            (ultimo == '[' && c != ']'))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                   
                }
            }
                      
           

            return true;
        }
    }
}
