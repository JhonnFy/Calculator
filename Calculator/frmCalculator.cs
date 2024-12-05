using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {

        //Metodo Constructor
        public frmCalculator()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            NuevosBotones();

        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        
        //Metodo Para CrearBotones
        private void NuevosBotones()
        {
            //btn3
            Button objButton1 = new Button();
            objButton1.Location = new Point(20, 440); //Filas Columnas
            objButton1.Text = "±";
            cls_CnsBotones.ConstructorDeBotones(objButton1);
            this.Controls.Add(objButton1);

            //btn3
            Button objButton2 = new Button();
            objButton2.Location = new Point(20, 386);
            objButton2.Text = "1";
            cls_CnsBotones.ConstructorDeBotones(objButton2);
            this.Controls.Add(objButton2);

            //btn3
            Button objButton3 = new Button();
            objButton3.Location = new Point(20, 332);
            objButton3.Text = "4";
            cls_CnsBotones.ConstructorDeBotones(objButton3);
            this.Controls.Add(objButton3);

            //btn4
            Button objButton4 = new Button();
            objButton4.Location = new Point(20,278);
            objButton4.Text = "7";
            cls_CnsBotones.ConstructorDeBotones(objButton4);
            this.Controls.Add(objButton4);

            //btn5
            Button objButton5 = new Button();
            objButton5.Location = new Point(90,440);
            objButton5.Text = "0";
            cls_CnsBotones.ConstructorDeBotones(objButton5);
            this.Controls.Add(objButton5);

        }


    }
}
