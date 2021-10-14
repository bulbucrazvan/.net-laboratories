using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata04.PartOne
{
    public class WeatherData
    {
        private readonly string FileName;

        public WeatherData(string FileName)
        {
            this.FileName = FileName;
        }
        //pre-factoring code
        private int ComputeSmallestSpread(List<List<string>> data)
        {
            double smallestSpread = double.PositiveInfinity;
            int smallestSpreadDay = 1;
            foreach (var line in data)
            {
                if (line.Count != 3)
                {
                    continue;
                }
                int day;
                if (int.TryParse(line[0], out day))
                {
                    int minTemperature, maxTemperature;
                    if (int.TryParse(line[1], out maxTemperature) && int.TryParse(line[2], out minTemperature)){
                        if ((maxTemperature - minTemperature) < smallestSpread)
                        {
                            smallestSpread = maxTemperature - minTemperature;
                            smallestSpreadDay = day;
                        }
                    }
                }
            }
            return smallestSpreadDay;
        }
        public string GetSmallestSpreadDay()
        {
            DataProcessor dataProcessor = new DataProcessor(FileName);
            List<List<string>> formattedLines = dataProcessor.GetFormattedLines(0, 1, 2);
            return dataProcessor.GetDataResult(formattedLines);
            //return ComputeSmallestSpread(formattedLines);
        }
    }
}
