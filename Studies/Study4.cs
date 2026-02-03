using System;
using System.IO;

namespace Study4
{
    internal class Study4
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string N = sr.ReadLine();
                string X = sr.ReadLine();

                int count = 0;
                bool carry = false;

                for (int i = X.Length - 1; i > 0; i--)
                {
                    if (!carry)
                    {
                        if (X[i] == '1')
                        {
                            count++;
                            carry = true;
                        }
                    }
                    else
                    {
                        if (X[i] == '0')
                        {
                            count++;
                            carry = true;
                        }
                        else
                        {
                            carry = true;
                        }
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}