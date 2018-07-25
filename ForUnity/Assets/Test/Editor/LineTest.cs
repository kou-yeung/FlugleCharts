using System;
using System.Diagnostics;
using FlugleCharts;
using System.Drawing;
using NUnit.Framework;
//using UnityEngine;

namespace Test
{
    [TestFixture]
    public class LineTest
    {
        [Test]
        public void TestLine1()
        {
            var s1 = new Series()
            {
                Legend = "data",
                Color = Color.Green
            };

            s1.Add(80);
            s1.Add(40);
            s1.Add(110);
            s1.Add(30);

            var s2 = new Series()
            {
                Legend = "data 2",
                Color = Color.Red
            };

            s2.Add(170);
            s2.Add(150);
            s2.Add("oh snap", 80);
            s2.Add(30);

            var line = ChartBuilder.Line()
                                  .Title("bar yo")
                                  .Size(400, 200)
                                  .ShowLegend(Position.right)
                                  .AddSeries(s1)
                                  .AddSeries(s2)
                                  .AddAxes(Position.left, 0, 170, 30, "left data")
                                  .AddAxes(Position.bottom, 1, 4, 1, "number");

            var url = line.GetUrl();
            Debug.WriteLine(line.GetUrl());
            Assert.AreEqual(url, "http://chart.apis.google.com/chart?cht=lc&chs=400x200&chtt=bar+yo&chco=00FF00,FF0000&chd=t:80,40,110,30|170,150,80,30&chl=oh+snap&chdlp=r&chdl=data|data+2&chxt=y,y,x,x&chxr=0,0,170,30|2,1,4,1|&chxl=1:|left+data|3:|number&chxp=1,50&3,50");

        }

        [Test]
        public void TestLine2()
        {
            var s1 = new Series()
            {
                Legend = "Data"
            };
            s1.Add(40);
            s1.Add(60);
            s1.Add(60);
            s1.Add(45);
            s1.Add(47);
            s1.Add(75);
            s1.Add(70);
            s1.Add(72);

            var line = ChartBuilder.Line()
                                  .Size(200, 125)
                                  .AddSeries(s1);

            var url = line.GetUrl();
            Debug.WriteLine(url);

            Assert.AreEqual(url, "http://chart.apis.google.com/chart?cht=lc&chs=200x125&chd=t:40,60,60,45,47,75,70,72");

        }


        [Test]
        public void TestLine3()
        {
            var s1 = new Series()
            {
                Legend = "Data",
                Color = ColorTranslator.FromHtml("#0077CC")
            };
            s1.Add(27); s1.Add(25);
            s1.Add(60); s1.Add(31);
            s1.Add(25); s1.Add(39);
            s1.Add(25); s1.Add(31);
            s1.Add(26); s1.Add(28);
            s1.Add(80); s1.Add(28);
            s1.Add(27); s1.Add(31);
            s1.Add(27); s1.Add(29);
            s1.Add(26); s1.Add(35);
            s1.Add(70); s1.Add(25);

            var line = ChartBuilder.Line(LineType.SparkLine)
                                  .Size(200, 125)
                                  .AddSeries(s1);

            var url = line.GetUrl();
            Debug.WriteLine(url);

            Assert.AreEqual(url, "http://chart.apis.google.com/chart?cht=ls&chs=200x125&chco=0077CC&chd=t:27,25,60,31,25,39,25,31,26,28,80,28,27,31,27,29,26,35,70,25");

        }


        [Test]
        public void TestLine4()
        {
            var s1 = new Series
            {
                Legend = "Ponies",
                Color = ColorTranslator.FromHtml("#3072F3"),
                LineThickness = 2,
                DashLength = 4,
                SpaceLength = 1
            };
            s1.Add(10); s1.Add(20);
            s1.Add(40); s1.Add(80);
            s1.Add(90); s1.Add(95);
            s1.Add(99);

            var s2 = new Series();
            s2.Add(20); s2.Add(30);
            s2.Add(40); s2.Add(50);
            s2.Add(60); s2.Add(70);
            s2.Add(80);

            var s3 = new Series
            {
                Legend = "Unicorns",
                Color = Color.Red
            };
            s3.Add(-1);

            var s4 = new Series
            {
                Color = ColorTranslator.FromHtml("#00aaaa")
            };
            s4.Add(5); s4.Add(10);
            s4.Add(22); s4.Add(35);
            s4.Add(85);

            var line = ChartBuilder.Line(LineType.LineXY)
                                  .Size(200, 125)
                                  .ShowLegend(Position.top)
                                  .AddSeries(s1)
                                  .AddSeries(s2)
                                  .AddSeries(s3)
                                  .AddSeries(s4);

            var url = line.GetUrl();
            Debug.WriteLine(url);

            Assert.AreEqual(url, "http://chart.apis.google.com/chart?cht=lxy&chs=200x125&chls=2,4,1&chco=3072F3,FF0000,00AAAA&chd=t:10,20,40,80,90,95,99|20,30,40,50,60,70,80|-1|5,10,22,35,85&chdlp=t&chdl=Ponies|Unicorns");

        }

    }
}
