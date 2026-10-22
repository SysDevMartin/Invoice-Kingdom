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
            labelFormTitle = new Label();
            labelFormDetails = new Label();
            SuspendLayout();
            // 
            // panelContactPerson
            // 
            panelContactPerson.Location = new Point(12, 131);
            panelContactPerson.Name = "panelContactPerson";
            panelContactPerson.Size = new Size(473, 199);
            panelContactPerson.TabIndex = 0;
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
            labelFormDetails.ForeColor = Color.DimGray;
            labelFormDetails.Location = new Point(14, 42);
            labelFormDetails.Name = "labelFormDetails";
            labelFormDetails.Size = new Size(724, 23);
            labelFormDetails.TabIndex = 21;
            labelFormDetails.Text = "Lägg till en ny kund i företaget. Du kan ändra alla uppgifter och arbetstyper senare vid behov.";
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 640);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContactPerson;
        private Label labelFormTitle;
        private Label labelFormDetails;
    }
}