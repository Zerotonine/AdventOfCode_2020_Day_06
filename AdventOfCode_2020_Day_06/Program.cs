using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_2020_Day_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>(File.ReadAllText("input.txt").Split(Environment.NewLine + Environment.NewLine));

            Console.WriteLine("Solution One: " + PuzzleOne(inputList));
            Console.WriteLine("Solution Two: " + PuzzleTwo(inputList));
            Console.ReadKey(true);
        }

        static int PuzzleOne(in List<string> input)
        {
            HashSet<char> chars;
            List<int> numberOfYes = new List<int>();
            List<string> inputList = new List<string>();

            input.ForEach(s => inputList.Add(s.Replace(Environment.NewLine, "")));

            inputList.ForEach(s =>{
                chars = new HashSet<char>(s);
                numberOfYes.Add(chars.Count);
            });

            return numberOfYes.Sum();
        }

        static int PuzzleTwo(in List<string> input)
        {
            int numberOfPeople, yesCounter;
            List<int> numberOfYes = new List<int>();

            input.ForEach(s=> {
                yesCounter = 0;
                numberOfPeople = s.Split(Environment.NewLine).Length;
                foreach(char c in s.Replace(Environment.NewLine, "").Distinct())
                {
                    if (s.Count(x => c == x) == numberOfPeople)
                        yesCounter++;
                }
                numberOfYes.Add(yesCounter);
            });

            return numberOfYes.Sum();
        }
    }
}
