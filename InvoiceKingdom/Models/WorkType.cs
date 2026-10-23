using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class WorkType
    {
        #region Database fields
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal VatRate { get; set; }

        public decimal TexReductionRate { get; set; }

        public bool IsHidden { get; set; } = false;
        #endregion
    }
}
