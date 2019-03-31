using System;
using System.Collections.Generic;
using System.Text;
using CoderGirl_SalesList;
using Xunit;

namespace Test
{
    public class SalesRecordAnalyzerTest
    {
        ISalesRecordAnalyzer salesRecordAnalyzer;

        public SalesRecordAnalyzerTest()
        {
            salesRecordAnalyzer = new Factory().SalesRecordAnalyzer;
        }

        [Theory]
        [InlineData("4/20/2014", true)]
        [InlineData("4/20/2013", false)]
        [InlineData("4/20/2020", true)]
        public void TestOrderDatesBefore(string cuttoff, bool expected)
        {
            DateTime testDate = DateTime.Parse(cuttoff);
            List<SalesRecord> salesRecords = new List<SalesRecord>
            {
                new SalesRecord{OrderDate = DateTime.Parse("4/19/2014")},
                new SalesRecord{OrderDate = DateTime.Parse("4/18/2014")},
                new SalesRecord{OrderDate = DateTime.Parse("4/20/2014")},
                new SalesRecord{OrderDate = DateTime.Parse("4/19/2019")}
            };

            bool actual = salesRecordAnalyzer.AreOrderDatesBefore(testDate, salesRecords);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetCountries()
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>
            {
                new SalesRecord{Country = "Country1"},
                new SalesRecord{Country = "Country2"},
                new SalesRecord{Country = "Country3"},
                new SalesRecord{Country = "country3"},
                new SalesRecord{Country = "Country2"}
            };

            List<string> actual = salesRecordAnalyzer.GetCountries(salesRecords);

            Assert.Equal(4, actual.Count);
            Assert.Contains(actual, country => country == "Country1");
            Assert.Contains(actual, country => country == "Country2");
            Assert.Contains(actual, country => country == "Country3");
            Assert.Contains(actual, country => country == "country3");
        }

        [Fact]
        public void TestGetCountryCount()
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>
            {
                new SalesRecord{Country = "Country1"},
                new SalesRecord{Country = "Country2"},
                new SalesRecord{Country = "Country3"},
                new SalesRecord{Country = "country3"},
                new SalesRecord{Country = "Country2"}
            };

            int actual = salesRecordAnalyzer.GetCountryCount(salesRecords);

            Assert.Equal(4, actual);
        }

        [Fact]
        public void TestGetMaxProfit()
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>
            {
                new SalesRecord{TotalProfit = 17.2},
                new SalesRecord{TotalProfit = 17.0},
                new SalesRecord{TotalProfit = 0.0},
                new SalesRecord{TotalProfit = 17.1},
                new SalesRecord{TotalProfit = 10.0}
            };

            decimal actual = salesRecordAnalyzer.GetMaxProfit(salesRecords);

            Assert.Equal((decimal)17.2, actual);
        }
    }
}
