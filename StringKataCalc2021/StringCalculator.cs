﻿using System;

namespace StringKataCalc2021
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            return int.Parse(numbers);
        }
    }
}