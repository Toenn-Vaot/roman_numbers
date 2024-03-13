using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumbers
{
    /// <summary>
    /// The class to transform integer number to roman number
    /// </summary>
    public class RomanNumber
    {
        Dictionary<string, int> _dictionary = new Dictionary<string, int>
        {
            { "X\u0305", 10000 },
            { "V\u0305", 5000 },
            { "M", 1000 },
            { "D", 500 },
            { "C", 100 },
            { "L", 50 },
            { "X", 10 },
            { "V", 5 },
            { "I", 1 }
        };

        private readonly int _number;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="number">The integer to transcript</param>
        public RomanNumber(int number)
        {
            _number = number;
        }

        /// <summary>
        /// Generate the roman representation of the number
        /// </summary>
        /// <returns></returns>
        public string Generate()
        {
            var tempNumber = _number;
            var result = string.Empty;
            foreach (var item in _dictionary)
            {
                var numberString = tempNumber.ToString();
                var firstNumber = int.Parse(numberString[0].ToString());
                
                if (new[] { "4", "9" }.Contains(firstNumber.ToString()))
                {
                    if(tempNumber > 1000)
                        result += GeneratePrintRomanChar(_dictionary.First(x => x.Value == 1).Key, 1, true);
                    else
                        result += GeneratePrintRomanChar(_dictionary.First(x => x.Value == (int)Math.Pow(10, numberString.Length - 1)).Key, 1);

                    result += GeneratePrintRomanChar(_dictionary.First(x => x.Value == (firstNumber + 1) * (int)Math.Pow(10, numberString.Length - 1)).Key, 1);
                    tempNumber -= firstNumber * (int)Math.Pow(10, numberString.Length - 1);
                } else if (tempNumber > 6000 && tempNumber < 9000)
                {
                    result += GeneratePrintRomanChar(_dictionary.First(x => x.Value == 5000).Key, 1);
                    result += GeneratePrintRomanChar(_dictionary.First(x => x.Value == 1).Key, firstNumber - 5, true);
                    tempNumber -= firstNumber * (int)Math.Pow(10, numberString.Length - 1);
                }

                var divider = tempNumber / item.Value;
                result += GeneratePrintRomanChar(item.Key, divider, _number > 4000 && tempNumber < 1000);
                
                if (divider > 0)
                    tempNumber %= item.Value;
            }

            return result;
        }

        /// <summary>
        /// Print the roman character as times as request by <paramref name="repeatTimes"/>
        /// </summary>
        /// <param name="romanCharacter">The character to print</param>
        /// <param name="repeatTimes">The number of times to print</param>
        /// <param name="vinculum">Flag indicates if the vinculum writing convention should be used</param>
        /// <returns>The result string</returns>
        private string GeneratePrintRomanChar(string romanCharacter, int repeatTimes, bool vinculum = false)
        {
            var vinculumCharacter = vinculum ? "\u0305" : string.Empty;

            if (repeatTimes == 1)
                return romanCharacter + vinculumCharacter;

            var result = string.Empty;
            for (var i = 0; i < repeatTimes; i++)
            {
                result += romanCharacter + vinculumCharacter;
            }

            return result;
        }
    }
}
