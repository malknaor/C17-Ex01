using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            BinarySequences();
        }
        
        public static void BinarySequences()
        {
            string firstNumber = string.Empty;
            string secondNumber = string.Empty;
            string thirdNumber = string.Empty;
            string fourthNumber = string.Empty;

            Console.WriteLine("Please Enter four positive four digits numbers: ");
            firstNumber = NumberInput();
            secondNumber = NumberInput();
            thirdNumber = NumberInput();
            fourthNumber = NumberInput();
                          
            CalcAndPrintStatistics(firstNumber, secondNumber, thirdNumber, fourthNumber);
        }

        public static void CalcAndPrintStatistics(string i_FirstNumber, string i_SecondNumber, string i_ThirdNumber, string i_FourthNumber)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;

            int.TryParse(i_FirstNumber, out firstNumber);
            int.TryParse(i_SecondNumber, out secondNumber);
            int.TryParse(i_ThirdNumber, out thirdNumber);
            int.TryParse(i_FourthNumber, out fourthNumber);
            
            string binaryFirstNum = ConvertFromDecimalToBinary(firstNumber);
            string binarySecondNum = ConvertFromDecimalToBinary(secondNumber);
            string binaryThirdNum = ConvertFromDecimalToBinary(thirdNumber);
            string binaryFourthNum = ConvertFromDecimalToBinary(fourthNumber);

            float averageOfAllDecimalNumbers = (firstNumber + secondNumber + thirdNumber + fourthNumber)/ 4;
            float averageOfOnesInBinaryNumber = 0/*method to calc the average of ones*/;
            float averageOfZeroesInBinaryNumber = 0/*method to calc the average of zeroes*/;

            Console.WriteLine("Statistics:");
            Console.WriteLine("Average of 1's in binary numbers: ");
            Console.WriteLine("Average of 1's in binary numbers: ");
        }

        public static string NumberInput()
        {
            const bool v_ToContinue = true;
            string o_NumberToCheck = string.Empty;

            while (v_ToContinue)
            {
                o_NumberToCheck = Console.ReadLine();

                if (CheckIfNumIsLegal(o_NumberToCheck))
                {
                    break;                  
                }
                else
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }

            return o_NumberToCheck;
        }

        public static bool CheckIfNumIsLegal(string i_NumberToCheck)
        {
            const bool o_IsFourDigits = true;
            int numberToCheck = 0;

            // the integer value must be between 0 and 10,000
            int.TryParse(i_NumberToCheck, out numberToCheck);

            return (numberToCheck > 0) && (numberToCheck < 10000) && (i_NumberToCheck.Length == 4) ? o_IsFourDigits : !o_IsFourDigits;
        }

        public static string ConvertFromDecimalToBinary(int i_NumberToConvert)
        {
            string o_ConvertedNumber = string.Empty;
            int remainder = 0;

            while (i_NumberToConvert > 0)
            {
                remainder = i_NumberToConvert % 2;
                i_NumberToConvert /= 2;

                o_ConvertedNumber = remainder.ToString() + o_ConvertedNumber;
            }

            return o_ConvertedNumber;
        }
    }
}