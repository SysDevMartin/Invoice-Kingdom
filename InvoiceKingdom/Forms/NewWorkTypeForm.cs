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
    }
}
