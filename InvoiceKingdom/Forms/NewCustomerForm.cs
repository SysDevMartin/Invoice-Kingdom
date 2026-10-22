using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InvoiceKingdom
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            Theme.SetFormStyle(this, labelFormDetails);
            Theme.SetPanelStyle([
                panelContactPerson,
                panelAddress,
                panelContactInfo,
                panelWorkTypes
                ]);
            Theme.SetControlStyle([
                textFirstName,
                textLastName,
                textPersonalIdentityNumber,
                textStreetAddress,
                textPostalCode,
                textCity,
                textEmailAddress,
                textPhoneNumber,
                checkedListWorkTypes,
                buttonAddCustomer
                ]);
            labelWorkTypesDetails.ForeColor = Theme.LabelDetailsForeColor;
        }
    }
}
