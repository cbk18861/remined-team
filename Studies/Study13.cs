namespace Study13
{
    internal class Study13
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string[] inputs1 = sr.ReadLine().Split(' ');

                int N = int.Parse(inputs1[0]);
                int M = int.Parse(inputs1[1]);

                int minPackage = int.MaxValue;
                int minUnit = int.MaxValue;
                int result = int.MaxValue;

                for (int i = 0; i < M; i++)
                {
                    string[] inputs2 = sr.ReadLine().Split(' ');

                    int package = int.Parse(inputs2[0]);
                    int unit = int.Parse(inputs2[1]);

                    if(package < minPackage)
                        minPackage = package;

                    if(unit < minUnit)
                        minUnit = unit;
                }

                int packCount = N / 6;
                int notPack = N % 6;

                int p = minPackage * (N < 6 ? 1 : N / 6);
                int u = minUnit * N;

                bool isPSmaller = p < u ? true : false;

                if (notPack == 0)
                {
                    if (isPSmaller && p < result)
                        result = p;

                    else if (!isPSmaller)
                    {
                        if(p != u && u < result)
                            result = u;
                        else if (p == u && p < result)
                            result = p;
                    }
                }
                else
                {
                    if(minPackage >= minUnit * 6)
                    {
                        result = minUnit * N;
                    }
                    else
                    {
                        if (minPackage * (packCount + 1) > (minPackage * packCount) + (minUnit * notPack))
                            result = (minPackage * packCount) + (minUnit * notPack);

                        else
                            result = minPackage * (packCount + 1);
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
