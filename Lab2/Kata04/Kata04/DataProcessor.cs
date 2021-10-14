using System;
using System.Collections.Generic;
using System.IO;

namespace Kata04
{
    public class DataProcessor
    {

        private readonly string FilePath;

        public DataProcessor(string FilePath)
        {
            this.FilePath = FilePath;
        }
        public string[] GetLines()
        {
            return File.ReadAllLines(Environment.CurrentDirectory + '\\' + FilePath);
        }

        public List<List<string>> GetFormattedLines(params int[] requiredColumns)
        {
            List<List<string>> formattedLines = new List<List<string>>();
            string[] readLines = this.GetLines();
            foreach (string line in readLines)
            {
                string[] lineColumns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                List<string> formattedLineColumns = new List<string>();
                foreach (int column in requiredColumns)
                {
                    if (column < lineColumns.Length)
                    {
                        formattedLineColumns.Add(lineColumns[column]);
                    }
                }
                formattedLines.Add(formattedLineColumns);
            }
            return formattedLines;
        }

        public string GetDataResult(List<List<string>> data)
        {
            int resultLine = -1;
            double smallestDifference = double.PositiveInfinity;
            for (int lineIndex = 0; lineIndex < data.Count; lineIndex++)
            {
                if (data[lineIndex].Count != 3)
                {
                    continue;
                }
                int minimumValue, maximumValue;
                if (int.TryParse(data[lineIndex][1], out maximumValue) && int.TryParse(data[lineIndex][2], out minimumValue))
                {
                    if (Math.Abs(maximumValue - minimumValue) < smallestDifference)
                    {
                        smallestDifference = Math.Abs(maximumValue - minimumValue);
                        resultLine = lineIndex;
                    }
                }
            }
            return data[resultLine][0];
        }
    }
}
