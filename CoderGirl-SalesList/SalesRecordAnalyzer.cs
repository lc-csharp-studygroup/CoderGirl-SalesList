using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{
    class SalesRecordAnalyzer : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            // Returns true if there are any OrderDates before the cuttoff date, else returns false
            return salesRecords.Any(records => records.OrderDate < cutoffDate);
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            // Returns unique list of countries for which there are a Sales Record
            return salesRecords.Select(record => record.Country).Distinct().ToList();
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.Country).Distinct().Count();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {

            return salesRecords.Max(record => record.TotalProfit);
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            return salesRecords.Sum(record => record.TotalRevenue);
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            return salesRecords.OrderBy(record => record.ShipDate).ToList();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
           return salesRecords.OrderByDescending(record => record.UnitsSold).ToList();
        }
    }
}
