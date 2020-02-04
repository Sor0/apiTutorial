using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotdcs.Models;

namespace dotdcs.Context
{
    public class MyAppContext: DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public MyAppContext(DbContextOptions<MyAppContext> options): base(options) { }
    }
}
