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
    public static class cls_AuxDisplay
    {
        public static void ConstructorDeDisplay(Label objLabelDisplay, Form formulario)
        {
            objLabelDisplay.TextAlign = ContentAlignment.MiddleRight;
            objLabelDisplay.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            objLabelDisplay.BackColor = formulario.BackColor;
            objLabelDisplay.ForeColor = Color.Black;

            // Posición y tamaño del display
            objLabelDisplay.Location = new Point(10, 60);
            objLabelDisplay.Size = new Size(formulario.Width - 20, 70);
        }


    }
}



