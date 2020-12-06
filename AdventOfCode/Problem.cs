using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public abstract class Problem
    {
        public abstract void PartOne(string input);

        public abstract void PartTwo(string input);

        public void Execute(string input)
        {
            PartOne(input);
            PartTwo(input);
        }
    }
}
