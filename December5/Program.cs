using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;

namespace December5
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "input.txt";
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            //Part1(path, true);
            Part2(path);
        }
        
        private static string Reverse( string s )
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static void Part1(string path, bool shouldReverse)
        {
            var lines = new List<string>();
            var strings = new List<string>();
            var height = 7; //7
            var width = 9 - 1; //9
            foreach (var line in File.ReadLines(path))
            {
                if (lines.Count < height)
                {
                    lines.Add(line);
                    strings.Add("");
                }
                else if (lines.Count == height)
                {
                    lines.Add(line);
                    strings.Add("");
                    strings.Add("");
                    lines.Reverse();
                    for (var i = 0; i < lines.Count; i++)
                    {
                        var index = 0;
                        for (var j = 0; j < lines[i].Length; j++)
                        {
                            if (j != 1 && (j % 4 != 1)) continue;
                            if (lines[i][j] != ' ')
                            {
                                var tmp = strings[index];
                                strings[index] = tmp + lines[i][j];
                            }
                            index++;
                            if (index > width) index = 0;
                        }
                    }
                } 
                else
                {
                    var numbers = line.Split(' ');
                    if (numbers.Length != 6) continue;
                    var amount = int.Parse("" + numbers[1]);
                    var from = int.Parse("" + numbers[3]) - 1;
                    var to = int.Parse("" + numbers[5]) - 1;
                    var original = strings[from];
                    var diff = shouldReverse ? Reverse(original?[^amount..original.Length]) 
                        : original?[^amount..original.Length];
                    var tmp = strings[to];
                    var newOld = original?[0..^amount];
                    strings[to] = tmp + diff;
                    strings[from] = newOld;
                }
            }

            var outputString = strings.Aggregate("", (current, str) => current + str[^1]);
            Console.WriteLine(outputString);
        }

        private static void Part2(string path)
        {
            Part1(path, false);
        }
    }
}