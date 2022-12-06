using System;
using System.IO;
using System.Linq;

namespace December6
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "input.txt";
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            //Part1(path, 4);
            Part2(path);
        }

        private static void Part1(string path, int messageLength)
        {
            var output = "";
            var index = 0;
            foreach (var line in File.ReadLines(path))
            {
                foreach (var element in line)
                {
                    if (output.Contains(element))
                    {
                        output = "" + element;
                    }
                    else
                    {
                        output += element;
                        if (output.Length == messageLength)
                        {
                            break;
                        }
                    }

                    index++;
                }
            }
            Console.WriteLine(index);
        }

        private static void Part2(string path)
        {
            Part1(path, 14);
        }
    }
}