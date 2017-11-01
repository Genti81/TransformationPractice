using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace TransformTestsLib
{
    [TestClass]
    public class TransformTests
    {
        [TestMethod]
        public void CheckRows()
        {
            var amount = "C#;2018-01-01;2018-02-05";
            //var equal = "Kursen C# pågår i 35 dagar med följande deltagare:";
            var tuple = new Tuple<string, DateTime, DateTime>("C#", DateTime.Parse("2018-01-01"), DateTime.Parse("2018-02-05"));
            var tuple1 = new Tuple<string, List<string>>("Alice", new List<string>() { "C#", "SQL", "MVC" });

            // tuple
            var kurs = tuple.Item1;
            var difDates = tuple.Item3 - tuple.Item2;

            // tuple1
            var name = tuple1.Item1;
            //var kursen = tuple1.Item2.Contains("C#");
            var kursen = tuple1.Item2[0];

            Debug.WriteLine(kursen);
            var newLine = $"Krsen {kursen} pågår i {difDates} dagar med följande deltagare: {name}";


        }
    }
}
