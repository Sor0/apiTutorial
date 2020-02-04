using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotdcs.Models
{
    public class Credit
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public int Interest { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Term { get; set; }
        public bool IsPaid { get; set; }
        public bool IsSpecial { get; set; }

        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public double Debt
        {
            get
            {
                return this.GetDueDays();
            }
        }

        public double GetDueDays()
        {
            return this.Total;
        }

        public DateTime GetExpirationDate()
        {
            return this.Date.AddDays(this.Term);
        }
    }
}
