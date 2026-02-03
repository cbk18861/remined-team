using System;

namespace Study10
{
    internal class Study10
    {
        static int result = 0;
        static string[] Pull(string[] nums, int index)
        {
            string[] temp = (string[])nums.Clone();

            for (int i = index; i < temp.Length - 1; i++)
            {
                temp[i] = temp[i + 1];
            }

            temp[temp.Length - 1] = "0";
            return temp;
        }
        static string[] Push(string[] nums, int index)
        {
            string[] temp = (string[])nums.Clone();

            for (int i = temp.Length - 1; i > index; i--)
            {
                temp[i] = temp[i - 1];
            }

            temp[index] = "0";
            return temp;
        }

        static int Check(string[] answers, string[] picks, int NCount, int hisScore)
        {
            int currScore = 0;

            for (int i = 0; i < NCount; i++)
            {
                if (picks[i] == answers[i])
                    currScore++;
            }

            if (currScore > hisScore)
                return currScore;
            else
                return hisScore;         
        }

        static void BackTrack(string[] answers, string[] picks, int NCount, int KCount)
        {
            result = Check(answers, picks, NCount, result);

            if (KCount <= 0)
                return;

            for (int i =  0; i < NCount; i++)
            {
                BackTrack(answers, Pull(picks, i), NCount, KCount - 1);
                BackTrack(answers, Push(picks, i), NCount, KCount - 1);
            }
        }

        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string[] inputs = sr.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                int K = int.Parse(inputs[1]);

                string[] answers = sr.ReadLine().Split(' ');
                string[] picks = sr.ReadLine().Split(' ');

                BackTrack(answers, picks, N, K);

                Console.WriteLine(result);
            }
        }
    }
}
