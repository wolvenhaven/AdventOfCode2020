using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class Seats : Problem
    {
        public override void PartOne(string seats)
        {
            var seatSplit = seats.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();
            var seatIDs = new List<int>();

            foreach (var seat in seatSplit)
            {
                var seatMoves = seat.ToCharArray();
                var rowList = new List<int>();
                var seatList = new List<int>();

                for (int i = 0; i < 128; i++)
                {
                    rowList.Add(i);
                }

                for (int i = 0; i < 8; i++)
                {
                    seatList.Add(i);
                }

                foreach (var move in seatMoves)
                {
                    var rowCount = rowList.Count;
                    var rowDivider = rowCount / 2;

                    var seatCount = seatList.Count;
                    var seatDivider = seatCount / 2;

                    if (move == 'F')
                    {
                        rowList.RemoveRange(rowDivider, rowCount - rowDivider);
                    }
                    else if (move == 'B')
                    {
                        rowList.RemoveRange(0, rowDivider);
                    }
                    else if (move == 'R')
                    {
                        seatList.RemoveRange(0, seatDivider);
                    }
                    else if (move == 'L')
                    {
                        seatList.RemoveRange(seatDivider, seatCount - seatDivider);
                    }

                    if (rowList.Count == 1 && seatList.Count == 1)
                    {
                        seatIDs.Add((rowList.First() * 8) + seatList.First());
                    }
                }
            }

            var answer = seatIDs.Max();

            Console.WriteLine("Seats Part One Answer: " + answer);
        }

        public override void PartTwo(string seats)
        {
            var seatSplit = seats.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();
            var seatIDs = new List<int>();

            foreach (var seat in seatSplit)
            {
                var seatMoves = seat.ToCharArray();
                var rowList = new List<int>();
                var seatList = new List<int>();

                for (int i = 0; i < 128; i++)
                {
                    rowList.Add(i);
                }

                for (int i = 0; i < 8; i++)
                {
                    seatList.Add(i);
                }

                foreach (var move in seatMoves)
                {
                    var rowCount = rowList.Count;
                    var rowDivider = rowCount / 2;

                    var seatCount = seatList.Count;
                    var seatDivider = seatCount / 2;

                    if (move == 'F')
                    {
                        rowList.RemoveRange(rowDivider, rowCount - rowDivider);
                    }
                    else if (move == 'B')
                    {
                        rowList.RemoveRange(0, rowDivider);
                    }
                    else if (move == 'R')
                    {
                        seatList.RemoveRange(0, seatDivider);
                    }
                    else if (move == 'L')
                    {
                        seatList.RemoveRange(seatDivider, seatCount - seatDivider);
                    }

                    if (rowList.Count == 1 && seatList.Count == 1)
                    {
                        seatIDs.Add((rowList.First() * 8) + seatList.First());
                    }
                }
            }

            var calculatedSeats = new List<int>();

            for (int i = 0; i < 128; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    calculatedSeats.Add((i * 8) + x);
                }
            }

            foreach (var seat in seatIDs)
            {
                calculatedSeats.Remove(seat);
            }

            foreach (var possibleSeat in calculatedSeats)
            {
                if (seatIDs.Contains(possibleSeat + 1) && seatIDs.Contains(possibleSeat - 1))
                {
                    Console.WriteLine("Seats Part Two Answer: " + possibleSeat);
                    break;
                }
            }
        }
    }
}
