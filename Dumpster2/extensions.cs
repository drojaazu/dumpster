using System;
using System.Text;

namespace Dumpster2
{
    internal static class Extensions
    {
        public static void ScrollToTop(this System.Windows.Forms.TextBox TextBox)
        {
            TextBox.SelectionStart = 0;
            TextBox.SelectionLength = 1;
            TextBox.ScrollToCaret();
        }

        public static string Desc(this EncodingInfo EncInfo)
        {
            return (EncInfo.DisplayName + "(" + EncInfo.CodePage.ToString() + " - " + EncInfo.Name + ")");
        }

        
    }
}
