using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class TaxType
    {
        public enum AvailableTaxType
        {
            VAT,
            ReductionRUT,
            ReductionROT
        }

        public int Id { get; set; }

        public required AvailableTaxType Type { get; set; }

        public required string Name { get; set; }

        public required decimal Rate { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
