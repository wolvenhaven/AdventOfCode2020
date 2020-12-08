using AdventOfCode.Problems;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new Inputs();

            var expenseReportProblem = new ExpenseReport();
            expenseReportProblem.Execute(inputs.expenseReport);

            var passwordStrengthProblem = new PasswordStrength();
            passwordStrengthProblem.Execute(inputs.passwordList);

            var skiSlopeProblem = new SkiSlope();
            skiSlopeProblem.Execute(inputs.skiSlope);

            var passports = new Passports();
            passports.Execute(inputs.passports);

            var seats = new Seats();
            seats.Execute(inputs.seats);

            var customsForms = new CustomForms();
            customsForms.Execute(inputs.customsForms);

            var luggage = new Luggage();
            luggage.Execute(inputs.luggageRules);

            var handheld = new Handheld();
            handheld.Execute(inputs.handheldInstructions);
        }
    }
}
