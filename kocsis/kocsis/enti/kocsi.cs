﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using kocsis.absztrakt;

namespace kocsis.enti
{
  public  class kocsi : tutuk

    {
        

       

        protected override void  DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("C:/Users/ToshibaC850/Desktop/Puter Mihály/irf uj/kocsis/kocsis/Images/audi.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
        


    }
}
