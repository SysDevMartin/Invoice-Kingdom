using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceKingdom
{
    internal class Theme
    {
        // Form.
        private static readonly Color FormForeColor = Color.Black;
        private static readonly Color FormBackColor = Color.Gainsboro;

        // Panel.
        private static readonly Color PanelForeColor = Color.Black;
        private static readonly Color PanelBackColor = Color.LightGray;
        private static readonly BorderStyle PanelBorderStyle = BorderStyle.FixedSingle;

        // Control.
        private static readonly Color ControlDefaultForeColor = Color.Black;
        private static readonly Color ControlDefaultBackColor = Color.White;

        // TextBox.
        private static readonly BorderStyle TextboxBorderStyle = BorderStyle.FixedSingle;

        // ListBox.
        private static readonly BorderStyle ListBoxBorderStyle = BorderStyle.FixedSingle;

        // Button.
        private static readonly Color ButtonForeColor = Color.Black;
        private static readonly Color ButtonBackColor = Color.WhiteSmoke;
        private static readonly FlatStyle ButtonFlatStyle = FlatStyle.Flat;

        // CheckBox.
        private static readonly Color CheckboxForeColor = Color.Black;
        private static readonly Color CheckboxBackColor = Color.Transparent;
        private static readonly FlatStyle CheckboxFlatStyle = FlatStyle.Standard;

        public static void SetFormStyle(Form form)
        {
            form.ForeColor = FormForeColor;
            form.BackColor = FormBackColor;
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
