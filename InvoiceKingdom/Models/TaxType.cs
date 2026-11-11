using InvoiceKingdom.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class TaxType
    {
        public enum AvailableTaxFunction
        {
            VAT,
            ReductionRUT,
            ReductionROT
        }

        public int Id { get; set; }

        public required AvailableTaxFunction Function { get; set; }

        public required string Name { get; set; }

        public required decimal Rate { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public static string GetTaxTypeName(AvailableTaxFunction availableTaxType)
        {
            return availableTaxType switch
            {
                AvailableTaxFunction.VAT => "Moms",
                AvailableTaxFunction.ReductionRUT => "RUT-avdrag",
                AvailableTaxFunction.ReductionROT => "ROT-avdrag",
                _ => throw new NotImplementedException()
            };
        }

        public static void CreateTaxType(
            InvoiceKingdomContext context,
            string name,
            AvailableTaxFunction function,
            decimal rate
            )
        {
            // Trim values.
            name = name.Trim();

            // Validate required values.
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            if (rate < 0 || rate > 1) throw new ArgumentOutOfRangeException("rate");

            try
            {
                var taxType = new TaxType()
                {
                    Name = name,
                    Function = function,
                    Rate = rate
                };

                context.TaxTypes.Add(taxType);
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
