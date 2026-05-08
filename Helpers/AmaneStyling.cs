using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace AmanePOSHelpers
{
    public static class AmaneStyling
    {
        // defining a cohesive colour pallete for the application

        // main components
        public static readonly Color NavBar = ColorTranslator.FromHtml("#DCB4B4");
        public static readonly Color CardPanel = ColorTranslator.FromHtml("#9E8585");
        public static readonly Color PageBg = ColorTranslator.FromHtml("#F5EEE8");
        public static readonly Color Accent = ColorTranslator.FromHtml("#C69898");
        public static readonly Color Divider = ColorTranslator.FromHtml("#D2B9B9");

        // text colouring
        public static readonly Color TextDark = ColorTranslator.FromHtml("#463232");
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#8C6E6E");
        public static readonly Color TextOnNav = ColorTranslator.FromHtml("#3C2828");
        public static readonly Color TextOnURL = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color TextOnAccent = ColorTranslator.FromHtml("#827777");

        // interactive components
        public static readonly Color InputBg = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color InputBorder = ColorTranslator.FromHtml("#C8AAAA");
        public static readonly Color ButtonPrimary = ColorTranslator.FromHtml("#C69898");
        public static readonly Color ButtonSecondary = ColorTranslator.FromHtml("#9E8585");
        public static readonly Color ButtonText = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color CardBg = ColorTranslator.FromHtml("#FAF3F0");
        public static readonly Color AccentLight = ColorTranslator.FromHtml("#F3CFC6");

        // status indicators
        public static readonly Color Success = ColorTranslator.FromHtml("#82B48C");
        public static readonly Color Warning = ColorTranslator.FromHtml("#DCB464");
        public static readonly Color Danger = ColorTranslator.FromHtml("#D26464");

        // font settings
        public const int NavHeight = 56;
        public const int ButtonHeight = 40;

        public static readonly Font FontLabel = new Font("Cambria", 10f, FontStyle.Regular);
        private static readonly Font FontTitleBold = new Font("Cambria", 14f, FontStyle.Bold);
        public static readonly Font FontTitle = FontTitleBold;
        public static readonly Font FontBody = new Font("Cambria    ", 9f, FontStyle.Regular);
        public static readonly Font FontNav = new Font("Cambria", 10f, FontStyle.Bold);
        private static readonly Font font = new Font("Cambria", 10f, FontStyle.Regular);
        public static readonly Font FontButton = font;
        public static readonly Font FontNavItem = new Font("Cambria", 10f, FontStyle.Regular);

        // text box styling
        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = InputBg;
            textBox.ForeColor = TextDark;
            textBox.Font = FontBody;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Padding = new Padding(8);
        }

        // button styling
        public static void StyleButton(Button button, bool primary = true)
        {
            button.BackColor = primary ? ButtonPrimary : ButtonSecondary;
            button.ForeColor = ButtonText;
            button.Font = FontButton;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(100, ButtonHeight);
            button.Cursor = Cursors.Hand;
        }
    }

    // dark mode- switched after 5pm, using the same structure but with a different colour palette
    public static class AmaneAltStyling
    {

        // main components (dark mode)
        public static readonly Color PageBg = ColorTranslator.FromHtml("#1F1A1A");
        public static readonly Color CardPanel = ColorTranslator.FromHtml("#2D2424");
        public static readonly Color CardBg = ColorTranslator.FromHtml("#292121");
        public static readonly Color NavBar = ColorTranslator.FromHtml("#332828");
        public static readonly Color Divider = ColorTranslator.FromHtml("#463A3A");

        // text colouring  (dark mode)
        public static readonly Color TextDark = ColorTranslator.FromHtml("#EBE2E2");
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#A38E8E");
        public static readonly Color TextOnNav = ColorTranslator.FromHtml("#F5EEE8");
        public static readonly Color TextOnURL = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color TextOnAccent = ColorTranslator.FromHtml("#1F1A1A");

        // interactive components (dark mode)
        public static readonly Color InputBg = ColorTranslator.FromHtml("#120E0E");
        public static readonly Color InputBorder = ColorTranslator.FromHtml("#5C4B4B");
        public static readonly Color ButtonPrimary = ColorTranslator.FromHtml("#A67A7A");
        public static readonly Color ButtonSecondary = ColorTranslator.FromHtml("#5C4B4B");
        public static readonly Color ButtonText = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color Accent = ColorTranslator.FromHtml("#A67A7A");
        public static readonly Color AccentLight = ColorTranslator.FromHtml("#4A3B3B");

        // status indicators (stay the same for dark mode)
        public static readonly Color Success = ColorTranslator.FromHtml("#82B48C");
        public static readonly Color Warning = ColorTranslator.FromHtml("#DCB464");
        public static readonly Color Danger = ColorTranslator.FromHtml("#D26464");

        // font settings (remain the same for dark mode)
        public const int NavHeight = 56;
        public const int ButtonHeight = 40;

        // specific font instances for dark mode (same as light mode for consistency)
        public static readonly Font FontLabel = new Font("Cambria", 10f, FontStyle.Regular);
        private static readonly Font FontTitleBold = new Font("Cambria", 14f, FontStyle.Bold);
        public static readonly Font FontTitle = FontTitleBold;
        public static readonly Font FontBody = new Font("Cambria    ", 9f, FontStyle.Regular);
        public static readonly Font FontNav = new Font("Cambria", 10f, FontStyle.Bold);
        private static readonly Font font = new Font("Cambria", 10f, FontStyle.Regular);
        public static readonly Font FontButton = font;
        public static readonly Font FontNavItem = new Font("Cambria", 10f, FontStyle.Regular);

        //text box styling for dark mode
        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = InputBg;
            textBox.ForeColor = TextDark;
            textBox.Font = FontBody;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Padding = new Padding(8);
        }

        // button styling
        public static void StyleButton(Button button, bool primary = true)
        {
            button.BackColor = primary ? ButtonPrimary : ButtonSecondary;
            button.ForeColor = ButtonText;
            button.Font = FontButton;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(100, ButtonHeight);
            button.Cursor = Cursors.Hand;
        }
    }
}
