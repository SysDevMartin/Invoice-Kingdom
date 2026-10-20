using InvoiceKingdom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Data
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceWork> InvoiceWork { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ApplicationData.db");
        }
    }
}
