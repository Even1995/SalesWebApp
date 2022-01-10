using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApp.Models
{
    public class SaleRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SaleRecord()
        {

        }
        public SaleRecord(int id, DateTime date, double amount, SaleStatus status, Seller Seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            this.Seller = Seller;
        }
    }
}
