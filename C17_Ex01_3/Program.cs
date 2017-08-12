using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Ex01_3
{
    public class Program
    {
        public static void Main()
        {
            AdvancedSandClock();
        }

        public static void AdvancedSandClock()
        {
            int sandClockHight = 0;
            string desiredHight = string.Empty;

            Console.WriteLine("Please entere the desired hight of the Sand Clock: ");
            desiredHight = Console.ReadLine();

            int.TryParse(desiredHight, out sandClockHight);
            bool isHeightLegal = CheckHeight(sandClockHight);

            while (!isHeightLegal)
            {
                Console.WriteLine("Wrong input please try again.");
                desiredHight = Console.ReadLine();

                int.TryParse(desiredHight, out sandClockHight);
                isHeightLegal = CheckHeight(sandClockHight);
            }

            if (sandClockHight % 2 == 0)
            {
                sandClockHight++;
            }

            string completeSandClock = BuildSandClock(sandClockHight);
            Console.WriteLine(completeSandClock);
        }

        public static string BuildSandClockLine(int i_NumOfAstrixes, int i_NumOfSpaces)
        {
            string astrixesString = " * ";
            string spaceString = "   ";
            StringBuilder lineBuild = new StringBuilder();

            for (int i = 0; i < i_NumOfSpaces; i++)
            {
                lineBuild.Append(spaceString);
            }

            for (int i = i_NumOfAstrixes; i > 0; i--)
            {
                lineBuild.Append(astrixesString);
            }

            for (int i = 0; i < i_NumOfSpaces; i++)
            {
                lineBuild.Append(spaceString);
            }

            return lineBuild.ToString();
        }

        public static string BuildSandClock(int i_SandClockHeight)
        {
            int i;
            string sandClock = string.Empty;
            StringBuilder sandClockBuild = new StringBuilder();
            string reverse = string.Empty;

            for (i = 0; i < i_SandClockHeight / 2; i++)
            {
                sandClockBuild.AppendLine(BuildSandClockLine(i_SandClockHeight - (i * 2), i));
            }

            reverse = sandClockBuild.ToString();
            sandClockBuild.Append(BuildSandClockLine(1, i));

            char[] arr = reverse.ToCharArray();
            Array.Reverse(arr);
            reverse = new string(arr);
            sandClockBuild.Append(reverse);
            sandClock = sandClockBuild.ToString();

            return sandClock;
        }

        public static bool CheckHeight(int i_DesiredHeight)
        {
            const bool v_IsHeightOk = true;

            return i_DesiredHeight >= 1 ? v_IsHeightOk : !v_IsHeightOk;
        }
    }
}
