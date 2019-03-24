using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        public void Run()
        {
            SalesRecordRepository repo = new SalesRecordRepository();
            
            using (StreamReader reader = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Data\1000 Sales Records.csv"))
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null){
                    List<string> properties = line.Split(",").ToList();
                    SalesRecord salesRecord = new SalesRecord();
                    salesRecord.Region = properties[0];
                    salesRecord.Country = properties[1];
                    salesRecord.ItemType = properties[2];
                    salesRecord.SalesChannel = properties[3];
                    salesRecord.OrderPriority = properties[4];
                    salesRecord.OrderDate = DateTime.Parse(properties[5]);
                    salesRecord.OrderID = Convert.ToInt64(properties[6]);
                    repo.SalesRecords.Add(salesRecord);
                }
            }
        }
    }
}
