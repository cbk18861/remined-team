using System.Text;

namespace Study18
{
    internal class Study18
    {
        static void Main()
        {
            using var sr = new StreamReader(Console.OpenStandardInput());
            int N = int.Parse(sr.ReadLine());

            StringBuilder text = new StringBuilder(sr.ReadLine());

            StringBuilder alphabet = new StringBuilder("abcdefghijklmnopqrstuvwxyz");
            int[] counts = new int[26];

            for (int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < 26; j++)
                {
                    if (text[i] == alphabet[j])
                        counts[j]++;
                }
            }

            int result = 0;

            for (int i = 0; i < 26; i++)
            {
                if (counts[i] > result)
                {
                    result = counts[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
