using System.Text;

namespace Study17
{
    internal class Study17
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int num = int.Parse(sr.ReadLine());

            Console.WriteLine(DrawK(num));
        }

        static void Top(int N, StringBuilder result)
        {
            for (int i = 0; i < N * 5; i++)
            {
                if (i < N || i >= N * 4)
                    result.Append("@");
                else
                    result.Append(" ");
            }
            result.AppendLine();
        }

        static void Mid(int N, StringBuilder result)
        {
            for (int i = 0; i < N * 4; i++)
            {
                if (i < N || (i >= N * 3 && i < N * 4))
                    result.Append("@");
                else
                    result.Append(" ");
            }
            result.AppendLine();
        }

        static void Bottom(int N, StringBuilder result)
        {
            for (int i = 0; i < N * 3; i++)
            {
                result.Append("@");
            }
            result.AppendLine();
        }

        static StringBuilder DrawK(int num)
        {
            StringBuilder result = new StringBuilder();

            for (int j = 0; j < num; j++)
            {
                Top(num, result);
            }
            for (int j = 0; j < num; j++)
            {
                Mid(num, result);
            }
            for (int j = 0; j < num; j++)
            {
                Bottom(num, result);
            }
            for (int j = 0; j < num; j++)
            {
                Mid(num, result);
            }
            for (int j = 0; j < num; j++)
            {
                Top(num, result);
            }
            
            return result;
        }
    }
}
