namespace CodeStudy
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split(' ');
            long[] a = Array.ConvertAll(inputs, long.Parse);

            long result = a[0];

            long con = (long)(Math.Pow(10, 9) + 7);

            for (int i = 1; i <= n; i++)
            {
                long nextValue = a[i];

                if (nextValue <= 1 || result <= 1)
                {
                    result = (result + nextValue) % con;
                }
                else
                {
                    result = (result * nextValue) % con;
                }
            }

            Console.WriteLine(result);
        }
    }
}
