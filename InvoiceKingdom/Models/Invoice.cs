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
        AwaitingTaxReductionClaim,
        Canceled
    }

    internal class Invoice
    {
        public int Id { get; set; }

        public int InvoiceNumber { get; set; }

        public required Customer Customer { get; set; }

        public DateTime DueDate { get; set; }

        public string? Reference { get; set; }

        public State State { get; set; } = State.Unpaid;

        public required ICollection<InvoiceWork> InvoiceWork { get; set; }

        public DateTime Created { get; set; }

        public static void CreateInvoice(
            InvoiceKingdomContext context,
            int invoiceNumber,
            Customer customer,
            DateTime dueDate,
            string reference,
            List<InvoiceWork> invoiceWork)
        {
            var invoice = new Invoice()
            {
                InvoiceNumber = invoiceNumber,
                Customer = customer,
                DueDate = dueDate.Date,
                Reference = reference,
                State = State.Unpaid,
                InvoiceWork = invoiceWork,
                Created = DateTime.Now
            };
            context.Add(invoice);
            context.SaveChanges();
        }

        public static IOrderedQueryable<Models.Invoice> GetAllInvoices(InvoiceKingdomContext context)
        {
            return context.Invoices.OrderBy(i => i.InvoiceNumber);
        }

        public static Invoice GetInvoiceById(InvoiceKingdomContext context, int id)
        {
            return context.Invoices.First(i => i.Id == id);
        }
    }
}
