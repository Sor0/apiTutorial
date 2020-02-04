using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotdcs.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IntialBalance { get; set; }

        public int UploadPercent { get; set; }
        public ICollection<Customer> customers { get; set; }

        public Wallet()
        {
            this.UploadPercent = 10;
        }
    }
}
