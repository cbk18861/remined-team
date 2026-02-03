using System.Text;

namespace Study16
{
    internal class Study16
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int T = int.Parse(sr.ReadLine());
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] inputs = sr.ReadLine().Split(' ');

                long N = long.Parse(inputs[0]);
                long M = long.Parse(inputs[1]);
                long k = long.Parse(inputs[2]);                
                long D = long.Parse(inputs[3]);

                long B = 1;
                long A = k * B;

                long totalTeam = N * M;
                long innerMatch = A * (M - 1) * totalTeam / 2;
                long outerMatch = B * (N - 1) * M * totalTeam / 2;

                long totalMatch = innerMatch + outerMatch;

                if(totalMatch > D)
                {
                    result.AppendLine("-1");
                }
                else
                {
                    B = D / totalMatch;
                    result.AppendLine((B * totalMatch).ToString());
                }
            }

            Console.WriteLine(result);
        }
    }
}
