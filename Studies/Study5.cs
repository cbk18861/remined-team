using System.Text;

namespace Study5
{
    internal class Study5
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                StringBuilder input = new StringBuilder(sr.ReadLine());                

                StringBuilder alphabet = new StringBuilder("abcdefghijklmnopqrstuvwxyz");

                if(input.Length != 26)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        for (int j = 0; j < alphabet.Length; j++)
                        {
                            if (input[i] == alphabet[j])
                                alphabet.Remove(j, 1);
                        }
                    }

                    if (alphabet.Length >= 1)
                    {
                        Console.WriteLine(input.ToString() + alphabet[0]);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else
                {
                    for(int i = alphabet.Length - 1; i >= 0; i--)
                    {
                        int currentIndex = alphabet.ToString().IndexOf(input[i].ToString());

                        for (int j = currentIndex + 1; j < alphabet.Length; j++)
                        {
                            if (!input.ToString().Substring(0, i).Contains(alphabet[j]))
                            {
                                Console.WriteLine(input.ToString().Substring(0, i) + alphabet[j]);
                                return;
                            }
                        }
                    }
                    Console.WriteLine("-1");
                }
            }
        }
    }
}
