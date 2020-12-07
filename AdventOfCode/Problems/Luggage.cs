using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class Luggage : Problem
    {
        public override void PartOne(string luggageRules)
        {
            var luggageRulesSplit = luggageRules.Trim().Split("\r\n");

            var bags = luggageRulesSplit.Select(a => CreateBagFromSplit(a))
                                        .GroupBy(b => b.Color, b => b)
                                        .ToDictionary(c => c.Key, c => c.ElementAt(0));

            var answer = bags.Select(b => b.Key).Where(k => recursiveBagSearch(k, "shiny gold", bags)).Count();

            Console.WriteLine("Luggage Check Part One Answer: " + answer);

        }

        public override void PartTwo(string luggageRules)
        {
            var luggageRulesSplit = luggageRules.Trim().Split("\r\n");

            var bags = luggageRulesSplit.Select(a => CreateBagFromSplit(a))
                                        .GroupBy(b => b.Color, b => b)
                                        .ToDictionary(c => c.Key, c => c.ElementAt(0));

            var answer = countBags("shiny gold", bags) - 1;
            Console.WriteLine("Luggage Check Part Two Answer: " + answer);
        }

        private Bag CreateBagFromSplit(string line)
        {
            var bagSplit = line.Split(" ");

            Bag bag = new Bag() { Color = $"{bagSplit[0]} {bagSplit[1]}" };

            if (bagSplit.Length > 7)
            {
                for (int j = 4; j < bagSplit.Length; j += 4)
                {
                    var count = int.Parse(bagSplit[j]);
                    bag.InnerBags.Add(($"{bagSplit[j + 1]} {bagSplit[j + 2]}", count));
                }
            }

            return bag;
        }

        private bool recursiveBagSearch(string start, string key, Dictionary<string, Bag> bags)
        {
            var bag = bags[start];

            foreach (var b in bag.InnerBags)
            {
                if (b.Color == key)
                    return true;

                if (recursiveBagSearch(b.Color, key, bags))
                    return true;
            }

            return false;
        }

        private int countBags(string start, Dictionary<string, Bag> bags)
        {
            var bag = bags[start];

            return 1 + bag.InnerBags.Select(b => b.Quantity * countBags(b.Color, bags)).Sum();
        }
    }

    class Bag
    {
        public string Color { get; set; }
        public List<(string Color, int Quantity)> InnerBags { get; set; }

        public Bag()
        {
            this.InnerBags = new List<(string, int)>();
        }
    }
}
