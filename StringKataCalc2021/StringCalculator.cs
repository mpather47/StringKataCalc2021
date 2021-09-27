using System;
using System.Linq;

namespace StringKataCalc2021
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            var delimiter = new [] { ',', '\n' };
            var result = numbers.Split(delimiter)
                        .Select(s => int.Parse(s)).Sum();

            return result;
        }
    }
}
