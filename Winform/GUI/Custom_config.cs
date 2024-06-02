using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class Custom_config
    {
        //Custom font
        public static PrivateFontCollection Init_CustomLabel_Font(int mode)
        {

            PrivateFontCollection pfc;
            pfc = new PrivateFontCollection();

            if (mode == 1)
            {

                int fontLength = Properties.Resources.Roboto_Medium.Length;
                byte[] fontdata = Properties.Resources.Roboto_Medium;
                System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontdata, 0, data, fontLength);
                pfc.AddMemoryFont(data, fontLength);
                
            }
            else if(mode == 2)
            {
                int fontLength = Properties.Resources.Roboto_Regular.Length;
                byte[] fontdata = Properties.Resources.Roboto_Regular;
                System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontdata, 0, data, fontLength);
                pfc.AddMemoryFont(data, fontLength);
                
            }
            else
            {
                int fontLength = Properties.Resources.Roboto_Thin.Length;
                byte[] fontdata = Properties.Resources.Roboto_Thin;
                System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontdata, 0, data, fontLength);
                pfc.AddMemoryFont(data, fontLength);
                
            }
            return pfc;
        }
        //End Custom font

    }
}
