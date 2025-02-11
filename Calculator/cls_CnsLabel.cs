using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public static class cls_CnsLabel
    {
        public static void ConstructorDeLabel(System.Windows.Forms.Label objLabel) //public static void ConstructorDeDisplay(Label objLabelDisplay, Form formulario)
        {
            objLabel.Text = "Standard";
            objLabel.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            objLabel.ForeColor = Color.Black;
            objLabel.Location = new Point(1, 1);
            objLabel.AutoSize = true;
        }
    }
}
