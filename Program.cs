using System;
using System.Linq;
using System.Text;

namespace InterviewTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Количество уровней елочки:");

            var levels = int.Parse(Console.ReadLine() ?? string.Empty);
            var line = new StringBuilder("*");
            var countEmpty = levels - 1;

            for (var i = 1; i <= levels; i++)
            {
                var emptyStr = string.Concat(Enumerable.Repeat(" ", countEmpty--));

                Console.WriteLine(emptyStr + line);
                line.Append("**");
            }

            Console.ReadLine();
        }
    }
}
