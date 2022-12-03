using System;
using System.Collections.Generic;
using System.IO;

namespace December3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "input.txt";
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            //Part1(path);
            Part2(path);
        }

        private static void Part2(string path)
        {
            var points = 0;
            var lines = new List<string>();
            foreach (var line in File.ReadLines(path)) //We need 1 more iteration, so just added a line in input :3
            {
                if (lines.Count < 3)
                {
                    lines.Add(line);
                }
                else
                {
                    foreach (var element in lines[0])
                    {
                        if (lines[1].Contains(element) && lines[2].Contains(element))
                        {
                            points += char.IsUpper(element) ? (element - 64 + 26) : element - 64 - 32;
                            break;
                        }
                    }
                    lines = new List<string>(); //This is bad lmao
                    lines.Add(line);
                }
            }
            System.Console.WriteLine(points);
        }

        private static void Part1(string path)
        {
            var points = 0; 
            foreach (var line in File.ReadLines(path))
            {
                var size = line.Length;
                var middle = size / 2;
                var firstPart = line?[0..middle];
                var secondPart = line?[middle..size];
                foreach (var element in firstPart)
                {
                    if (!secondPart.Contains(element)) continue;
                    points += char.IsUpper(element) ? (element - 64 + 26) : element - 64 - 32;
                    break;
                }
            }
            System.Console.WriteLine(points);
        }
        
    }
}