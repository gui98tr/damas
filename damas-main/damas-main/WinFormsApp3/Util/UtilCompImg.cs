using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WinFormsApp3.Util
{
    internal class UtilCompImg
    {
        public bool CompararImagem(Image img1, Image img2)
        {
            if (img1 == null || img2 == null) 
                return false;
            if (img1.Width != img2.Width || img2.Height != img1.Height)
                return false;
            Bitmap bmp1 = new Bitmap(img1);
            Bitmap bmp2 = new Bitmap(img2);

            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = bmpData1.Stride * bmpData1.Height;
            byte[] bytes1 = new byte[bytes];
            byte[] bytes2 = new byte[bytes];
            Marshal.Copy(bmpData1.Scan0, bytes1, 0, bytes);
            Marshal.Copy(bmpData2.Scan0, bytes2, 0, bytes);
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            for (int i = 0; i < bytes; i++)
            {
                if (bytes1[i] != bytes2[i])
                    return false;
            }
            return true;
        }
    }
}
