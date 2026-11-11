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
        private List<WorkType> availableWorkTypes;

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

            using InvoiceKingdomContext context = new();
            availableWorkTypes = context.WorkTypes.Where(w => w.IsHidden == false).ToList();
            foreach (var item in availableWorkTypes)
            {
                checkedListWorkTypes.Items.Add(item.Name);
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var firstName = textFirstName.Text;
                var lastName = textLastName.Text;
                var personalIdentityNumber = textPersonalIdentityNumber.Text;
                var streetAddress = textStreetAddress.Text;
                var postalCode = textPostalCode.Text;
                var city = textCity.Text;
                var emailAddress = textEmailAddress.Text;
                var phoneNumber = textPhoneNumber.Text;

                var selectedWorkTypes = new List<WorkType>();
                foreach (var item in checkedListWorkTypes.CheckedItems)
                {
                    var addWorkType = availableWorkTypes.First(w => w.Name == item.ToString());
                    selectedWorkTypes.Add(addWorkType);
                }

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
                    phoneNumber,
                    selectedWorkTypes
                    );

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
