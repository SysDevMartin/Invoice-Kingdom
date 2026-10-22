using InvoiceKingdom.Data;
using InvoiceKingdom.Models;
using Microsoft.EntityFrameworkCore;
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
        private List<Customer> customers = [];

        private void LoadCustomers()
        {
            using InvoiceKingdomContext dbContext = new();
            customers = Customer.GetAllCustomers(dbContext).ToList();
            foreach (var customer in customers)
            {
                var customerText = $"{customer.GetFullName()} ({customer.StreetAddress})";
                cbCustomer.Items.Add(customerText);
            }
        }

        private void LoadCustomerDetails(Customer customer)
        {
            using InvoiceKingdomContext dbContext = new();
            var latestInvoice = customer.GetLatestInvoice(dbContext);

            if (latestInvoice != null)
            {
                labelCustomerDetails.Text = $"Förra fakturan för kunden är {latestInvoice.InvoiceNumber}.";
            }
            else
            {
                labelCustomerDetails.Text = "Kunden har ingen tidigare faktura.";
            }
        }

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
            labelCustomerDetails.ForeColor = Theme.LabelDetailsForeColor;

            LoadCustomers();
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

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.Items.Count > 0)
            {
                LoadCustomerDetails(customers[cbCustomer.SelectedIndex]);
                cbCustomer.Enabled = false;
                cbWork.Focus();
            }
        }
    }
}
