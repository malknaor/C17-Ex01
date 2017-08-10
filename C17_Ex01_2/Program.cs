using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Ex01_2
{
    public class Program
    {
        public static void Main()
        {
            CreateAndPrintSandClock();
        }

        public static void CreateAndPrintSandClock()
        {
            string firstLine = "* * * * *";
            string secondLine = "  * * *  ";
            StringBuilder sandClock = new StringBuilder();

            sandClock.AppendLine(firstLine);
            sandClock.AppendLine(secondLine);
            sandClock.AppendLine("    *    ");
            sandClock.AppendLine(secondLine);
            sandClock.AppendLine(firstLine);

            Console.WriteLine(sandClock);
        }
    }
}