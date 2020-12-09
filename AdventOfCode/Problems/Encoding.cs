using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class Encoding : Problem
    {
        public override void PartOne(string input)
        {
            var preambleLength = 25;

            var encodings = input.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            foreach (var encoding in encodings.Skip(preambleLength))
            {
                var preambleSet = encodings.Skip(encodings.IndexOf(encoding) - preambleLength).Take(preambleLength).ToList();

                var result = IsValidEncoding(preambleSet, encoding);

                if (!result)
                {
                    Console.WriteLine("Encoding Part One Answer: " + encoding);
                    return;
                }

            }
        }

        public override void PartTwo(string input)
        {
            var preambleLength = 25;

            var encodings = input.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            var invalidEncoding = "";

            foreach (var encoding in encodings.Skip(preambleLength))
            {
                var preambleSet = encodings.Skip(encodings.IndexOf(encoding) - preambleLength).Take(preambleLength).ToList();

                var result = IsValidEncoding(preambleSet, encoding);

                if (!result)
                {
                    invalidEncoding = encoding;
                    break;
                }
            }

            var indexOfNumber = 0;
            var countingResult = "";

            foreach (var number in encodings)
            {
                indexOfNumber = encodings.IndexOf(number);
                var listToEvaluate = encodings.Skip(indexOfNumber).ToList();

                var countResult = AddsUpToInvalidEncoding(listToEvaluate, invalidEncoding);

                if (!string.IsNullOrEmpty(countResult))
                {
                    countingResult = countResult;
                    break;
                }
                
            }

            var indexOfCountResult = encodings.IndexOf(countingResult);

            var resultsList = encodings.Skip(indexOfNumber).Take(indexOfCountResult - indexOfNumber).Select(int.Parse).ToList();

            var largest = resultsList.Max();
            var smallest = resultsList.Min();
            var answer = largest + smallest;

            Console.WriteLine("Encoding Part Two Answer: " + answer);
        }

        private bool IsValidEncoding(List<string> preamble, string encodingToEvaluate)
        {
            var encodingIntValue = int.Parse(encodingToEvaluate);

            foreach (var preambleString in preamble)
            {
                var preambleIntValue = int.Parse(preambleString);

                foreach (var preambleAddValue in preamble)
                {
                    var preambleAddIntValue = int.Parse(preambleAddValue);

                    if (preambleIntValue != preambleAddIntValue && preambleIntValue + preambleAddIntValue == encodingIntValue)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private string AddsUpToInvalidEncoding(List<string> encodings, string encodingToEvaluate)
        {
            var encodingToEvaluateIntValue = int.Parse(encodingToEvaluate);

            Int64 accumulator = 0;

            foreach (var encodingString in encodings)
            {
                Int64 encodingStringIntValue = Int64.Parse(encodingString);

                accumulator += encodingStringIntValue;

                if (accumulator == encodingToEvaluateIntValue)
                {
                    return encodingString;
                }
            }

            return "";
        }
    }
}
