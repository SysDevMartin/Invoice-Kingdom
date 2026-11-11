namespace InvoiceKingdom.Forms
{
    partial class NewTaxTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaxTypeForm));
            panelFormHeader = new Panel();
            labelFormTitle = new Label();
            labelFormDetails = new Label();
            panelProperties = new Panel();
            numericRate = new NumericUpDown();
            labelRate = new Label();
            cbFunction = new ComboBox();
            labelType = new Label();
            this.textName = new TextBox();
            labelName = new Label();
            buttonAddTaxType = new Button();
            panelFormHeader.SuspendLayout();
            panelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRate).BeginInit();
            SuspendLayout();
            // 
            // panelFormHeader
            // 
            panelFormHeader.Controls.Add(labelFormTitle);
            panelFormHeader.Controls.Add(labelFormDetails);
            panelFormHeader.Location = new Point(0, 0);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(707, 152);
            panelFormHeader.TabIndex = 25;
            // 
            // labelFormTitle
            // 
            labelFormTitle.AutoSize = true;
            labelFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFormTitle.Location = new Point(10, 10);
            labelFormTitle.Margin = new Padding(4, 0, 4, 0);
            labelFormTitle.Name = "labelFormTitle";
            labelFormTitle.Size = new Size(148, 32);
            labelFormTitle.TabIndex = 22;
            labelFormTitle.Text = "Ny skattetyp";
            // 
            // labelFormDetails
            // 
            labelFormDetails.AutoSize = true;
            labelFormDetails.Location = new Point(13, 45);
            labelFormDetails.Margin = new Padding(4, 0, 4, 0);
            labelFormDetails.Name = "labelFormDetails";
            labelFormDetails.Size = new Size(680, 92);
            labelFormDetails.TabIndex = 23;
            labelFormDetails.Text = resources.GetString("labelFormDetails.Text");
            // 
            // panelProperties
            // 
            panelProperties.Controls.Add(numericRate);
            panelProperties.Controls.Add(labelRate);
            panelProperties.Controls.Add(cbFunction);
            panelProperties.Controls.Add(labelType);
            panelProperties.Controls.Add(this.textName);
            panelProperties.Controls.Add(labelName);
            panelProperties.Location = new Point(13, 174);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(680, 178);
            panelProperties.TabIndex = 0;
            // 
            // numericRate
            // 
            numericRate.Location = new Point(354, 126);
            numericRate.Name = "numericRate";
            numericRate.Size = new Size(127, 30);
            numericRate.TabIndex = 2;
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Location = new Point(354, 100);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(127, 23);
            labelRate.TabIndex = 4;
            labelRate.Text = "Skattesats (%) *";
            // 
            // cbFunction
            // 
            cbFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFunction.FormattingEnabled = true;
            cbFunction.Location = new Point(15, 126);
            cbFunction.Name = "cbFunction";
            cbFunction.Size = new Size(268, 31);
            cbFunction.TabIndex = 1;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(15, 100);
            labelType.Name = "labelType";
            labelType.Size = new Size(88, 23);
            labelType.TabIndex = 2;
            labelType.Text = "Funktion *";
            // 
            // textName
            // 
            this.textName.Location = new Point(15, 42);
            this.textName.Name = "textName";
            this.textName.Size = new Size(647, 30);
            this.textName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(186, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Namn på skattetypen *";
            // 
            // buttonAddTaxType
            // 
            buttonAddTaxType.Location = new Point(13, 385);
            buttonAddTaxType.Name = "buttonAddTaxType";
            buttonAddTaxType.Size = new Size(212, 40);
            buttonAddTaxType.TabIndex = 1;
            buttonAddTaxType.Text = "Lägg till skattetypen";
            buttonAddTaxType.UseVisualStyleBackColor = true;
            buttonAddTaxType.Click += buttonAddTaxType_Click;
            // 
            // NewTaxTypeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 441);
            Controls.Add(buttonAddTaxType);
            Controls.Add(panelProperties);
            Controls.Add(panelFormHeader);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "NewTaxTypeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ny skattetyp";
            Load += NewTaxTypeForm_Load;
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelProperties.ResumeLayout(false);
            panelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormHeader;
        private Label labelFormTitle;
        private Label labelFormDetails;
        private Panel panelProperties;
        private Label labelName;
        private TextBox textName;
        private ComboBox cbFunction;
        private Label labelType;
        private Button buttonAddTaxType;
        private Label labelRate;
        private NumericUpDown numericRate;
    }
}