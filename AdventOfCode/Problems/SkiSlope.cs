using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class SkiSlope : Problem
    {
        public override void PartOne(string skiSlope)
        {
            var skiSlopeMapRows = skiSlope.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            String[][] skiSlopeMap = new String[skiSlopeMapRows.Length][];

            for (int i = 0; i < skiSlopeMapRows.Length; i++)
            {
                skiSlopeMap[i] = skiSlopeMapRows[i].ToCharArray().Select(c => c.ToString()).ToArray();
            }

            var treeCount = 0;

            var width = skiSlopeMap[0].Length;

            for (int i = 0; i < skiSlopeMap.Length; i++)
            {
                var xPos = (i * 3) % width;

                if (skiSlopeMap[i][xPos] == "#")
                {
                    treeCount++;
                }
            }

            Console.WriteLine("Ski Slope Part One Answer:  " + treeCount);
        }

        public override void PartTwo(string skiSlope)
        {
            var skiSlopeMapRows = skiSlope.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            String[][] skiSlopeMap = new String[skiSlopeMapRows.Length][];

            for (int i = 0; i < skiSlopeMapRows.Length; i++)
            {
                skiSlopeMap[i] = skiSlopeMapRows[i].ToCharArray().Select(c => c.ToString()).ToArray();
            }

            var width = skiSlopeMap[0].Length;
            var treeCounts = new List<int>();

            var Moves = new List<int[]>
            {
                new int[]{ 1, 1 },
                new int[]{ 3, 1 },
                new int[]{ 5, 1 },
                new int[]{ 7, 1 },
                new int[]{ 1, 2 },
            };

            foreach (var move in Moves)
            {
                var treeCount = 0;
                var xMove = move[0];
                var yMove = move[1];

                for (int i = 0; i < skiSlopeMap.Length; i += yMove)
                {
                    var xPos = ((i / yMove) * xMove) % width;

                    if (skiSlopeMap[i][xPos] == "#")
                    {
                        treeCount++;
                    }
                }

                treeCounts.Add(treeCount);
            }

            Int64 answer = 1;

            foreach (var count in treeCounts)
            {
                answer = answer * count;
            }

            Console.WriteLine("Ski Slope Part Two Answer:  " + answer);
        }
    }
}
