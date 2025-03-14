﻿using System;
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
        //------------------------------------------------------------------------------
        // Button Constructor Method
        //------------------------------------------------------------------------------
        public static void ButtonConstructor(Button objButton)
        {
            //------------------------------------------------------------------------------
            // Colors
            //------------------------------------------------------------------------------
            objButton.BackColor = Color.White;
            objButton.ForeColor = Color.Black;
            objButton.FlatStyle = FlatStyle.Flat;
            objButton.FlatAppearance.BorderSize = 0;
            objButton.TabStop = false;
            objButton.Size = new Size(65, 50); // Width Height
            objButton.Font = new Font(objButton.Font.FontFamily, 12);
        }
    }
}
