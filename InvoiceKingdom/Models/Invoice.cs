using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class Invoice
    {
        public int Id { get; set; }

        public int InvoiceNumber { get; set; }

        public DateTime DueDate { get; set; }

        public string? Reference { get; set; }

        public bool IsCanceled { get; set; } = false;

        public required ICollection<InvoiceWork> InvoiceWork { get; set; }
    }
}
