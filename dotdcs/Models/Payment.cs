using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotdcs.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int CreditId { get; set; }
        public Credit credit { get; set; }
    }
}
