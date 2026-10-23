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
                textVatRate,
                textTaxReductionRate,
                buttonAddWorkType
                ]);
        }

        private void buttonAddWorkType_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textName.Text.Trim();
                var vatRate = decimal.Parse(textVatRate.Text.Trim()) / 100M;
                var taxReductionRate = decimal.Parse(textTaxReductionRate.Text.Trim()) / 100M;
                using InvoiceKingdomContext context = new();
                WorkType.CreateWorkType(context, name, vatRate, taxReductionRate);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
