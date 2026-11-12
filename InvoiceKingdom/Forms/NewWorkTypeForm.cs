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
        /*private Dictionary<string, decimal> availableVatRates = new()
        {
            { "Standard (25%)", 0.25M },
        };

        private Dictionary<string, decimal> availableTaxReductionRates = new()
        {
            { "Ingen (0%)", 0 },
            { "RUT-avdrag (25%)", 0.25M }
        };*/

        private List<TaxType> availableSurchargeTaxTypes = [];
        private List<TaxType> availableReductionTaxTypes = [];

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
                cbSurchargeRate,
                cbReductionRate,
                buttonAddWorkType
            ]);

            using InvoiceKingdomContext context = new();

            TaxType.TaxFunction[] eligibleTaxSurchargeTypes = [TaxType.TaxFunction.None, TaxType.TaxFunction.Surcharge];
            TaxType.TaxFunction[] eligibleTaxReductionTypes = [TaxType.TaxFunction.None, TaxType.TaxFunction.Reduction];

            availableSurchargeTaxTypes = context.TaxTypes
                .Where(t => eligibleTaxSurchargeTypes.Contains(t.Function))
                .ToList();

            foreach (var item in availableSurchargeTaxTypes)
            {
                var rate = Math.Round(item.Rate * 100);
                var itemText = $"{item.Name} ({rate}%)";
                cbSurchargeRate.Items.Add(itemText);
            }

            if (cbSurchargeRate.Items.Count > 0)
            {
                cbSurchargeRate.SelectedIndex = 0;
            }

            availableReductionTaxTypes = context.TaxTypes
                .Where(t => eligibleTaxReductionTypes.Contains(t.Function))
                .ToList();

            foreach (var item in availableReductionTaxTypes)
            {
                var rate = Math.Round(item.Rate * 100);
                var itemText = $"{item.Name} ({rate}%)";
                cbReductionRate.Items.Add(itemText);
            }

            if (cbReductionRate.Items.Count > 0)
            {
                cbReductionRate.SelectedIndex = 0;
            }
        }

        private void buttonAddWorkType_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textName.Text.Trim();
                var taxSurchargeTypeIndex = cbSurchargeRate.SelectedIndex;
                var taxSurchargeType = availableSurchargeTaxTypes[taxSurchargeTypeIndex];
                var taxReductionTypeIndex = cbReductionRate.SelectedIndex;
                var taxReductionType = availableReductionTaxTypes[taxReductionTypeIndex];

                using InvoiceKingdomContext context = new();
                WorkType.CreateWorkType(context, name, taxSurchargeType, taxReductionType);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                var message = $"{ex.Message}{Environment.NewLine}{Environment.NewLine}{ex.InnerException}".Trim();
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
