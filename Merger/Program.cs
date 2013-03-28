using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Merger
{
    class Program
    {
        private const int TotalParams = 3;
        private static IEnumerable<int> ConvertFileToArray(string filename)
        {
            return File.ReadAllLines(filename).Select(int.Parse);
        }

        static void Main(string[] args)
        {
            if (args.Length == TotalParams)
            {
                string inputFile1 = args[0], inputFile2 = args[1], outputFile = args[2];

                try
                {
                    var list = new List<int>();
                    list.AddRange(ConvertFileToArray(inputFile1));
                    list.AddRange(ConvertFileToArray(inputFile2));
                    File.WriteAllLines(outputFile, list.OrderBy(i => i).Select(i => i.ToString()).ToArray());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Usage: Merger.exe input1.txt input2.txt output.txt");
            }

        }
    }
}
