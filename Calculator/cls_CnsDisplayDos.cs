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
    public static class cls_CnsDisplayDos
    {
        //------------------------------------------------------------------------------
        //Constructor Method
        //------------------------------------------------------------------------------
        public static void ConstructorForDisplayTwo(Label objLavelDisplayDos, Form formulario)
        {
            objLavelDisplayDos.TextAlign = ContentAlignment.MiddleRight;
            objLavelDisplayDos.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            objLavelDisplayDos.BackColor = formulario.BackColor;
            objLavelDisplayDos.ForeColor = Color.SteelBlue;

            objLavelDisplayDos.Location = new Point(2, 28);
            objLavelDisplayDos.Size = new Size(formulario.Width - 20, 30);
        }
    }
}
