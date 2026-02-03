namespace Study14
{
    internal class Study14
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                int c = int.Parse(sr.ReadLine());
                int[] result = new int[c];

                for(int i = 0; i < c; i++)
                {
                    string[] inputs = sr.ReadLine().Split(' ');
                    int l = int.Parse(inputs[0]);
                    int r = int.Parse(inputs[1]);

                    double h = r / 2.0;
                    double triangle = l / 2.0;

                    double v = Math.Sqrt(Math.Pow(h, 2) - Math.Pow(triangle, 2));

                    double area = Math.PI * h * v;

                    result[i] = (int)Math.Round(area / 100.0) * 100;
                }

                for(int i = 0; i < c; i++)
                    Console.WriteLine(result[i]);
            }
        }
    }
}
