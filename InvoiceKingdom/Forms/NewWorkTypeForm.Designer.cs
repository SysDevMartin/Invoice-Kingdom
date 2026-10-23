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
            panelProperties = new Panel();
            labelTaxReductionRateUnit = new Label();
            labelVatRateUnit = new Label();
            textTaxReductionRate = new TextBox();
            labelTaxReductionRate = new Label();
            textVatRate = new TextBox();
            labelVatRate = new Label();
            textName = new TextBox();
            labelName = new Label();
            labelFormDetails = new Label();
            labelFormTitle = new Label();
            buttonAddWorkType = new Button();
            panelProperties.SuspendLayout();
            SuspendLayout();
            // 
            // panelProperties
            // 
            panelProperties.Controls.Add(labelTaxReductionRateUnit);
            panelProperties.Controls.Add(labelVatRateUnit);
            panelProperties.Controls.Add(textTaxReductionRate);
            panelProperties.Controls.Add(labelTaxReductionRate);
            panelProperties.Controls.Add(textVatRate);
            panelProperties.Controls.Add(labelVatRate);
            panelProperties.Controls.Add(textName);
            panelProperties.Controls.Add(labelName);
            panelProperties.Location = new Point(14, 119);
            panelProperties.Margin = new Padding(4, 5, 4, 5);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(633, 185);
            panelProperties.TabIndex = 0;
            // 
            // labelTaxReductionRateUnit
            // 
            labelTaxReductionRateUnit.AutoSize = true;
            labelTaxReductionRateUnit.Location = new Point(301, 136);
            labelTaxReductionRateUnit.Name = "labelTaxReductionRateUnit";
            labelTaxReductionRateUnit.Size = new Size(24, 23);
            labelTaxReductionRateUnit.TabIndex = 7;
            labelTaxReductionRateUnit.Text = "%";
            // 
            // labelVatRateUnit
            // 
            labelVatRateUnit.AutoSize = true;
            labelVatRateUnit.Location = new Point(124, 136);
            labelVatRateUnit.Name = "labelVatRateUnit";
            labelVatRateUnit.Size = new Size(24, 23);
            labelVatRateUnit.TabIndex = 6;
            labelVatRateUnit.Text = "%";
            // 
            // textTaxReductionRate
            // 
            textTaxReductionRate.Location = new Point(195, 133);
            textTaxReductionRate.Name = "textTaxReductionRate";
            textTaxReductionRate.Size = new Size(100, 30);
            textTaxReductionRate.TabIndex = 2;
            // 
            // labelTaxReductionRate
            // 
            labelTaxReductionRate.AutoSize = true;
            labelTaxReductionRate.Location = new Point(195, 107);
            labelTaxReductionRate.Name = "labelTaxReductionRate";
            labelTaxReductionRate.Size = new Size(112, 23);
            labelTaxReductionRate.TabIndex = 4;
            labelTaxReductionRate.Text = "RUT-avdrag *";
            // 
            // textVatRate
            // 
            textVatRate.Location = new Point(18, 133);
            textVatRate.Name = "textVatRate";
            textVatRate.Size = new Size(100, 30);
            textVatRate.TabIndex = 1;
            // 
            // labelVatRate
            // 
            labelVatRate.AutoSize = true;
            labelVatRate.Location = new Point(18, 107);
            labelVatRate.Name = "labelVatRate";
            labelVatRate.Size = new Size(69, 23);
            labelVatRate.TabIndex = 2;
            labelVatRate.Text = "Moms *";
            // 
            // textName
            // 
            textName.Location = new Point(18, 42);
            textName.Name = "textName";
            textName.Size = new Size(408, 30);
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
            labelFormDetails.Location = new Point(14, 46);
            labelFormDetails.Margin = new Padding(4, 0, 4, 0);
            labelFormDetails.Name = "labelFormDetails";
            labelFormDetails.Size = new Size(633, 46);
            labelFormDetails.TabIndex = 23;
            labelFormDetails.Text = "Lägg till en ny arbetstyp i företaget. Du kan ändra alla uppgifter senare vid behov.\r\nEn asterisk (*) vid ett fält betyder att det måste fyllas i.";
            // 
            // labelFormTitle
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFormTitle.Location = new Point(11, 10);
            labelFormTitle.Margin = new Padding(4, 0, 4, 0);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Size = new Size(150, 32);
            labelFormTitle.TabIndex = 22;
            labelFormTitle.Text = "Ny arbetstyp";
            // 
            // buttonAddWorkType
            // 
            buttonAddWorkType.Location = new Point(14, 334);
            buttonAddWorkType.Name = "buttonAddWorkType";
            buttonAddWorkType.Size = new Size(212, 41);
            buttonAddWorkType.TabIndex = 1;
            buttonAddWorkType.Text = "Lägg till arbetstypen";
            buttonAddWorkType.UseVisualStyleBackColor = true;
            buttonAddWorkType.Click += buttonAddWorkType_Click;
            // 
            // NewWorkTypeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 393);
            Controls.Add(buttonAddWorkType);
            Controls.Add(labelFormDetails);
            Controls.Add(labelFormTitle);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProperties;
        private Label labelFormDetails;
        private Label labelFormTitle;
        private Label labelName;
        private TextBox textVatRate;
        private Label labelVatRate;
        private TextBox textName;
        private TextBox textTaxReductionRate;
        private Label labelTaxReductionRate;
        private Label labelTaxReductionRateUnit;
        private Label labelVatRateUnit;
        private Button buttonAddWorkType;
    }
}