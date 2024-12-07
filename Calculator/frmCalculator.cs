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
            //Button ±
            Button objButton1 = new Button();
            objButton1.Location = new Point(20, 440); //Filas Columnas
            objButton1.Text = "±";
            cls_CnsBotones.ConstructorDeBotones(objButton1);
            this.Controls.Add(objButton1);

            //btn 1
            Button objButton2 = new Button();
            objButton2.Location = new Point(20, 386);
            objButton2.Text = "1";
            cls_CnsBotones.ConstructorDeBotones(objButton2);
            this.Controls.Add(objButton2);

            //btn 4
            Button objButton3 = new Button();
            objButton3.Location = new Point(20, 332);
            objButton3.Text = "4";
            cls_CnsBotones.ConstructorDeBotones(objButton3);
            this.Controls.Add(objButton3);

            //btn 7
            Button objButton4 = new Button();
            objButton4.Location = new Point(20,278);
            objButton4.Text = "7";
            cls_CnsBotones.ConstructorDeBotones(objButton4);
            this.Controls.Add(objButton4);

            //Button 0
            Button objButton5 = new Button();
            objButton5.Location = new Point(90,440);
            objButton5.Text = "0";
            cls_CnsBotones.ConstructorDeBotones(objButton5);
            this.Controls.Add(objButton5);

            //Button ,
            Button objButton6 = new Button();
            objButton6.Location = new Point(160, 440);
            objButton6.Text = ",";
            cls_CnsBotones.ConstructorDeBotones(objButton6);
            this.Controls.Add(objButton6);

            //Button =
            Button objButton7 = new Button();
            objButton7.Location = new Point(230, 440);
            objButton7.Text = "=";
            cls_CnsBotones.ConstructorDeBotones(objButton7);
            //En Esta Propiedad Se Sobreescribe El Metodo Del Color
            objButton7.BackColor = Color.SteelBlue;
            objButton7.ForeColor = Color.White;
            this.Controls.Add(objButton7);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalculator
            // 
            this.ClientSize = new System.Drawing.Size(359, 494);
            this.Name = "frmCalculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load_1);
            this.ResumeLayout(false);

        }

        private void frmCalculator_Load_1(object sender, EventArgs e)
        {

        }
    }
}
