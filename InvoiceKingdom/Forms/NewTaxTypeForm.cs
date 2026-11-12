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
    public partial class NewTaxTypeForm : Form
    {
        public NewTaxTypeForm()
        {
            InitializeComponent();
        }

        private void NewTaxTypeForm_Load(object sender, EventArgs e)
        {
            Theme.SetFormStyle(this, labelFormDetails);
            Theme.SetPanelStyle([panelProperties]);
            Theme.SetControlStyle([
                textName,
                cbFunction,
                numericRate,
                buttonAddTaxType
            ]);

            foreach (var function in Enum.GetValues<TaxType.TaxFunction>())
            {
                var friendlyText = TaxType.GetTaxFunctionName(function);
                cbFunction.Items.Add(friendlyText);
            }

            if (cbFunction.Items.Count > 0)
            {
                cbFunction.SelectedIndex = 0;
            }
        }

        private void buttonAddTaxType_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textName.Text;
                var function = Enum.GetValues<TaxType.TaxFunction>()[cbFunction.SelectedIndex];
                var isRateConversionSuccessful = Decimal.TryParse(numericRate.Text, out var rate);
                if (!isRateConversionSuccessful)
                {
                    throw new InvalidCastException();
                }

                using InvoiceKingdomContext context = new();
                TaxType.CreateTaxType(context, name, function, rate / 100);
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
