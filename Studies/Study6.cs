namespace Study6
{
    internal class Study6
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                int N = int.Parse(sr.ReadLine());

                int year = 2014;
                int month = 4;
                int day = 2;

                int monthlyDay = 31;
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                for (int i = 0; i < N - 1; i++)
                {
                    day++;

                    if (month == 2 && (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        monthlyDay  = 29;
                    }
                    else
                    {
                        monthlyDay = days[month];
                    }

                    if (day > monthlyDay)
                    {
                        day = 1;
                        month++;
                    }

                    if (month > 12)
                    {
                        month = 1;
                        year++;
                    }
                }

                Console.WriteLine($"{year}-{month:D2}-{day:D2}");
            }
        }           
    }
}
