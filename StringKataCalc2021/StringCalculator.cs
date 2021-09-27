using System;
using System.Collections.Generic;
using System.Linq;

namespace StringKataCalc2021
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;
            
            var delimiter = new List<char> { ',', '\n' };

            string numberString = numbers;

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');

                var newDelimeter = splitInput.First().Trim('/');

                numberString = String.Join('\n', splitInput.Skip(1));

                delimiter.Add(Convert.ToChar(newDelimeter));
            }
            
            var result = numberString.Split(delimiter.ToArray())
                        .Select(s => int.Parse(s)).Sum();

            return result;
        }
    }
}
