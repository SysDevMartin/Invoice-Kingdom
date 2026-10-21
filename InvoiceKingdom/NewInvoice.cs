using InvoiceKingdom.Data;
using InvoiceKingdom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InvoiceKingdom
{
    public partial class NewInvoice : Form
    {
        public NewInvoice()
        {
            InitializeComponent();
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            using InvoiceKingdomContext context = new();
            var invoices = Invoice.GetAllInvoices(context);
            foreach (var invoice in invoices)
            {
                textWorkSum.Text = invoice.DueDate.ToString();
            }
        }

        private void exitAppMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
