using InvoiceKingdom.Data;
using InvoiceKingdom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InvoiceKingdom.Forms
{
    public partial class NewWorkTypeForm : Form
    {
        private Dictionary<string, decimal> availableVatRates = new()
        {
            { "Standard (25%)", 0.25M },
        };
        private Dictionary<string, decimal> availableTaxReductionRates = new()
        {
            { "Ingen (0%)", 0 },
            { "RUT-avdrag (25%)", 0.25M }
        };

        public NewWorkTypeForm()
        {
            InitializeComponent();
        }

        private void NewWorkTypeForm_Load(object sender, EventArgs e)
        {
            Theme.SetFormStyle(this, labelFormDetails);
            Theme.SetPanelStyle([panelProperties]);
            Theme.SetControlStyle([
                textName,
                cbVatRate,
                cbTaxReductionRate,
                buttonAddWorkType
                ]);

            foreach (var item in availableVatRates)
            {
                cbVatRate.Items.Add(item.Key);
            }
            cbVatRate.SelectedIndex = 0;

            foreach (var item in availableTaxReductionRates)
            {
                cbTaxReductionRate.Items.Add(item.Key);
            }
            cbTaxReductionRate.SelectedIndex = 0;
        }

        private void buttonAddWorkType_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textName.Text.Trim();
                var vatRateKey = cbVatRate.SelectedItem.ToString();
                var vatRateValue = availableVatRates[vatRateKey];
                var taxReductionRateKey = cbTaxReductionRate.SelectedItem.ToString();
                var taxReductionRateValue = availableTaxReductionRates[taxReductionRateKey];
                using InvoiceKingdomContext context = new();
                WorkType.CreateWorkType(context, name, vatRateValue, taxReductionRateValue);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
