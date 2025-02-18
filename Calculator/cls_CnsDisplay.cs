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
    public static class cls_CnsDisplay
    {
        //------------------------------------------------------------------------------
        //Constructor Method
        //------------------------------------------------------------------------------
        public static void ConstructorOfDisplay(Label objLabelDisplay, Form form)
        {
            objLabelDisplay.TextAlign = ContentAlignment.MiddleRight;
            objLabelDisplay.Font = new Font("Segoe UI", 30, FontStyle.Regular);
            objLabelDisplay.BackColor = form.BackColor;
            objLabelDisplay.ForeColor = Color.Black;

            //------------------------------------------------------------------------------
            // Position and size of the display
            //------------------------------------------------------------------------------
            objLabelDisplay.Location = new Point(10, 60);
            objLabelDisplay.Size = new Size(form.Width - 20, 70);
        }
    }
}