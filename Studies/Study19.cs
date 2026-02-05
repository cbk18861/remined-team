using System.Text;

namespace Study19
{
    internal class Study19
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string line = sr.ReadLine();

                string[] firstInput = line.Split(' ');
                int N = int.Parse(firstInput[0]);
                int M = int.Parse(firstInput[1]);

                StringBuilder output = new StringBuilder();

                for (int k = 0; k < M; k++)
                {
                    string[] inputs = sr.ReadLine().Split(' ');
                    int min2 = 0, min1 = 0, zero = 0, plus1 = 0, plus2 = 0;

                    for (int i = 0; i < N; i++)
                    {
                        int temp = int.Parse(inputs[i]);
                        if (temp == -2)
                            min2++;
                        else if (temp == -1)
                            min1++;
                        else if (temp == 0)
                            zero++;
                        else if (temp == 1)
                            plus1++;
                        else if (temp == 2)
                            plus2++;
                    }

                    long result = 1;
                    bool isPlus = false;

                    if (plus2 > 0)
                    {
                        result = (long)MathF.Pow(2, plus2);
                        isPlus = true;
                    }

                    int totalMinus = min2 + min1;
                    if (totalMinus % 2 == 0 && totalMinus > 0)
                    {
                        result *= (long)MathF.Pow(2, min2);
                        isPlus = true;
                    }
                    else if(totalMinus > 1)
                    {
                        int minNum = (min1 > 0) ? min2 : min2 - 1;
                        result *= (long)MathF.Pow(2, minNum);
                        isPlus = true;
                    }

                    if (!isPlus)
                    {
                        if (plus1 > 0)
                            result = 1;
                        else if (zero > 0)
                            result = 0;
                        else if (min1 > 0)
                            result = -1;
                        else
                            result = -2;
                    }

                    output.AppendLine(result.ToString());
                }
                Console.Write(output.ToString());
            }
        }
    }
}