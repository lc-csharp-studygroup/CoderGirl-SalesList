using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class SalesRecordRepository
    {
        public List<SalesRecord> SalesRecords { get; set; }

        public SalesRecordRepository()
        {
            this.SalesRecords = new List<SalesRecord>();
        }


    }
}
