using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public static class ExtensionMethods {
    public static void Borderize(this Bitmap b)
    {
        for (int i = 0; i < b.Width; i++)
        {
            b.SetPixel(i, 0, Color.Black);
            b.SetPixel(i, b.Height - 1, Color.Black);
        }

        for (int i = 0; i < b.Height; i++)
        {
            b.SetPixel(0, i, Color.Black);
            b.SetPixel(b.Width - 1, i, Color.Black);
        }
    }
}
