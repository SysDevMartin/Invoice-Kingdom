using InvoiceKingdom.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class TaxType
    {
        public enum TaxFunction
        {
            None,
            Surcharge,
            Reduction
        }

        #region Database fields

        public int Id { get; set; }

        public required string Name { get; set; }

        public required TaxFunction Function { get; set; }

        public required decimal Rate { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        #endregion

        public static string GetTaxFunctionName(TaxFunction availableTaxFunctions)
        {
            return availableTaxFunctions switch
            {
                TaxFunction.None => "Ingen skatt",
                TaxFunction.Surcharge => "Moms",
                TaxFunction.Reduction => "RUT-avdrag",
                _ => throw new NotImplementedException()
            };
        }

        public static void CreateTaxType(
            InvoiceKingdomContext context,
            string name,
            TaxFunction function,
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
