using System.Text;

namespace Study11
{
    internal class Study11
    {
        static void Main()
        {
            using (var sr = new StreamReader(Console.OpenStandardInput()))
            {
                int count = int.Parse(sr.ReadLine());
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < count; i++)
                {
                    string[] testCase = sr.ReadLine().Split(' ');
                    int d = int.Parse(testCase[0]);
                    int n = int.Parse(testCase[1]);
                    int s = int.Parse(testCase[2]);
                    int p = int.Parse(testCase[3]);

                    long sTime = n * s;
                    long pTime = d + (n * p);

                    if(sTime > pTime)
                        result.AppendLine("parallelize");
                    else if(sTime < pTime)
                        result.AppendLine("do not parallelize");
                    else
                        result.AppendLine("does not matter");
                }

                Console.Write(result.ToString());
            }
        }
    }
}
