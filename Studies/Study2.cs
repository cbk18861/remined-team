using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Study
{
    internal class Study2
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                int N = int.Parse(sr.ReadLine());
                int E = int.Parse(sr.ReadLine());

                HashSet<int>[] peopleSongs = new HashSet<int>[N + 1];
                for (int i = 1; i <= N; i++)
                {
                    peopleSongs[i] = new HashSet<int>();
                }

                int totalSongs = 0;

                for (int j = 0; j < E; j++)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    int K = int.Parse(input[0]);

                    List<int> participants = new List<int>();
                    bool isSun = false;

                    for (int k = 1; k <= K; k++)
                    {
                        int person = int.Parse(input[k]);
                        participants.Add(person);
                        if (person == 1) isSun = true;
                    }

                    if (isSun)
                    {
                        totalSongs++;
                        foreach (int p in participants)
                        {
                            peopleSongs[p].Add(totalSongs);
                        }
                    }
                    else
                    {
                        HashSet<int> sharedSongs = new HashSet<int>();
                        foreach (int p in participants)
                        {
                            sharedSongs.UnionWith(peopleSongs[p]);
                        }
                        foreach (int p in participants)
                        {
                            peopleSongs[p] = new HashSet<int>(sharedSongs);
                        }
                    }
                }

                List<int> result = new List<int>();
                for (int i = 1; i <= N; i++)
                {
                    if (peopleSongs[i].Count == totalSongs)
                    {
                        result.Add(i);
                    }
                }

                Console.WriteLine(string.Join("\n", result));
            }
        }
    }
}
