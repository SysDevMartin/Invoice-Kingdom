using InvoiceKingdom.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom.Models
{
    enum State
    {
        Unpaid,
        Paid,
        Canceled
    }

    internal class Invoice
    {
        public int Id { get; set; }

        public int InvoiceNumber { get; set; }

        public DateTime DueDate { get; set; }

        public string? Reference { get; set; }

        public State State { get; set; } = State.Unpaid;

        public required ICollection<InvoiceWork> InvoiceWork { get; set; }

        public static void SaveInvoice(
            InvoiceKingdomContext context,
            int invoiceNumber,
            DateTime dueDate,
            string reference,
            List<InvoiceWork> invoiceWork)
        {
            Models.Invoice invoice = new()
            {
                InvoiceNumber = invoiceNumber,
                DueDate = dueDate.Date,
                Reference = reference,
                InvoiceWork = invoiceWork
            };
            context.Add(invoice);

            context.SaveChanges();
        }

        public static IOrderedQueryable<Models.Invoice> GetAllInvoices(InvoiceKingdomContext context)
        {
            return context.Invoices.OrderBy(i => i.InvoiceNumber);
        }
    }
}
