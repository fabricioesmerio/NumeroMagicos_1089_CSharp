using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMagicos_1089_CSharp
{
    public class MagicNumber
    {

        public void Calculate(int initial, int finish)
        {
            for (int currentNumber = initial; currentNumber < finish; currentNumber++)
            {
                var isPalindromo = IsPalindrome(currentNumber);
                if (!isPalindromo)
                {
                    var invertNumber = InvertNumber(currentNumber);
                    var resultSub = Substract(currentNumber, invertNumber);
                    var resultSum = Sum(resultSub, InvertNumber(resultSub));

                    Console.WriteLine("Número: " + currentNumber + ". Número Mágico: " + resultSum);
                }
            }
        }

        private int InvertNumber(int number)
        {
            string numberStr = number.ToString();
            var result = String.Empty;

            if (number < 100)
            {
                result = numberStr[1].ToString() + numberStr[0].ToString() + "0";
            }else
            {
                result = numberStr[2].ToString() + numberStr[1].ToString() + numberStr[0].ToString();
            }

            return int.Parse(result);
        }

        private bool IsPalindrome(int currentNumber)
        {
            return currentNumber == InvertNumber(currentNumber);
        }

        private int Sum(int currentNumber, int invertedNumber)
        {
            return currentNumber + invertedNumber;
        }

        private int Substract(int currentNumber, int invertedNumber)
        {
            if (currentNumber > invertedNumber)
                return currentNumber - invertedNumber;

            return invertedNumber - currentNumber;
        }

    }
}
