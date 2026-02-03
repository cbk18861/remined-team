namespace Study8
{
    internal class Study8
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string input = sr.ReadLine();

                string[] inputs = input.Split(' ');
                int N = int.Parse(inputs[0]);
                int S = int.Parse(inputs[1]);

                int[] L_i = new int[N];

                int result = 0;

                for (int i = 0; i < N; i++)
                {
                    L_i[i] = int.Parse(sr.ReadLine());
                }

                for (int i = 0; i < N; i++)
                {
                    if (L_i[i] < S)
                    {
                        for (int j = i + 1; j < N; j++)
                        {
                            if (L_i[i] + L_i[j] <= S)
                                result++;
                        }
                    }
                }


                Console.WriteLine(result);
            }
        }
    }
}
