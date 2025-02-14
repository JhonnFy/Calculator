using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public static class cls_CnsLabel
    {
        public static void ConstructorLabel(System.Windows.Forms.Label objLavelDisplayDos, Form formulario)
        {
            objLavelDisplayDos.Text = "Standard";
            objLavelDisplayDos.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            objLavelDisplayDos.BackColor = formulario.BackColor;
            objLavelDisplayDos.ForeColor = Color.Blue;

            //Posición y tamaño del display2
            objLavelDisplayDos.Location = new Point(2, 2);
            objLavelDisplayDos.Size = new Size(formulario.Width -1, 1);
        }
    }
}
