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

        public required TaxType TaxSurchargeType { get; set; }

        public required TaxType TaxReductionType { get; set; }

        public ICollection<Customer> Customers { get; set; } = null!;

        public DateTime Created { get; set; } = DateTime.Now;

        public bool IsHidden { get; set; } = false;

        #endregion

        public static void CreateWorkType(
            InvoiceKingdomContext context,
            string name,
            TaxType taxSurchargeType,
            TaxType taxReductionType
        )
        {
            // Trim values.
            name = name.Trim();

            // Validate required values.
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            if (taxSurchargeType == null) throw new ArgumentNullException("taxSurchargeType");
            if (taxReductionType == null) throw new ArgumentNullException("taxReductionType");

            try
            {
                var workType = new WorkType()
                {
                    Name = name,
                    TaxSurchargeType = taxSurchargeType,
                    TaxReductionType = taxReductionType
                };

                context.WorkTypes.Add(workType);
                context.TaxTypes.Attach(taxSurchargeType);
                context.TaxTypes.Attach(taxReductionType);
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
