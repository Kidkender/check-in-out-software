using System;
using System.Drawing;
using System.Drawing.Text;

namespace CheckinManagementSystem.Common
{
    public class CommonMethod
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();


        public Font getFont()
        {
            byte[] fontData = Properties.Resources.DFKai_SB_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.DFKai_SB_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.DFKai_SB_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], 16);
        }
    }
}
