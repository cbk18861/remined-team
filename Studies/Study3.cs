namespace Study3
{
    internal class Study3
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string input = sr.ReadLine();

                string[] txt = input.Split(' ');
                int X = int.Parse(txt[0]);
                int Y = int.Parse(txt[1]);

                string xx = "";
                string yy = "";

                for (int i = 0; i < X; i++)
                {
                    xx += 1;
                }
                for (int j = 0; j < Y; j++)
                {
                    yy += 1;
                }

                int result = int.Parse(xx) + int.Parse(yy);
                Console.WriteLine(result);
            }
        }
    }
}
