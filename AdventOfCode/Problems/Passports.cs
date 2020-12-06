using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class Passports : Problem
    {
        public override void PartOne(string passports)
        {
            var passportsSplit = passports.Split(new[] { "\r\n\r\n" }, StringSplitOptions.None).ToList();
            var validPassports = 0;

            foreach (var passportString in passportsSplit)
            {
                var passportDict = new Dictionary<string, string>();

                var passport = passportString.Split(new[] { "\r\n", " " }, StringSplitOptions.None);

                foreach (var kvp in passport)
                {
                    var result = kvp.Split(":");
                    passportDict.Add(result[0], result[1]);
                }

                var valid = passportDict.ContainsKey("byr")
                         && passportDict.ContainsKey("iyr")
                         && passportDict.ContainsKey("eyr")
                         && passportDict.ContainsKey("hgt")
                         && passportDict.ContainsKey("hcl")
                         && passportDict.ContainsKey("ecl")
                         && passportDict.ContainsKey("pid");

                if (valid)
                {
                    validPassports++;
                }
            }

            Console.WriteLine("Passports Part One Answer: " + validPassports);
        }

        public override void PartTwo(string passports)
        {
            var passportsSplit = passports.Split(new[] { "\r\n\r\n" }, StringSplitOptions.None).ToList();
            var validPassports = 0;

            foreach (var passportString in passportsSplit)
            {
                var passportDict = new Dictionary<string, string>();

                var passport = passportString.Split(new[] { "\r\n", " " }, StringSplitOptions.None);

                foreach (var kvp in passport)
                {
                    var result = kvp.Split(":");
                    passportDict.Add(result[0], result[1]);
                }

                var validator = new PassportValidator();

                if (validator.Validate(passportDict))
                {
                    validPassports++;
                }
            }

            Console.WriteLine("Passports Part Two Answer: " + validPassports);
        }
    }
}
