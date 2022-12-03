using System;

namespace December2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var points = 0;
            while (!(line = Console.ReadLine()).Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                var split = line.Split(' ');
                var left = split[0];
                var right = split[1];
                points += RoundPart2(left, right);
            }
            Console.WriteLine(points);
        }
        
        private static int RoundPart2(string left, string right)
        {
            var points = 0;
            //A = Rock
            //B = Paper
            //C = Scissor
            //X = Rock (1) (LOSE)
            //Y = Paper (2) (DRAW)
            //Z Scissor (3) (WIN)
            //lose = 0
            //Draw = 3
            //Win = 6
            switch (left)
            {
                case "A":
                    switch (right)
                    {
                        case "Y":
                            points += 1 + 3;
                            break;
                        case "X":
                            points += 3 + 0;
                            break;
                        case "Z":
                            points += 2 + 6;
                            break;
                    }
                    break;
                case "B":
                    switch (right)
                    {
                        case "Y":
                            points += 2 + 3;
                            break;
                        case "X":
                            points += 1 + 0;
                            break;
                        case "Z":
                            points += 3 + 6;
                            break;
                    }
                    break;
                case "C":
                    switch (right)
                    {
                        case "Y":
                            points += 3 + 3;
                            break;
                        case "X":
                            points += 2 + 0;
                            break;
                        case "Z":
                            points += 1 + 6;
                            break;
                    }
                    break;
            }
            return points;
        }
        private static int Round(string left, string right)
        {
            var points = 0;
            //A = Rock
            //B = Paper
            //C = Scissor
            //X = Rock (1)
            //Y = Paper (2)
            //Z Scissor (3)
            //lose = 0
            //Draw = 3
            //Win = 6
            switch (left)
            {
                case "A":
                    switch (right)
                    {
                        case "Y":
                            points += 2 + 6;
                            break;
                        case "X":
                            points += 1 + 3;
                            break;
                        case "Z":
                            points += 3 + 0;
                            break;
                    }
                    break;
                case "B":
                    switch (right)
                    {
                        case "Y":
                            points += 2 + 3;
                            break;
                        case "X":
                            points += 1 + 0;
                            break;
                        case "Z":
                            points += 3 + 6;
                            break;
                    }
                    break;
                case "C":
                    switch (right)
                    {
                        case "Y":
                            points += 2 + 0;
                            break;
                        case "X":
                            points += 1 + 6;
                            break;
                        case "Z":
                            points += 3 + 3;
                            break;
                    }
                    break;
            }
            return points;
        }
    }
}