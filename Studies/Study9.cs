using System;

internal class Study9
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput())) 
        {
            string firstLine = sr.ReadLine();

            string[] inputs = firstLine.Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int A = int.Parse(inputs[2]);

            long totalTime = K / A;

            long minTime = long.MaxValue;

            for (int i = 0; i < N; i++)
            {
                string line = sr.ReadLine();

                string[] participant = line.Split(' ');
                int t = int.Parse(participant[0]);
                int s = int.Parse(participant[1]);

                long restCount = (totalTime - 1) / t;

                long finishTime = totalTime + (restCount * s);

                if (finishTime < minTime)
                {
                    minTime = finishTime;
                }
            }

            Console.WriteLine(minTime);
        }

    }
}