﻿using System;
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

            //Button +
            Button objButton10 = new Button();
            objButton10.Location = new Point(218,386);
            objButton10.Text = "+";
            cls_CnsBotones.ConstructorDeBotones(objButton10);
            //En Esta Propiedad Se Sobreescribe El Metodo Del Color
            objButton10.BackColor = Color.SteelBlue;
            objButton10.ForeColor = Color.White;
            this.Controls.Add(objButton10);

            //Button 5
            Button objButton11 = new Button();
            objButton11.Location = new Point(78,332);
            objButton11.Text = "5";
            cls_CnsBotones.ConstructorDeBotones(objButton11);
            this.Controls.Add(objButton11);

            //Button 6
            Button objButton12 = new Button();
            objButton12.Location = new Point(148,332);
            objButton12.Text = "6";
            cls_CnsBotones.ConstructorDeBotones(objButton12);
            this.Controls.Add(objButton12);

            //Button -
            Button objButton13 = new Button();
            objButton13.Location = new Point(218, 332);
            objButton13.Text = "-";
            cls_CnsBotones.ConstructorDeBotones(objButton13);
            //En Esta Propiedad Se Sobreescribe El Metodo Del Color
            objButton13.BackColor = Color.SteelBlue;
            objButton13.ForeColor = Color.White;
            this.Controls.Add(objButton13);

            //Button 8
            Button objButton14 = new Button();
            objButton14.Location = new Point(78,278);
            objButton14.Text = "8";
            cls_CnsBotones.ConstructorDeBotones(objButton14);
            this.Controls.Add(objButton14);

            //Button 9
            Button objButton15 = new Button();
            objButton15.Location = new Point(148,278);
            objButton15.Text = "9";
            cls_CnsBotones.ConstructorDeBotones(objButton15);
            this.Controls.Add(objButton15);

            //Button *
            Button objButton16 = new Button();
            objButton16.Location = new Point(218,278);
            objButton16.Text = "*";
            cls_CnsBotones.ConstructorDeBotones(objButton16);
            objButton16.BackColor = Color.SteelBlue;
            objButton16.ForeColor = Color.White;
            this.Controls.Add(objButton16);

            //Button ÷
            Button objButton17 = new Button();
            objButton17.Location = new Point(218,224);
            objButton17.Text = "÷";
            cls_CnsBotones.ConstructorDeBotones(objButton17);
            objButton17.BackColor = Color.SteelBlue;
            objButton17.ForeColor = Color.White;
            this.Controls.Add(objButton17);

            //Button «
            Button objButton18 = new Button();
            objButton18.Location = new Point(218,170);
            objButton18.Text = "«";
            cls_CnsBotones.ConstructorDeBotones(objButton18);
            objButton18.BackColor = Color.SteelBlue;
            objButton18.ForeColor = Color.White;
            this.Controls.Add(objButton18);

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
