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
            textWorkSum = new TextBox();
            labelWorkSum = new Label();
            textWorkVat = new TextBox();
            labelWorkVat = new Label();
            buttonAddWork = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // labelInvoiceNumber
            // 
            labelInvoiceNumber.AutoSize = true;
            labelInvoiceNumber.Location = new Point(25, 47);
            labelInvoiceNumber.Name = "labelInvoiceNumber";
            labelInvoiceNumber.Size = new Size(101, 15);
            labelInvoiceNumber.TabIndex = 0;
            labelInvoiceNumber.Text = "Invoice number: ?";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { applicationMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1266, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // applicationMenuItem
            // 
            applicationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitAppMenuItem });
            applicationMenuItem.Name = "applicationMenuItem";
            applicationMenuItem.Size = new Size(80, 20);
            applicationMenuItem.Text = "Application";
            // 
            // exitAppMenuItem
            // 
            exitAppMenuItem.Name = "exitAppMenuItem";
            exitAppMenuItem.Size = new Size(92, 22);
            exitAppMenuItem.Text = "Exit";
            exitAppMenuItem.Click += exitAppMenuItem_Click;
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(25, 113);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(387, 23);
            cbCustomer.TabIndex = 2;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(25, 95);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(59, 15);
            labelCustomer.TabIndex = 3;
            labelCustomer.Text = "Customer";
            // 
            // labelWork
            // 
            labelWork.AutoSize = true;
            labelWork.Location = new Point(25, 174);
            labelWork.Name = "labelWork";
            labelWork.Size = new Size(35, 15);
            labelWork.TabIndex = 4;
            labelWork.Text = "Work";
            // 
            // cbWork
            // 
            cbWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWork.FormattingEnabled = true;
            cbWork.Location = new Point(25, 192);
            cbWork.Name = "cbWork";
            cbWork.Size = new Size(387, 23);
            cbWork.TabIndex = 5;
            // 
            // labelWorkAmount
            // 
            labelWorkAmount.AutoSize = true;
            labelWorkAmount.Location = new Point(459, 174);
            labelWorkAmount.Name = "labelWorkAmount";
            labelWorkAmount.Size = new Size(51, 15);
            labelWorkAmount.TabIndex = 6;
            labelWorkAmount.Text = "Amount";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(459, 192);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(100, 23);
            textAmount.TabIndex = 7;
            // 
            // textWorkSum
            // 
            textWorkSum.Enabled = false;
            textWorkSum.Location = new Point(587, 192);
            textWorkSum.Name = "textWorkSum";
            textWorkSum.Size = new Size(100, 23);
            textWorkSum.TabIndex = 9;
            // 
            // labelWorkSum
            // 
            labelWorkSum.AutoSize = true;
            labelWorkSum.Location = new Point(587, 174);
            labelWorkSum.Name = "labelWorkSum";
            labelWorkSum.Size = new Size(31, 15);
            labelWorkSum.TabIndex = 8;
            labelWorkSum.Text = "Sum";
            // 
            // textWorkVat
            // 
            textWorkVat.Enabled = false;
            textWorkVat.Location = new Point(712, 192);
            textWorkVat.Name = "textWorkVat";
            textWorkVat.Size = new Size(100, 23);
            textWorkVat.TabIndex = 11;
            // 
            // labelWorkVat
            // 
            labelWorkVat.AutoSize = true;
            labelWorkVat.Location = new Point(712, 174);
            labelWorkVat.Name = "labelWorkVat";
            labelWorkVat.Size = new Size(27, 15);
            labelWorkVat.TabIndex = 10;
            labelWorkVat.Text = "VAT";
            // 
            // buttonAddWork
            // 
            buttonAddWork.Location = new Point(835, 191);
            buttonAddWork.Name = "buttonAddWork";
            buttonAddWork.Size = new Size(75, 23);
            buttonAddWork.TabIndex = 12;
            buttonAddWork.Text = "Add work";
            buttonAddWork.UseVisualStyleBackColor = true;
            // 
            // NewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 725);
            Controls.Add(buttonAddWork);
            Controls.Add(textWorkVat);
            Controls.Add(labelWorkVat);
            Controls.Add(textWorkSum);
            Controls.Add(labelWorkSum);
            Controls.Add(textAmount);
            Controls.Add(labelWorkAmount);
            Controls.Add(cbWork);
            Controls.Add(labelWork);
            Controls.Add(labelCustomer);
            Controls.Add(cbCustomer);
            Controls.Add(labelInvoiceNumber);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "NewInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewInvoice";
            Load += NewInvoice_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private TextBox textWorkSum;
        private Label labelWorkSum;
        private Label labelCostSum;
        private Label labelWorkVat;
        private Button buttonAddWork;
        private TextBox textWorkVat;
    }
}