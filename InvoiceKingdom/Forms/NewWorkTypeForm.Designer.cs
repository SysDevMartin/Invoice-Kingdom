namespace InvoiceKingdom.Forms
{
    partial class NewWorkTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWorkTypeForm));
            panelProperties = new Panel();
            cbVatRate = new ComboBox();
            cbTaxReductionRate = new ComboBox();
            labelTaxReductionRate = new Label();
            labelVatRate = new Label();
            textName = new TextBox();
            labelName = new Label();
            labelFormDetails = new Label();
            labelFormTitle = new Label();
            buttonAddWorkType = new Button();
            panelFormHeader = new Panel();
            panelProperties.SuspendLayout();
            panelFormHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelProperties
            // 
            panelProperties.Controls.Add(cbVatRate);
            panelProperties.Controls.Add(cbTaxReductionRate);
            panelProperties.Controls.Add(labelTaxReductionRate);
            panelProperties.Controls.Add(labelVatRate);
            panelProperties.Controls.Add(textName);
            panelProperties.Controls.Add(labelName);
            panelProperties.Location = new Point(14, 166);
            panelProperties.Margin = new Padding(4, 5, 4, 5);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(633, 184);
            panelProperties.TabIndex = 0;
            // 
            // cbVatRate
            // 
            cbVatRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVatRate.FormattingEnabled = true;
            cbVatRate.Location = new Point(18, 133);
            cbVatRate.Name = "cbVatRate";
            cbVatRate.Size = new Size(230, 31);
            cbVatRate.TabIndex = 8;
            // 
            // cbTaxReductionRate
            // 
            cbTaxReductionRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTaxReductionRate.FormattingEnabled = true;
            cbTaxReductionRate.Location = new Point(285, 133);
            cbTaxReductionRate.Name = "cbTaxReductionRate";
            cbTaxReductionRate.Size = new Size(230, 31);
            cbTaxReductionRate.TabIndex = 7;
            // 
            // labelTaxReductionRate
            // 
            labelTaxReductionRate.AutoSize = true;
            labelTaxReductionRate.Location = new Point(285, 107);
            labelTaxReductionRate.Name = "labelTaxReductionRate";
            labelTaxReductionRate.Size = new Size(130, 23);
            labelTaxReductionRate.TabIndex = 4;
            labelTaxReductionRate.Text = "Skattereduktion";
            // 
            // labelVatRate
            // 
            labelVatRate.AutoSize = true;
            labelVatRate.Location = new Point(18, 107);
            labelVatRate.Name = "labelVatRate";
            labelVatRate.Size = new Size(57, 23);
            labelVatRate.TabIndex = 2;
            labelVatRate.Text = "Moms";
            // 
            // textName
            // 
            textName.Location = new Point(18, 42);
            textName.Name = "textName";
            textName.Size = new Size(592, 30);
            textName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(18, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(188, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Namn på arbetstypen *";
            // 
            // labelFormDetails
            // 
            labelFormDetails.AutoSize = true;
            labelFormDetails.Location = new Point(13, 45);
            labelFormDetails.Margin = new Padding(4, 0, 4, 0);
            labelFormDetails.Name = "labelFormDetails";
            labelFormDetails.Size = new Size(624, 92);
            labelFormDetails.TabIndex = 23;
            labelFormDetails.Text = resources.GetString("labelFormDetails.Text");
            // 
            // labelFormTitle
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFormTitle.Location = new Point(10, 10);
            labelFormTitle.Margin = new Padding(4, 0, 4, 0);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Size = new Size(150, 32);
            labelFormTitle.TabIndex = 22;
            labelFormTitle.Text = "Ny arbetstyp";
            // 
            // buttonAddWorkType
            // 
            buttonAddWorkType.Location = new Point(14, 381);
            buttonAddWorkType.Name = "buttonAddWorkType";
            buttonAddWorkType.Size = new Size(212, 40);
            buttonAddWorkType.TabIndex = 1;
            buttonAddWorkType.Text = "Lägg till arbetstypen";
            buttonAddWorkType.UseVisualStyleBackColor = true;
            buttonAddWorkType.Click += buttonAddWorkType_Click;
            // 
            // panelFormHeader
            // 
            panelFormHeader.Controls.Add(labelFormTitle);
            panelFormHeader.Controls.Add(labelFormDetails);
            panelFormHeader.Location = new Point(0, 0);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(665, 152);
            panelFormHeader.TabIndex = 24;
            // 
            // NewWorkTypeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 440);
            Controls.Add(panelFormHeader);
            Controls.Add(buttonAddWorkType);
            Controls.Add(panelProperties);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewWorkTypeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ny arbetstyp";
            Load += NewWorkTypeForm_Load;
            panelProperties.ResumeLayout(false);
            panelProperties.PerformLayout();
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProperties;
        private Label labelFormDetails;
        private Label labelFormTitle;
        private Label labelName;
        private Label labelVatRate;
        private TextBox textName;
        private Label labelTaxReductionRate;
        private Button buttonAddWorkType;
        private Panel panelFormHeader;
        private ComboBox cbVatRate;
        private ComboBox cbTaxReductionRate;
    }
}