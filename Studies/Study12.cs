using System;
using System.Collections.Generic;
using System.Text;

namespace Study12 
{
    internal class Study12
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string input = sr.ReadLine();
                StringBuilder result = new StringBuilder();
                Stack<char> stack = new Stack<char>();
                bool inTag = false;

                foreach (char c in input)
                {
                    if (c == '<')
                    {
                        PrintStack(stack, result);
                        inTag = true;
                        result.Append(c);
                    }
                    else if (c == '>')
                    {
                        inTag = false;
                        result.Append(c);
                    }
                    else if (inTag)
                    {
                        result.Append(c);
                    }
                    else
                    {
                        if (c == ' ')
                        {
                            PrintStack(stack, result);
                            result.Append(c);
                        }
                        else
                        {
                            stack.Push(c);
                        }
                    }
                }
                PrintStack(stack, result);

                Console.WriteLine(result.ToString());
            }        
        }

        static void PrintStack(Stack<char> stack, StringBuilder sb)
        {
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
        }
    }
}

