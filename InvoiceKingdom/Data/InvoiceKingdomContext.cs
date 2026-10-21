using InvoiceKingdom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Data
{
    internal class InvoiceKingdomContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; } = null!;

        public DbSet<InvoiceWork> InvoiceWork { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ApplicationData.db");
        }
    }
}
