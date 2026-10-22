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
    public partial class NewInvoiceForm : Form
    {
        public NewInvoiceForm()
        {
            InitializeComponent();
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            Theme.SetFormStyle(this);
            Theme.SetPanelStyle([
                panelCustomer,
                panelWork,
                panelInvoiceInfo,
                panelDetails
            ]);
            Theme.SetControlStyle([
                listWork,
                textAmount,
                textReference,
                buttonAddWork,
                buttonRemoveWork,
                buttonCreateInvoice,
                buttonResetInvoice,
                checkBoxAutoPrint,
                checkBoxAutoOpen
            ]);

            using InvoiceKingdomContext context = new();
            var customers = Customer.GetAllCustomers(context);
            foreach (var customer in customers)
            {
                cbCustomer.Items.Add(customer.GetFullName());
            }
        }

        private void exitAppMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newCustomerMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewCustomerForm();
            form.ShowDialog();
        }

        private void buttonCreateInvoice_Click(object sender, EventArgs e)
        {
            //var invoiceNumber = ;
            //var customer = ;
            //var dueDate = ;
            //var reference = ;
            //var invoiceWork = ;

            using InvoiceKingdomContext context = new();
            /*Invoice.CreateInvoice(
                context,
                invoiceNumber,
                customer,
                dueDate,
                reference,
                invoiceWork
                );*/
        }
    }
}
