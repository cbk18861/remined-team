using System.Numerics;
using System.Text;

namespace Study7
{
        internal class Study7
        {
            static void Main()
            {
                using (var sr = new StreamWriter(Console.OpenStandardInput()))
                {
                    string count = sr.ReadLine();

                    int t = int.Parse(count);

                    while (t-- > 0)
                    {
                        string input = sr.ReadLine();

                        BigInteger n = BigInteger.Parse(input);
                        bool isLucky = false;

                        for (int m = 1; m <= 8; m++)
                        {
                            BigInteger target = 9 * n + 8 * m;

                            if (target % 8 == 0)
                            {
                                BigInteger quotient = target / 8;

                                if (GetDigitSum(quotient) <= m)
                                {
                                    isLucky = true;
                                    break;
                                }
                            }
                        }

                        Console.WriteLine(isLucky ? "Yes" : "No");
                    }
                }
            }

            static int GetDigitSum(BigInteger num)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += (int)(num % 10);
                    num /= 10;
                }
                return sum;
            }
        }
    
}
