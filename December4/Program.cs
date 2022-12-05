using System;
using System.IO;

namespace December4
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

        private static void Part1(string path)
        {
            var count = 0;
            foreach (var line in File.ReadLines(path))
            {
                var pairs = line.Split(',');
                var leftPair = pairs[0].Split('-');
                var rightPair = pairs[1].Split('-');
                
                var leftSmall = int.Parse(leftPair[0]);
                var leftBig = int.Parse(leftPair[1]);
                
                var rightSmall = int.Parse(rightPair[0]);
                var rightBig = int.Parse(rightPair[1]);

                //Check if right is within left or left is within right
                if (leftBig - leftSmall > rightBig - rightSmall)
                {
                    if (leftSmall <= rightSmall && leftBig >= rightBig) count++;
                }
                else
                {
                    if (rightSmall <= leftSmall && rightBig >= leftBig) count++;
                }
                
            }
            Console.WriteLine(count);
        }
        
        private static void Part2(string path)
        {
            var count = 0;
            foreach (var line in File.ReadLines(path))
            {
                var pairs = line.Split(',');
                var leftPair = pairs[0].Split('-');
                var rightPair = pairs[1].Split('-');
                
                var leftSmall = int.Parse(leftPair[0]);
                var leftBig = int.Parse(leftPair[1]);
                
                var rightSmall = int.Parse(rightPair[0]);
                var rightBig = int.Parse(rightPair[1]);

                //Check if right is within left or left is within right
                if (leftBig - leftSmall > rightBig - rightSmall)
                {
                    if (leftSmall <= rightSmall && leftBig >= rightSmall) count++;
                    else if (leftSmall <= rightBig && leftBig >= rightBig) count++;
                }
                else
                {
                    if (rightSmall <= leftSmall && rightBig >= leftSmall) count++;
                    else if (rightSmall <= leftBig && rightBig >= leftBig) count++;
                }
                
            }
            Console.WriteLine(count);
        }
        
    }
}