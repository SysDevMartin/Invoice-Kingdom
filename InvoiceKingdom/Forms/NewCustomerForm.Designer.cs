namespace InvoiceKingdom
{
    partial class NewCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContactPerson = new Panel();
            textPersonalIdentityNumber = new TextBox();
            labelPersonalIdentityNumber = new Label();
            textLastName = new TextBox();
            labelLastName = new Label();
            labelFirstName = new Label();
            textFirstName = new TextBox();
            labelFormTitle = new Label();
            labelFormDetails = new Label();
            panelAddress = new Panel();
            labelCity = new Label();
            textCity = new TextBox();
            labelPostalCode = new Label();
            textPostalCode = new TextBox();
            labelStreetAddress = new Label();
            textStreetAddress = new TextBox();
            panelContactInfo = new Panel();
            textPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            textEmailAddress = new TextBox();
            labelEmailAddress = new Label();
            panelWorkTypes = new Panel();
            labelWorkTypesDetails = new Label();
            checkedListWorkTypes = new CheckedListBox();
            labelWorkTypes = new Label();
            buttonAddCustomer = new Button();
            panelContactPerson.SuspendLayout();
            panelAddress.SuspendLayout();
            panelContactInfo.SuspendLayout();
            panelWorkTypes.SuspendLayout();
            SuspendLayout();
            // 
            // panelContactPerson
            // 
            panelContactPerson.Controls.Add(textPersonalIdentityNumber);
            panelContactPerson.Controls.Add(labelPersonalIdentityNumber);
            panelContactPerson.Controls.Add(textLastName);
            panelContactPerson.Controls.Add(labelLastName);
            panelContactPerson.Controls.Add(labelFirstName);
            panelContactPerson.Controls.Add(textFirstName);
            panelContactPerson.Location = new Point(14, 131);
            panelContactPerson.Name = "panelContactPerson";
            panelContactPerson.Size = new Size(456, 174);
            panelContactPerson.TabIndex = 0;
            // 
            // textPersonalIdentityNumber
            // 
            textPersonalIdentityNumber.Location = new Point(18, 119);
            textPersonalIdentityNumber.Name = "textPersonalIdentityNumber";
            textPersonalIdentityNumber.Size = new Size(419, 30);
            textPersonalIdentityNumber.TabIndex = 2;
            // 
            // labelPersonalIdentityNumber
            // 
            labelPersonalIdentityNumber.AutoSize = true;
            labelPersonalIdentityNumber.Location = new Point(18, 93);
            labelPersonalIdentityNumber.Name = "labelPersonalIdentityNumber";
            labelPersonalIdentityNumber.Size = new Size(126, 23);
            labelPersonalIdentityNumber.TabIndex = 4;
            labelPersonalIdentityNumber.Text = "Personnummer";
            // 
            // textLastName
            // 
            textLastName.Location = new Point(243, 41);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(194, 30);
            textLastName.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(243, 15);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(101, 23);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Efternamn *";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(18, 15);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(90, 23);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "Förnamn *";
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(18, 41);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(194, 30);
            textFirstName.TabIndex = 0;
            // 
            // labelFormTitle
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFormTitle.Location = new Point(11, 10);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Size = new Size(105, 32);
            labelFormTitle.TabIndex = 20;
            labelFormTitle.Text = "Ny kund";
            // 
            // labelFormDetails
            // 
            labelFormDetails.AutoSize = true;
            labelFormDetails.Location = new Point(14, 46);
            labelFormDetails.Name = "labelFormDetails";
            labelFormDetails.Size = new Size(724, 46);
            labelFormDetails.TabIndex = 21;
            labelFormDetails.Text = "Lägg till en ny kund i företaget. Du kan ändra alla uppgifter och arbetstyper senare vid behov.\r\nEn asterisk (*) vid ett fält betyder att det måste fyllas i.";
            // 
            // panelAddress
            // 
            panelAddress.Controls.Add(labelCity);
            panelAddress.Controls.Add(textCity);
            panelAddress.Controls.Add(labelPostalCode);
            panelAddress.Controls.Add(textPostalCode);
            panelAddress.Controls.Add(labelStreetAddress);
            panelAddress.Controls.Add(textStreetAddress);
            panelAddress.Location = new Point(510, 131);
            panelAddress.Name = "panelAddress";
            panelAddress.Size = new Size(454, 174);
            panelAddress.TabIndex = 1;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(242, 93);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(84, 23);
            labelCity.TabIndex = 7;
            labelCity.Text = "Stad/ort *";
            // 
            // textCity
            // 
            textCity.Location = new Point(242, 119);
            textCity.Name = "textCity";
            textCity.Size = new Size(194, 30);
            textCity.TabIndex = 2;
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(17, 93);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(119, 23);
            labelPostalCode.TabIndex = 5;
            labelPostalCode.Text = "Postnummer *";
            // 
            // textPostalCode
            // 
            textPostalCode.Location = new Point(17, 119);
            textPostalCode.Name = "textPostalCode";
            textPostalCode.Size = new Size(194, 30);
            textPostalCode.TabIndex = 1;
            // 
            // labelStreetAddress
            // 
            labelStreetAddress.AutoSize = true;
            labelStreetAddress.Location = new Point(17, 15);
            labelStreetAddress.Name = "labelStreetAddress";
            labelStreetAddress.Size = new Size(107, 23);
            labelStreetAddress.TabIndex = 3;
            labelStreetAddress.Text = "Gatuadress *";
            // 
            // textStreetAddress
            // 
            textStreetAddress.Location = new Point(17, 41);
            textStreetAddress.Name = "textStreetAddress";
            textStreetAddress.Size = new Size(419, 30);
            textStreetAddress.TabIndex = 0;
            // 
            // panelContactInfo
            // 
            panelContactInfo.Controls.Add(textPhoneNumber);
            panelContactInfo.Controls.Add(labelPhoneNumber);
            panelContactInfo.Controls.Add(textEmailAddress);
            panelContactInfo.Controls.Add(labelEmailAddress);
            panelContactInfo.Location = new Point(14, 340);
            panelContactInfo.Name = "panelContactInfo";
            panelContactInfo.Size = new Size(456, 189);
            panelContactInfo.TabIndex = 2;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(18, 129);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(419, 30);
            textPhoneNumber.TabIndex = 1;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(18, 103);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(129, 23);
            labelPhoneNumber.TabIndex = 2;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // textEmailAddress
            // 
            textEmailAddress.Location = new Point(18, 44);
            textEmailAddress.Name = "textEmailAddress";
            textEmailAddress.Size = new Size(419, 30);
            textEmailAddress.TabIndex = 0;
            // 
            // labelEmailAddress
            // 
            labelEmailAddress.AutoSize = true;
            labelEmailAddress.Location = new Point(18, 18);
            labelEmailAddress.Name = "labelEmailAddress";
            labelEmailAddress.Size = new Size(100, 23);
            labelEmailAddress.TabIndex = 0;
            labelEmailAddress.Text = "Epostadress";
            // 
            // panelWorkTypes
            // 
            panelWorkTypes.Controls.Add(labelWorkTypesDetails);
            panelWorkTypes.Controls.Add(checkedListWorkTypes);
            panelWorkTypes.Controls.Add(labelWorkTypes);
            panelWorkTypes.Location = new Point(510, 340);
            panelWorkTypes.Name = "panelWorkTypes";
            panelWorkTypes.Size = new Size(454, 189);
            panelWorkTypes.TabIndex = 3;
            // 
            // labelWorkTypesDetails
            // 
            labelWorkTypesDetails.AutoSize = true;
            labelWorkTypesDetails.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWorkTypesDetails.Location = new Point(17, 44);
            labelWorkTypesDetails.Name = "labelWorkTypesDetails";
            labelWorkTypesDetails.Size = new Size(405, 20);
            labelWorkTypesDetails.TabIndex = 3;
            labelWorkTypesDetails.Text = "Kryssa i de arbetstyper som ska vara tillgängliga för kunden.";
            // 
            // checkedListWorkTypes
            // 
            checkedListWorkTypes.FormattingEnabled = true;
            checkedListWorkTypes.Location = new Point(17, 70);
            checkedListWorkTypes.Name = "checkedListWorkTypes";
            checkedListWorkTypes.Size = new Size(419, 104);
            checkedListWorkTypes.TabIndex = 0;
            // 
            // labelWorkTypes
            // 
            labelWorkTypes.AutoSize = true;
            labelWorkTypes.Location = new Point(17, 18);
            labelWorkTypes.Name = "labelWorkTypes";
            labelWorkTypes.Size = new Size(98, 23);
            labelWorkTypes.TabIndex = 1;
            labelWorkTypes.Text = "Arbetstyper";
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(11, 562);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(212, 41);
            buttonAddCustomer.TabIndex = 4;
            buttonAddCustomer.Text = "Lägg till kunden";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 621);
            Controls.Add(buttonAddCustomer);
            Controls.Add(panelWorkTypes);
            Controls.Add(panelContactInfo);
            Controls.Add(panelAddress);
            Controls.Add(labelFormDetails);
            Controls.Add(labelFormTitle);
            Controls.Add(panelContactPerson);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ny kund";
            Load += NewCustomerForm_Load;
            panelContactPerson.ResumeLayout(false);
            panelContactPerson.PerformLayout();
            panelAddress.ResumeLayout(false);
            panelAddress.PerformLayout();
            panelContactInfo.ResumeLayout(false);
            panelContactInfo.PerformLayout();
            panelWorkTypes.ResumeLayout(false);
            panelWorkTypes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContactPerson;
        private Label labelFormTitle;
        private Label labelFormDetails;
        private TextBox textPersonalIdentityNumber;
        private Label labelPersonalIdentityNumber;
        private TextBox textLastName;
        private Label labelLastName;
        private Label labelFirstName;
        private TextBox textFirstName;
        private Panel panelAddress;
        private Label labelCity;
        private TextBox textCity;
        private Label labelPostalCode;
        private TextBox textPostalCode;
        private Label labelStreetAddress;
        private TextBox textStreetAddress;
        private Panel panelContactInfo;
        private TextBox textEmailAddress;
        private Label labelEmailAddress;
        private TextBox textPhoneNumber;
        private Label labelPhoneNumber;
        private Panel panelWorkTypes;
        private Label labelWorkTypes;
        private CheckedListBox checkedListWorkTypes;
        private Label labelWorkTypesDetails;
        private ListBox listBox1;
        private Button buttonAddCustomer;
    }
}