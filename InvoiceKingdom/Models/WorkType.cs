using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class WorkType
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal VatRate { get; set; }

        public decimal TexReductionRate { get; set; }
    }
}
