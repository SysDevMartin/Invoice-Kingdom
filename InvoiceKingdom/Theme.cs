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

        // Control element.
        private static readonly Color ControlForeColor = Color.Black;
        private static readonly Color ControlBackColor = Color.White;
        // TODO: BorderStyle

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
                control.ForeColor = ControlForeColor;
                control.BackColor = ControlBackColor;
            }
        }
    }
}
