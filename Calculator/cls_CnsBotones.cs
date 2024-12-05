using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public static class cls_CnsBotones
    {

        //Metodo Constructor De Botones
        public static void ConstructorDeBotones(Button objButton)
        {
            //Colores
            objButton.BackColor = Color.White;
            objButton.ForeColor = Color.Black;
            objButton.FlatStyle = FlatStyle.Flat;
            objButton.FlatAppearance.BorderSize = 0;
            objButton.TabStop = false;
            objButton.Size = new Size(65, 50); //Ancho Alto
            objButton.Font = new Font(objButton.Font.FontFamily, 12);
        }

    }
}
