﻿using kocsis.absztrakt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocsis.enti
{
    public class fiat : tutuk
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("C:/Users/ToshibaC850/Desktop/Puter Mihály/irf uj/kocsis/kocsis/Images/fiat.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
