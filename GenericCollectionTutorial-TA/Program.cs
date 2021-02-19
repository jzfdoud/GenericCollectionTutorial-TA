using System;
using System.Collections.Generic;

namespace GenericCollectionTutorial_TA
{
    class Program
    {
        static void Main(string[] args)
        {

            var WxHistory = new List<Weather>(3);
            var DtThr = new Weather
            {
                Today = new DateTime(2021, 02, 18),
                Temperature = 19,
                Percipitation = 3
            };
            WxHistory.Add(DtThr);

            var DtWed = new Weather
            {
                Today = new DateTime(2021, 02, 17),
                Temperature = 4,
                Percipitation = 0
            };
            WxHistory.Add(DtWed);

            var DtTue = new Weather
            {
                Today = new DateTime(2021, 02, 16),
                Temperature = 25,
                Percipitation = 2
            };
            WxHistory.Add(DtTue);

            foreach(var day in WxHistory)
            {
                var msg = $"Weather for {day.Today.ToString("dddd")} was {day.Temperature} degrees with {day.Percipitation} inches of percipitation";
            Console.WriteLine(msg);
            }
            var strs = new List<string>
            {
                "orange", "blue", "grey","red","black","green"
            };
            Console.WriteLine($"Favorite colour count: {strs.Count}");

            strs.Sort();
            foreach(var colour in strs)
            {
                Console.WriteLine($"Colour is: {colour}");
            }

            var ints = new List<int>();

            ints.Add(7);
            ints.Add(10);
            ints.Add(3);
            ints.Add(6);
            ints.Add(96);
            ints.Add(22);
        }
    }
}
