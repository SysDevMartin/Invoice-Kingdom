namespace InvoiceKingdom
{
    partial class NewInvoice
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
            labelInvoiceNumber = new Label();
            menuStrip = new MenuStrip();
            applicationMenuItem = new ToolStripMenuItem();
            exitAppMenuItem = new ToolStripMenuItem();
            cbCustomer = new ComboBox();
            labelCustomer = new Label();
            labelWork = new Label();
            cbWork = new ComboBox();
            labelWorkAmount = new Label();
            textAmount = new TextBox();
            buttonAddWork = new Button();
            labelDueDate = new Label();
            labelReference = new Label();
            textReference = new TextBox();
            labelInvoiceNumberValue = new Label();
            dateTimeDueDate = new DateTimePicker();
            labelStatistics = new Label();
            labelFormTitle = new Label();
            buttonRemoveWork = new Button();
            listWork = new ListBox();
            buttonCreateInvoice = new Button();
            checkBoxAutoPrint = new CheckBox();
            checkBoxAutoOpen = new CheckBox();
            panelInvoiceActions = new Panel();
            buttonResetInvoice = new Button();
            panelCustomer = new Panel();
            labelCustomerDetails = new Label();
            panelDetails = new Panel();
            panelInvoiceInfo = new Panel();
            panelWork = new Panel();
            labelWorkDetails = new Label();
            menuStrip.SuspendLayout();
            panelInvoiceActions.SuspendLayout();
            panelCustomer.SuspendLayout();
            panelDetails.SuspendLayout();
            panelInvoiceInfo.SuspendLayout();
            panelWork.SuspendLayout();
            SuspendLayout();
            // 
            // labelInvoiceNumber
            // 
            labelInvoiceNumber.AutoSize = true;
            labelInvoiceNumber.Location = new Point(15, 15);
            labelInvoiceNumber.Margin = new Padding(4, 0, 4, 0);
            labelInvoiceNumber.Name = "labelInvoiceNumber";
            labelInvoiceNumber.Size = new Size(130, 23);
            labelInvoiceNumber.TabIndex = 0;
            labelInvoiceNumber.Text = "Fakturanummer";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { applicationMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1300, 25);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // applicationMenuItem
            // 
            applicationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitAppMenuItem });
            applicationMenuItem.Name = "applicationMenuItem";
            applicationMenuItem.Size = new Size(80, 19);
            applicationMenuItem.Text = "Applikation";
            // 
            // exitAppMenuItem
            // 
            exitAppMenuItem.Name = "exitAppMenuItem";
            exitAppMenuItem.Size = new Size(113, 22);
            exitAppMenuItem.Text = "Avsluta";
            exitAppMenuItem.Click += exitAppMenuItem_Click;
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(14, 42);
            cbCustomer.Margin = new Padding(4);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(489, 31);
            cbCustomer.TabIndex = 0;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(14, 14);
            labelCustomer.Margin = new Padding(4, 0, 4, 0);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(50, 23);
            labelCustomer.TabIndex = 3;
            labelCustomer.Text = "Kund";
            // 
            // labelWork
            // 
            labelWork.AutoSize = true;
            labelWork.Location = new Point(14, 18);
            labelWork.Margin = new Padding(4, 0, 4, 0);
            labelWork.Name = "labelWork";
            labelWork.Size = new Size(61, 23);
            labelWork.TabIndex = 4;
            labelWork.Text = "Arbete";
            // 
            // cbWork
            // 
            cbWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWork.FormattingEnabled = true;
            cbWork.Location = new Point(14, 44);
            cbWork.Margin = new Padding(4);
            cbWork.Name = "cbWork";
            cbWork.Size = new Size(489, 31);
            cbWork.TabIndex = 0;
            // 
            // labelWorkAmount
            // 
            labelWorkAmount.AutoSize = true;
            labelWorkAmount.Location = new Point(523, 18);
            labelWorkAmount.Margin = new Padding(4, 0, 4, 0);
            labelWorkAmount.Name = "labelWorkAmount";
            labelWorkAmount.Size = new Size(50, 23);
            labelWorkAmount.TabIndex = 6;
            labelWorkAmount.Text = "Antal";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(523, 45);
            textAmount.Margin = new Padding(4);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(79, 30);
            textAmount.TabIndex = 1;
            // 
            // buttonAddWork
            // 
            buttonAddWork.Location = new Point(620, 42);
            buttonAddWork.Margin = new Padding(4);
            buttonAddWork.Name = "buttonAddWork";
            buttonAddWork.Size = new Size(152, 35);
            buttonAddWork.TabIndex = 2;
            buttonAddWork.Text = "Lägg till";
            buttonAddWork.UseVisualStyleBackColor = true;
            // 
            // labelDueDate
            // 
            labelDueDate.AutoSize = true;
            labelDueDate.Location = new Point(15, 94);
            labelDueDate.Margin = new Padding(4, 0, 4, 0);
            labelDueDate.Name = "labelDueDate";
            labelDueDate.Size = new Size(116, 23);
            labelDueDate.TabIndex = 13;
            labelDueDate.Text = "Förfallodatum";
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Location = new Point(15, 183);
            labelReference.Margin = new Padding(4, 0, 4, 0);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(75, 23);
            labelReference.TabIndex = 15;
            labelReference.Text = "Referens";
            // 
            // textReference
            // 
            textReference.Location = new Point(15, 211);
            textReference.Margin = new Padding(4);
            textReference.Name = "textReference";
            textReference.Size = new Size(387, 30);
            textReference.TabIndex = 1;
            // 
            // labelInvoiceNumberValue
            // 
            labelInvoiceNumberValue.AutoSize = true;
            labelInvoiceNumberValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInvoiceNumberValue.Location = new Point(15, 42);
            labelInvoiceNumberValue.Margin = new Padding(4, 0, 4, 0);
            labelInvoiceNumberValue.Name = "labelInvoiceNumberValue";
            labelInvoiceNumberValue.Size = new Size(16, 21);
            labelInvoiceNumberValue.TabIndex = 16;
            labelInvoiceNumberValue.Text = "-";
            // 
            // dateTimeDueDate
            // 
            dateTimeDueDate.Location = new Point(17, 123);
            dateTimeDueDate.Margin = new Padding(4);
            dateTimeDueDate.Name = "dateTimeDueDate";
            dateTimeDueDate.Size = new Size(385, 30);
            dateTimeDueDate.TabIndex = 0;
            // 
            // labelStatistics
            // 
            labelStatistics.Location = new Point(16, 15);
            labelStatistics.Margin = new Padding(4, 0, 4, 0);
            labelStatistics.Name = "labelStatistics";
            labelStatistics.Size = new Size(403, 179);
            labelStatistics.TabIndex = 0;
            // 
            // labelFormTitle
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFormTitle.Location = new Point(11, 42);
            labelFormTitle.Margin = new Padding(4, 0, 4, 0);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Size = new Size(125, 32);
            labelFormTitle.TabIndex = 19;
            labelFormTitle.Text = "Ny faktura";
            // 
            // buttonRemoveWork
            // 
            buttonRemoveWork.Location = new Point(14, 242);
            buttonRemoveWork.Margin = new Padding(4);
            buttonRemoveWork.Name = "buttonRemoveWork";
            buttonRemoveWork.Size = new Size(96, 33);
            buttonRemoveWork.TabIndex = 4;
            buttonRemoveWork.Text = "Ta bort";
            buttonRemoveWork.UseVisualStyleBackColor = true;
            // 
            // listWork
            // 
            listWork.FormattingEnabled = true;
            listWork.Location = new Point(14, 115);
            listWork.Margin = new Padding(4);
            listWork.Name = "listWork";
            listWork.Size = new Size(758, 119);
            listWork.TabIndex = 3;
            // 
            // buttonCreateInvoice
            // 
            buttonCreateInvoice.Location = new Point(0, 0);
            buttonCreateInvoice.Margin = new Padding(4);
            buttonCreateInvoice.Name = "buttonCreateInvoice";
            buttonCreateInvoice.Size = new Size(225, 46);
            buttonCreateInvoice.TabIndex = 0;
            buttonCreateInvoice.Text = "Skapa fakturan";
            buttonCreateInvoice.UseVisualStyleBackColor = false;
            // 
            // checkBoxAutoPrint
            // 
            checkBoxAutoPrint.AutoSize = true;
            checkBoxAutoPrint.Location = new Point(250, 11);
            checkBoxAutoPrint.Margin = new Padding(4);
            checkBoxAutoPrint.Name = "checkBoxAutoPrint";
            checkBoxAutoPrint.Size = new Size(153, 27);
            checkBoxAutoPrint.TabIndex = 1;
            checkBoxAutoPrint.Text = "Skriv ut fakturan";
            checkBoxAutoPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoOpen
            // 
            checkBoxAutoOpen.AutoSize = true;
            checkBoxAutoOpen.Location = new Point(426, 11);
            checkBoxAutoOpen.Margin = new Padding(4);
            checkBoxAutoOpen.Name = "checkBoxAutoOpen";
            checkBoxAutoOpen.Size = new Size(128, 27);
            checkBoxAutoOpen.TabIndex = 2;
            checkBoxAutoOpen.Text = "Visa fakturan";
            checkBoxAutoOpen.UseVisualStyleBackColor = true;
            // 
            // panelInvoiceActions
            // 
            panelInvoiceActions.Controls.Add(buttonResetInvoice);
            panelInvoiceActions.Controls.Add(buttonCreateInvoice);
            panelInvoiceActions.Controls.Add(checkBoxAutoPrint);
            panelInvoiceActions.Controls.Add(checkBoxAutoOpen);
            panelInvoiceActions.Location = new Point(15, 635);
            panelInvoiceActions.Margin = new Padding(4);
            panelInvoiceActions.Name = "panelInvoiceActions";
            panelInvoiceActions.Size = new Size(1261, 49);
            panelInvoiceActions.TabIndex = 4;
            // 
            // buttonResetInvoice
            // 
            buttonResetInvoice.Location = new Point(1075, 6);
            buttonResetInvoice.Margin = new Padding(4);
            buttonResetInvoice.Name = "buttonResetInvoice";
            buttonResetInvoice.Size = new Size(186, 34);
            buttonResetInvoice.TabIndex = 3;
            buttonResetInvoice.Text = "Nollställ fakturan";
            buttonResetInvoice.UseVisualStyleBackColor = true;
            // 
            // panelCustomer
            // 
            panelCustomer.Controls.Add(labelCustomerDetails);
            panelCustomer.Controls.Add(labelCustomer);
            panelCustomer.Controls.Add(cbCustomer);
            panelCustomer.Location = new Point(15, 96);
            panelCustomer.Margin = new Padding(4);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(794, 101);
            panelCustomer.TabIndex = 0;
            // 
            // labelCustomerDetails
            // 
            labelCustomerDetails.Location = new Point(523, 24);
            labelCustomerDetails.Name = "labelCustomerDetails";
            labelCustomerDetails.Size = new Size(249, 49);
            labelCustomerDetails.TabIndex = 4;
            // 
            // panelDetails
            // 
            panelDetails.Controls.Add(labelStatistics);
            panelDetails.Location = new Point(843, 396);
            panelDetails.Margin = new Padding(2, 3, 2, 3);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(433, 211);
            panelDetails.TabIndex = 3;
            // 
            // panelInvoiceInfo
            // 
            panelInvoiceInfo.Controls.Add(labelInvoiceNumberValue);
            panelInvoiceInfo.Controls.Add(labelInvoiceNumber);
            panelInvoiceInfo.Controls.Add(dateTimeDueDate);
            panelInvoiceInfo.Controls.Add(labelDueDate);
            panelInvoiceInfo.Controls.Add(labelReference);
            panelInvoiceInfo.Controls.Add(textReference);
            panelInvoiceInfo.Location = new Point(843, 96);
            panelInvoiceInfo.Name = "panelInvoiceInfo";
            panelInvoiceInfo.Size = new Size(433, 263);
            panelInvoiceInfo.TabIndex = 2;
            // 
            // panelWork
            // 
            panelWork.Controls.Add(labelWorkDetails);
            panelWork.Controls.Add(buttonRemoveWork);
            panelWork.Controls.Add(labelWork);
            panelWork.Controls.Add(cbWork);
            panelWork.Controls.Add(buttonAddWork);
            panelWork.Controls.Add(listWork);
            panelWork.Controls.Add(textAmount);
            panelWork.Controls.Add(labelWorkAmount);
            panelWork.Location = new Point(15, 238);
            panelWork.Name = "panelWork";
            panelWork.Size = new Size(794, 369);
            panelWork.TabIndex = 1;
            // 
            // labelWorkDetails
            // 
            labelWorkDetails.Location = new Point(14, 303);
            labelWorkDetails.Name = "labelWorkDetails";
            labelWorkDetails.Size = new Size(758, 49);
            labelWorkDetails.TabIndex = 7;
            labelWorkDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NewInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1300, 707);
            Controls.Add(panelWork);
            Controls.Add(panelInvoiceInfo);
            Controls.Add(panelDetails);
            Controls.Add(panelCustomer);
            Controls.Add(labelFormTitle);
            Controls.Add(panelInvoiceActions);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "NewInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Kingdom";
            Load += NewInvoice_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelInvoiceActions.ResumeLayout(false);
            panelInvoiceActions.PerformLayout();
            panelCustomer.ResumeLayout(false);
            panelCustomer.PerformLayout();
            panelDetails.ResumeLayout(false);
            panelInvoiceInfo.ResumeLayout(false);
            panelInvoiceInfo.PerformLayout();
            panelWork.ResumeLayout(false);
            panelWork.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInvoiceNumber;
        private MenuStrip menuStrip;
        private ToolStripMenuItem applicationMenuItem;
        private ToolStripMenuItem exitAppMenuItem;
        private ComboBox cbCustomer;
        private Label labelCustomer;
        private Label labelWork;
        private ComboBox cbWork;
        private Label labelWorkAmount;
        private TextBox textAmount;
        private Label labelCostSum;
        private Button buttonAddWork;
        private Label labelDueDate;
        private Label labelReference;
        private TextBox textReference;
        private Label labelFormTitle;
        private GroupBox groupWork;
        private Button buttonCreateInvoice;
        private Label labelStatistics;
        private DateTimePicker dateTimeDueDate;
        private Button buttonRemoveWork;
        private ListBox listWork;
        private CheckBox checkBoxAutoPrint;
        private CheckBox checkBoxAutoOpen;
        private Label labelInvoiceNumberValue;
        private Panel panelInvoiceActions;
        private Panel panelCustomer;
        private Panel panelDetails;
        private Panel panelInvoiceInfo;
        private Panel panelWork;
        private Label labelWorkDetails;
        private Label labelCustomerDetails;
        private Button buttonResetInvoice;
    }
}