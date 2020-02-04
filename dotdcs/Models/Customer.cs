using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotdcs.Models
{

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentID { get; set; }
        public int WalletId { get; set; }
        public Wallet wallet { get; set; }
        public ICollection<Credit> credits { get; set; }
    }   
}
