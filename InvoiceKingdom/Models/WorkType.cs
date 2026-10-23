using InvoiceKingdom.Data;
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

        public DateTime Created { get; set; } = DateTime.Now;

        public bool IsHidden { get; set; } = false;
        #endregion

        public static void CreateWorkType(
            InvoiceKingdomContext context,
            string name,
            decimal vatRate,
            decimal taxReductionRate
            )
        {
            name = name.Trim();

            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            if (vatRate < 0 || vatRate > 1) throw new ArgumentOutOfRangeException("vatRate");
            if (taxReductionRate < 0 || taxReductionRate > 1) throw new ArgumentOutOfRangeException("taxReductionRate");

            try
            {
                var workType = new WorkType()
                {
                    Name = name,
                    VatRate = vatRate,
                    TexReductionRate = taxReductionRate
                };

                context.WorkTypes.Add(workType);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
