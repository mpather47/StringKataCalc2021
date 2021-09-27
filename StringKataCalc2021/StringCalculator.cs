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

            var numberList = numberString.Split(delimiter.ToArray())
                        .Select(s => int.Parse(s));

            var negatives = numberList.Where(n => n < 0);

            if (negatives.Any())
            {
                string negativesString = String.Join(',', negatives.Select(n => n.ToString()));
                throw new Exception($"Negatives not allowed: {negativesString}");
            }
            var result = numberList.Where(n => n <= 1000).Sum();

            return result;
        }
    }
}
