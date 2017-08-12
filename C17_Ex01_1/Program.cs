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
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;

            int.TryParse(i_FirstNumber, out firstNumber);
            int.TryParse(i_SecondNumber, out secondNumber);
            int.TryParse(i_ThirdNumber, out thirdNumber);
            int.TryParse(i_FourthNumber, out fourthNumber);
            
            string binaryFirstNum = ConvertDecimalToBinary(firstNumber);
            string binarySecondNum = ConvertDecimalToBinary(secondNumber);
            string binaryThirdNum = ConvertDecimalToBinary(thirdNumber);
            string binaryFourthNum = ConvertDecimalToBinary(fourthNumber);

            float averageDecimalNumbers = firstNumber + secondNumber + thirdNumber + fourthNumber;
            averageDecimalNumbers /= 4;
            float averageDigitsAmount = CalcAverageDigitsAmount(binaryFirstNum, binarySecondNum, binaryThirdNum, binaryFourthNum);

            Console.WriteLine("Statistics:");
            Console.WriteLine("Average = " + averageDecimalNumbers);
            Console.WriteLine("Average digits amount in binary numbers: " + averageDigitsAmount);
        }

        public static bool isRisingSeries(string i_NumberToCheck)
        {
            int numberToCeck;
            int remainder;
            int nextRemainder;
            bool o_IsrRising = true;

            int.TryParse(i_NumberToCheck, out numberToCeck);

            while ((numberToCeck / 10) > 0)
            {
                remainder = numberToCeck % 10;
                nextRemainder = (numberToCeck / 10) % 10;

                if (remainder > nextRemainder)
                {
                    continue;
                }
                else
                {
                    o_IsrRising = false;
                    break;
                }
            }

            return o_IsrRising;
        }

        public static float CalcAverageDigitsAmount(string i_FirstNumber, string i_SecondNumber, string i_ThirdNumber, string i_FourthNumber)
        {
            int numberOfDigits;
            float average;

            numberOfDigits = i_FirstNumber.Length + i_SecondNumber.Length + i_ThirdNumber.Length + i_FourthNumber.Length;
            average = numberOfDigits;
            average /= 4;

            return average;
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
                    Console.WriteLine("Wrong input, please try again");
                }
            }

            return o_NumberToCheck;
        }

        public static bool CheckIfNumIsLegal(string i_NumberToCheck)
        {
            const bool o_IsFourDigits = true;
            int intValueNumber = 0;

            // the integer value must be between 0 and 10,000
            int.TryParse(i_NumberToCheck, out intValueNumber);

            return (intValueNumber > 0) && (intValueNumber < 10000) && (i_NumberToCheck.Length == 4) ? o_IsFourDigits : !o_IsFourDigits;
        }

        public static string ConvertDecimalToBinary(int i_NumberToConvert)
        {
            string convertedNumber = string.Empty;
            int remainder = 0;

            while (i_NumberToConvert > 0)
            {
                remainder = i_NumberToConvert % 2;
                i_NumberToConvert /= 2;

                convertedNumber = remainder.ToString() + convertedNumber;
            }

            return convertedNumber;
        }
    }
}