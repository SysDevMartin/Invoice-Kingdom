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
            Theme.SetFormStyle(this);
            Theme.SetPanelStyle([panelProperties]);
            Theme.SetControlStyle([
                textTaxType,
                cbType,
                numericRate,
                buttonAddTaxType
            ]);

            foreach (var type in Enum.GetValues<TaxType.AvailableTaxType>())
            {
                var friendlyTypeText = TaxType.GetTaxTypeName(type);
                cbType.Items.Add(friendlyTypeText);
            }

            if (cbType.Items.Count > 0)
            {
                cbType.SelectedIndex = 0;
            }
        }
    }
}
