using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class InvoiceWork
    {
        public int Id { get; set; }

        public Invoice Invoice { get; set; }

        public string WorkName { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal WorkAmountUnits { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal PricePerWorkAmountUnit { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal VatRate { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal TaxReductionRate { get; set; }
    }
}
