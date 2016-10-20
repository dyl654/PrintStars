using System;

namespace PrintStars
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int length = 5;
            Console.WriteLine(CreateDiamond(length));
        }

        private static string CreateDiamond(int length)
        {
            return MakeDiamond(length);
        }

        private static string MakeDiamond(int length)
        {
            var size = 2*length - 1;
            var diamond = "";
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (Math.Abs(i - size/2) + Math.Abs(j - size/2) <= size/2)
                    {
                        diamond += "*";
                    }
                    else
                    {
                        diamond += ' ';
                    }
                }
                diamond += '\n';
            }
            return diamond;
        }
    }
}
