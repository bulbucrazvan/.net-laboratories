using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata04.PartTwo
{
    class FootballData
    {
        private readonly string FileName;

        public FootballData(string FileName)
        {
            this.FileName = FileName;
        }

        //pre-factoring code
        private string ComputeBestTeam(List<List<string>> data)
        {
            double smallestGoalDifference = double.PositiveInfinity;
            string bestTeam = "Uncomputed";
            foreach (var line in data)
            {
                if (line.Count != 3)
                {
                    continue;
                }
                int goalsFor, goalsAgainst;
                if (int.TryParse(line[1], out goalsFor) && int.TryParse(line[2], out goalsAgainst))
                {
                    if (Math.Abs((goalsFor - goalsAgainst)) < smallestGoalDifference)
                    {
                        bestTeam = line[0];
                        smallestGoalDifference = Math.Abs(goalsFor - goalsAgainst);
                    }
                }
            }
            return bestTeam;
        }

        public string GetBestTeam()
        {
            DataProcessor dataProcessor = new DataProcessor(FileName);
            List<List<string>> formattedLines = dataProcessor.GetFormattedLines(1, 6, 8);
            return dataProcessor.GetDataResult(formattedLines);
            //return ComputeBestTeam(formattedLines);
        }
    }
}
