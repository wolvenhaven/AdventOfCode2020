using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class CustomForms : Problem
    {
        public override void PartOne(string customsForms)
        {
            var formGroups = customsForms.Split(new[] { "\r\n\r\n" }, StringSplitOptions.None).ToList();

            var answer = 0;

            foreach (var group in formGroups)
            {
                var groupAnswers = group.Replace("\r", "").Replace("\n", "").ToCharArray().ToList().Distinct();

                answer += groupAnswers.Count();
            }

            Console.WriteLine("Customs Forms Part One Answer: " + answer);
        }

        //private static void CustomsFormsPartTwo(string customsForms)
        //{
        //    var formGroups = customsForms.Split(new[] { "\r\n\r\n" }, StringSplitOptions.None).ToList();

        //    var answer = 0;

        //    foreach (var group in formGroups)
        //    {
        //        var individualAnswers = group.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

        //        Dictionary<char, int> answerCounts = new Dictionary<char, int>
        //        {
        //            {'a', 0},{'b', 0},{'c', 0},{'d', 0},{'e', 0},{'f', 0},{'g', 0},{'h', 0},{'i', 0},{'j', 0},{'k', 0},{'l', 0},{'m', 0},{'n', 0},{'o', 0},{'p', 0},{'q', 0},{'r', 0},{'s', 0},{'t', 0},{'u', 0},{'v', 0},{'w', 0},{'x', 0},{'y', 0},{'z', 0}
        //        };

        //        foreach (var indivudual in individualAnswers)
        //        {
        //            foreach (var letter in indivudual)
        //            {
        //                answerCounts[letter]++;
        //            }
        //        }

        //        var allAnswered = 0;

        //        foreach (var answerCount in answerCounts)
        //        {
        //            if (answerCount.Value == individualAnswers.Count())
        //            {
        //                allAnswered++;
        //            }
        //        }

        //        answer += allAnswered;
        //    }

        //    Console.WriteLine("Answer: " + answer);
        //}

        public override void PartTwo(string customsForms)
        {
            var answer = 0;

            customsForms.Split(new[] { "\r\n\r\n" }, StringSplitOptions.None).ToList().ForEach(looper =>
            {
                var individualAnswersCount = looper.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList().Count();

                answer += looper.Replace("\r", "").Replace("\n", "").ToCharArray().ToList().GroupBy(x => x).Select(y => new
                {
                    count = y.Count()
                }).Where(z => z.count == individualAnswersCount).Count();
            });

            Console.WriteLine("Customs Forms Part Two Answer: " + answer);
        }
    }
}
