using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class PasswordStrength : Problem
    {
        public override void PartOne(string passwords)
        {
            var numValidPasswords = 0;

            var passwordList = passwords.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();

            foreach (var checkPassword in passwordList)
            {
                var splitCheck = checkPassword.Split(':');
                var rule = splitCheck[0].Replace(" - ", "-");
                var password = splitCheck[1].Trim();

                var ruleSplit = rule.Split(' ');
                var ruleCount = ruleSplit[0];
                var ruleLetter = Char.Parse(ruleSplit[1]);

                var ruleCountSplit = ruleCount.Split("-");

                var ruleCountMin = Int32.Parse(ruleCountSplit[0]);
                var ruleCountMax = Int32.Parse(ruleCountSplit[1]);

                var passwordLetters = password.ToCharArray().ToList();

                var letterCountList = passwordLetters.Where(x => x == ruleLetter).ToList();

                if (letterCountList.Count >= ruleCountMin && letterCountList.Count <= ruleCountMax)
                {
                    numValidPasswords++;
                }
            }

            Console.WriteLine("Password Strength Part One Answer: " + numValidPasswords);
        }

        public override void PartTwo(string passwords)
        {
            var numValidPasswords = 0;

            var passwordList = passwords.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();

            foreach (var checkPassword in passwordList)
            {
                var splitCheck = checkPassword.Split(':');
                var rule = splitCheck[0].Replace(" - ", "-");
                var password = splitCheck[1].Trim();

                var ruleSplit = rule.Split(' ');
                var ruleIndexes = ruleSplit[0];
                var ruleLetter = Char.Parse(ruleSplit[1]);

                var ruleIndexSplit = ruleIndexes.Split("-");

                var ruleIndexFirst = Int32.Parse(ruleIndexSplit[0]);
                var ruleIndexSecond = Int32.Parse(ruleIndexSplit[1]);

                var passwordLetters = password.ToCharArray().ToList();

                var firstLetter = passwordLetters.ElementAt(ruleIndexFirst - 1);
                var secondLetter = passwordLetters.ElementAt(ruleIndexSecond - 1);

                if (firstLetter != secondLetter && (firstLetter == ruleLetter || secondLetter == ruleLetter))
                {
                    numValidPasswords++;
                }
            }

            Console.WriteLine("Password Strength Part Two Answer: " + numValidPasswords);
        }
    }
}
