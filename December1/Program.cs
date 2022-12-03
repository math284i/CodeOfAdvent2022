using System;
using System.Collections;

namespace December1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var currentValue = 0;
            var topList = new ArrayList();
            while (!(line = Console.ReadLine()).Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                if (line.Length == 0)
                {
                    var min = getMinFromList(topList);
                    if (topList.Count < 3)
                    {
                        topList.Add(currentValue);
                    }
                    if (currentValue > min)
                    {
                        topList.Remove(min);
                        topList.Add(currentValue);
                    }
                    currentValue = 0;
                    continue;
                }
                currentValue += Int32.Parse(line);
            }

            var result = 0;
            foreach (int value in topList)
            {
                result += value;
            }
            Console.WriteLine(result);
        }

        public static int getMinFromList(ArrayList topList)
        {
            var temp = int.MaxValue;
            foreach (int VARIABLE in topList)
            {
                temp = Math.Min(temp, VARIABLE);
            }
            return temp;
        }
        
    }
}