using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public static class cls_CnsDisplayTres
    {
        //------------------------------------------------------------------------------
        //Constructor Method
        //------------------------------------------------------------------------------
        public static void ConstructorOfDisplayThree(Label objLavelDisplayTres, Form formulario)
        {
            objLavelDisplayTres.Text = "Standard";
            objLavelDisplayTres.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            objLavelDisplayTres.BackColor = formulario.BackColor;
            objLavelDisplayTres.ForeColor = Color.Black;

            //------------------------------------------------------------------------------
            // Position and size of display3
            //------------------------------------------------------------------------------
            objLavelDisplayTres.Location = new Point(2, 2);
            objLavelDisplayTres.Size = new Size(formulario.Width -20, 20);
        }
    }
}
