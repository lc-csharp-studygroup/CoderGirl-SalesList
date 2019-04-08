using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    class SalesRecordAnalyzer : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }
    }
}
