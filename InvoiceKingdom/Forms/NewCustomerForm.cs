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

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var firstName = textFirstName.Text;
            var lastName = textLastName.Text;
            var personalIdentityNumber = textPersonalIdentityNumber.Text;
            var streetAddress = textStreetAddress.Text;
            var postalCode = textPostalCode.Text;
            var city = textCity.Text;
            var emailAddress = textEmailAddress.Text;
            var phoneNumber = textPhoneNumber.Text;

            using InvoiceKingdomContext context = new();
            Customer.CreateCustomer(
                context,
                firstName,
                lastName,
                personalIdentityNumber,
                streetAddress,
                postalCode,
                city,
                emailAddress,
                phoneNumber
                );

            DialogResult = DialogResult.OK;
        }
    }
}
