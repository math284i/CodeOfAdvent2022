using System;
using System.IO;

namespace December3
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;  
            var fileName = "input.txt";
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            
            foreach (var line in File.ReadLines(path))
            {
                var size = line.Length;
                var middle = size / 2;
                var fistPath = line?[0..middle];
                var secondPath = line?[middle..size];
                System.Console.WriteLine(fistPath);
                System.Console.WriteLine(secondPath);
            }  
  
            System.Console.WriteLine("There were {0} lines.", counter);
        }
    }
}