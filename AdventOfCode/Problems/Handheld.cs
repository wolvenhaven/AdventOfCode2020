using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Problems
{
    public class Handheld : Problem
    {
        public override void PartOne(string instructions)
        {
            var instructionsSplit = instructions.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            var instructionsArray = GenerateInstructionsList(instructionsSplit).ToArray();

            var accumulator = 0;

            for (int i = 0; i < instructionsArray.Count(); i++)
            {
                var instruction = instructionsArray[i];

                if (instruction.HasBeenExecuted)
                {
                    Console.WriteLine("Handheld Part One Answer: " + accumulator);
                    break;
                }

                if (instruction.InstructionType == "acc")
                {
                    accumulator += instruction.Amount;
                    instruction.HasBeenExecuted = true;
                }
                else if (instruction.InstructionType == "jmp")
                {
                    i = i + instruction.Amount - 1;
                    instruction.HasBeenExecuted = true;
                }
                else if (instruction.InstructionType == "nop")
                {
                    instruction.HasBeenExecuted = true;
                }
            }
        }

        public override void PartTwo(string instructions)
        {
            var instructionsSplit = instructions.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            var listOfInstructionsList = new List<List<Instruction>>();

            var initialInstructionsList = GenerateInstructionsList(instructionsSplit);

            var jmpInstructions = initialInstructionsList.Where(x => x.InstructionType == "jmp").ToList();
            var nopInstructions = initialInstructionsList.Where(x => x.InstructionType == "nop").ToList();

            var jmpModifiedInstructions = ModifyInstructions(initialInstructionsList, jmpInstructions, "nop");
            var nopModifiedInstructions = ModifyInstructions(initialInstructionsList, nopInstructions, "jmp");

            listOfInstructionsList.Add(initialInstructionsList);
            listOfInstructionsList.AddRange(jmpModifiedInstructions);
            listOfInstructionsList.AddRange(nopModifiedInstructions);

            //PrintInstructionLists(listOfInstructionsList);

            foreach (var instructionList in listOfInstructionsList)
            {
                ExecuteInstructions(instructionList.ToArray());
            }
        }

        private List<Instruction> GenerateInstructionsList(List<string> instructionsSplit)
        {
            var instructionsList = new List<Instruction>();

            foreach (var instructionSet in instructionsSplit)
            {
                var instructionSetSplit = instructionSet.Split(" ");

                instructionsList.Add(new Instruction { InstructionType = instructionSetSplit[0], Amount = int.Parse(instructionSetSplit[1]) });
            }

            return instructionsList;
        }

        private void ExecuteInstructions(Instruction[] instructionsArray)
        {
            var accumulator = 0;

            for (int i = 0; i < instructionsArray.Count(); i++)
            {
                var instruction = instructionsArray[i];

                
                if (instruction.HasBeenExecuted)
                {
                    //Console.WriteLine("Handheld Part Two Loop Detected");
                    return;
                }

                if (instruction.InstructionType == "acc")
                {
                    accumulator += instruction.Amount;
                    instruction.HasBeenExecuted = true;
                }
                else if (instruction.InstructionType == "jmp")
                {
                    i = i + instruction.Amount - 1;
                    instruction.HasBeenExecuted = true;
                }
                else if (instruction.InstructionType == "nop")
                {
                    instruction.HasBeenExecuted = true;
                }
            }

            Console.WriteLine("Handheld Part Two Answer: " + accumulator);
        }

        private List<List<Instruction>> ModifyInstructions(List<Instruction> instructionsList, List<Instruction> instructionsToModify, string modifiedInstructionType)
        {
            var listOfModifiedInstructionList = new List<List<Instruction>>();

            foreach (var instructionToModify in instructionsToModify)
            {
                var modifiedInstructionsList = instructionsList.Select(x => new Instruction { InstructionType = x.InstructionType, Amount = x.Amount }).ToList();

                var indexOfInstructionToModify = instructionsList.IndexOf(instructionToModify);

                modifiedInstructionsList[indexOfInstructionToModify].InstructionType = modifiedInstructionType;

                listOfModifiedInstructionList.Add(modifiedInstructionsList);
            }

            return listOfModifiedInstructionList;
        }

        private void PrintInstructionLists(List<List<Instruction>> listOfInstructionsLists)
        {
            foreach (var listOfInstructions in listOfInstructionsLists)
            {
                Console.WriteLine("List #: " + listOfInstructionsLists.IndexOf(listOfInstructions));
                foreach (var instruction in listOfInstructions)
                {
                    Console.WriteLine("InstructionType: " + instruction.InstructionType + ", Amount: " + instruction.Amount);
                }

                Console.WriteLine("\r\n");
            }
        }
    }

    class Instruction
    {
        public string InstructionType { get; set; }
        public int Amount { get; set; }
        public bool HasBeenExecuted { get; set; }

        public Instruction()
        {
            this.HasBeenExecuted = false;
        }
    }
}
