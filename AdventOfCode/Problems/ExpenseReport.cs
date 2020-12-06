using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class ExpenseReport : Problem
    {
        public override void PartOne(string expenseReport)
        {
            var expenseReportList = expenseReport.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            foreach (var expense in expenseReportList)
            {
                foreach (var sumExpense in expenseReportList)
                {
                    var convertedExpense = int.Parse(expense);
                    var convertedSumExpense = int.Parse(sumExpense);

                    if (convertedExpense + convertedSumExpense == 2020)
                    {
                        Console.WriteLine("Expense Report Part One Answer: " + convertedExpense * convertedSumExpense);
                        return;
                    }
                }
            }
        }

        public override void PartTwo(string expenseReport)
        {
            var expenseReportList = expenseReport.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            foreach (var expense in expenseReportList)
            {
                foreach (var sumExpenseOne in expenseReportList)
                {
                    foreach (var sumExpenseTwo in expenseReportList)
                    {
                        var convertedExpense = int.Parse(expense);
                        var convertedSumExpenseOne = int.Parse(sumExpenseOne);
                        var convertedSumExpenseTwo = int.Parse(sumExpenseTwo);

                        if (convertedExpense + convertedSumExpenseOne + convertedSumExpenseTwo == 2020)
                        {
                            Console.WriteLine("Expense Report Part Two Answer: " + convertedExpense * convertedSumExpenseOne * convertedSumExpenseTwo);
                            return;
                        }
                    }
                }
            }
        }
    }


}
