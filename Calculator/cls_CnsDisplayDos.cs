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
        public static void ConstructorDeDisplayDos(Label objLavelDisplayDos, Form formulario)
        {
            objLavelDisplayDos.TextAlign = ContentAlignment.MiddleRight;
            objLavelDisplayDos.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            objLavelDisplayDos.BackColor = formulario.BackColor;
            objLavelDisplayDos.ForeColor = Color.Red;

            //Posición y tamaño del display2
            objLavelDisplayDos.Location = new Point(12, 12);
            objLavelDisplayDos.Size = new Size(formulario.Width - 20, 50);
        }
    }
}
