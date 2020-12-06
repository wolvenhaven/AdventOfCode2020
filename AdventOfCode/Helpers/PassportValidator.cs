using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class PassportValidator
    {
        public bool Validate(Dictionary<string, string> passportDict)
        {
            var requiredFieldsValidated = false;

            var birthYearMin = 1920;
            var birthYearMax = 2002;
            var issueYearMin = 2010;
            var issueYearMax = 2020;
            var expYearMin = 2020;
            var expYearMax = 2030;
            var heightCmMin = 150;
            var heightCmMax = 193;
            var heightInMin = 59;
            var heightInMax = 76;
            var validHeightMeasures = new List<string> { "cm", "in" };
            var hairColorRegex = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
            var validEyeColors = new List<string> { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            var validPidDigitLength = 9;

            if (PassportRequiredFieldsValidator(passportDict))
            {
                var heightMeasure = passportDict["hgt"].Substring(passportDict["hgt"].Length - 2);
                var heightAmount = passportDict["hgt"].Substring(0, passportDict["hgt"].Length - 2);

                 requiredFieldsValidated = PassportNumberValidator(passportDict["byr"], birthYearMin, birthYearMax)
                                           && PassportNumberValidator(passportDict["iyr"], issueYearMin, issueYearMax)
                                           && PassportNumberValidator(passportDict["eyr"], expYearMin, expYearMax)
                                           && PassportListValidator(heightMeasure, validHeightMeasures)
                                           && (heightMeasure == "cm" ? PassportNumberValidator(heightAmount, heightCmMin, heightCmMax)
                                                                     : PassportNumberValidator(heightAmount, heightInMin, heightInMax))
                                           && PassportRegexValidator(passportDict["hcl"], hairColorRegex)
                                           && PassportListValidator(passportDict["ecl"], validEyeColors)
                                           && PassportNumberValidator(passportDict["pid"].Length.ToString(), validPidDigitLength, validPidDigitLength);
            }

            return requiredFieldsValidated;
        }

        private bool PassportRequiredFieldsValidator(Dictionary<string, string> passportDict)
        {
            return passportDict.ContainsKey("byr")
                && passportDict.ContainsKey("iyr")
                && passportDict.ContainsKey("eyr")
                && passportDict.ContainsKey("hgt")
                && passportDict.ContainsKey("hcl")
                && passportDict.ContainsKey("ecl")
                && passportDict.ContainsKey("pid");
        }

        private bool PassportNumberValidator(string value, int min, int max)
        {
            int valueNum;

            if (int.TryParse(value, out valueNum))
            {
                if (valueNum >= min && valueNum <= max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool PassportListValidator(string value, List<string> validValues)
        {
            return validValues.Contains(value);
        }

        private bool PassportRegexValidator(string value, string regex)
        {
            return new Regex(regex).Matches(value).Count >= 1;
        }
    }
}
