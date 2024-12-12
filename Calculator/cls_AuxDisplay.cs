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
        public static void ConstructorDeDisplay(Label objLabel, Form formulario)
        {
            objLabel.TextAlign = ContentAlignment.MiddleRight;
            objLabel.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            objLabel.BackColor = formulario.BackColor;
            objLabel.ForeColor = Color.Black;

            // Posición y tamaño del display
            objLabel.Location = new Point(10, 60);
            objLabel.Size = new Size(formulario.Width - 20, 70);
        }


    }
}



