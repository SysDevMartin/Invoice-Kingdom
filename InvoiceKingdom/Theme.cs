using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom
{
    internal class Theme
    {
        // Form.
        public static readonly Color FormForeColor = Color.Black;
        public static readonly Color FormBackColor = Color.Gainsboro;
        public static readonly Color FormDetailsLabelForeColor = Color.DimGray;

        // Label.
        public static readonly Color LabelDetailsForeColor = Color.FromArgb(64, 64, 64);

        // Panel.
        public static readonly Color PanelForeColor = Color.Black;
        public static readonly Color PanelBackColor = Color.LightGray;
        public static readonly BorderStyle PanelBorderStyle = BorderStyle.FixedSingle;

        // Control.
        public static readonly Color ControlDefaultForeColor = Color.Black;
        public static readonly Color ControlDefaultBackColor = Color.White;

        // TextBox.
        public static readonly BorderStyle TextboxBorderStyle = BorderStyle.FixedSingle;

        // ListBox.
        public static readonly BorderStyle ListBoxBorderStyle = BorderStyle.FixedSingle;

        // Button.
        public static readonly Color ButtonForeColor = Color.Black;
        public static readonly Color ButtonBackColor = Color.WhiteSmoke;
        public static readonly FlatStyle ButtonFlatStyle = FlatStyle.Flat;

        // CheckBox.
        public static readonly Color CheckboxForeColor = Color.Black;
        public static readonly Color CheckboxBackColor = Color.Transparent;
        public static readonly FlatStyle CheckboxFlatStyle = FlatStyle.Standard;

        public static void SetFormStyle(Form form, Label formDetailsLabel = null!)
        {
            form.ForeColor = FormForeColor;
            form.BackColor = FormBackColor;

            if (formDetailsLabel != null)
            {
                formDetailsLabel.ForeColor = FormDetailsLabelForeColor;
            }
        }

        public static void SetPanelStyle(Panel[] panels)
        {
            foreach (var panel in panels)
            {
                panel.ForeColor = PanelForeColor;
                panel.BackColor = PanelBackColor;
                panel.BorderStyle = PanelBorderStyle;
            }
        }

        public static void SetControlStyle(Control[] controls)
        {
            foreach (var control in controls)
            {
                control.ForeColor = ControlDefaultForeColor;
                control.BackColor = ControlDefaultBackColor;

                if (control is TextBox)
                {
                    ((TextBox)control).BorderStyle = TextboxBorderStyle;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).BorderStyle = ListBoxBorderStyle;
                }
                else if (control is CheckedListBox)
                {
                    ((CheckedListBox)control).BorderStyle = ListBoxBorderStyle;
                }
                else if (control is Button)
                {
                    ((Button)control).ForeColor = ButtonForeColor;
                    ((Button)control).BackColor = ButtonBackColor;
                    ((Button)control).FlatStyle = ButtonFlatStyle;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).ForeColor = CheckboxForeColor;
                    ((CheckBox)control).BackColor = CheckboxBackColor;
                    ((CheckBox)control).FlatStyle = CheckboxFlatStyle;
                }
            }
        }
    }
}
