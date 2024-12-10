using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    public static class cls_AuxDisplay
    {
        //Cobstructor De Botones
        public static void ConstructorDeDisplay(Label objLabel)
        {
            //Caracteristicas
            objLabel.TextAlign = ContentAlignment.BottomRight; //Texto Esquina Inferior Derecha
            objLabel.Font = new Font("Arial", 16);
        }

    }
}
