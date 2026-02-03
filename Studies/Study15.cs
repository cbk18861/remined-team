using System.Numerics;

namespace Study15
{
    internal class Program
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                BigInteger input = BigInteger.Parse(sr.ReadLine());

                BigInteger left = 0;
                BigInteger right = input;

                BigInteger result = 0;

                while (left <= right)
                {
                    BigInteger mid = (left + right) / 2;

                    if (mid * mid == input)
                    {
                        result = mid;
                        break;
                    }
                    else if (mid * mid > input)
                    {
                        right = mid -1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
