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
            objButton1.Location = new Point(8, 440); //Filas Columnas
            objButton1.Text = "±";
            cls_CnsBotones.ConstructorDeBotones(objButton1);
            this.Controls.Add(objButton1);

            //Button 1
            Button objButton2 = new Button();
            objButton2.Location = new Point(8, 386);
            objButton2.Text = "1";
            cls_CnsBotones.ConstructorDeBotones(objButton2);
            this.Controls.Add(objButton2);

            //Button 4
            Button objButton3 = new Button();
            objButton3.Location = new Point(8, 332);
            objButton3.Text = "4";
            cls_CnsBotones.ConstructorDeBotones(objButton3);
            this.Controls.Add(objButton3);

            //Button 7
            Button objButton4 = new Button();
            objButton4.Location = new Point(8,278);
            objButton4.Text = "7";
            cls_CnsBotones.ConstructorDeBotones(objButton4);
            this.Controls.Add(objButton4);

            //Button 0
            Button objButton5 = new Button();
            objButton5.Location = new Point(78,440);
            objButton5.Text = "0";
            cls_CnsBotones.ConstructorDeBotones(objButton5);
            this.Controls.Add(objButton5);

            //Button ,
            Button objButton6 = new Button();
            objButton6.Location = new Point(148, 440);
            objButton6.Text = ",";
            cls_CnsBotones.ConstructorDeBotones(objButton6);
            this.Controls.Add(objButton6);

            //Button =
            Button objButton7 = new Button();
            objButton7.Location = new Point(218, 440);
            objButton7.Text = "=";
            cls_CnsBotones.ConstructorDeBotones(objButton7);
            //En Esta Propiedad Se Sobreescribe El Metodo Del Color
            objButton7.BackColor = Color.SteelBlue;
            objButton7.ForeColor = Color.White;
            this.Controls.Add(objButton7);

            //Button 2
            Button objButton8 = new Button();
            objButton8.Location = new Point(78,386);
            objButton8.Text = "2";
            cls_CnsBotones.ConstructorDeBotones(objButton8);
            this.Controls.Add(objButton8);

            //Button 3
            Button objButton9 = new Button();
            objButton9.Location = new Point(148,386);
            objButton9.Text = "3";
            cls_CnsBotones.ConstructorDeBotones(objButton9);
            this.Controls.Add(objButton9);


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalculator
            // 
            this.ClientSize = new System.Drawing.Size(290, 494);
            this.Name = "frmCalculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load_1);
            this.ResumeLayout(false);

        }

        private void frmCalculator_Load_1(object sender, EventArgs e)
        {

        }
    }
}
