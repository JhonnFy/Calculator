using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    public partial class frmCalculator : Form
    {

        private Label objLabelDisplay; //Campo De Clase
        private Label objLabelSegundoDisplay; //Campo De Clase
        private Label objLabelTercerDisplay; //Campo De Clase
        private cls_CnsOperaciones obj_Operaciones;

        //------------------------------------------------------------------------------
        //Metodo Constructor
        //------------------------------------------------------------------------------
        public frmCalculator()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Calculator";
            obj_Operaciones = new cls_CnsOperaciones();

            NuevoDisplay();
            SegundoDisplay();
            NuevosBotones();
            NuevoLabelStandar();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------
        //Metodo Para CrearDisplay
        //------------------------------------------------------------------------------
        private void NuevoDisplay()
        {
            objLabelDisplay = new Label(); //Inicializar El Campo
            objLabelDisplay.Text = "0";
            cls_CnsDisplay.ConstructorDeDisplay(objLabelDisplay, this);
            this.Controls.Add(objLabelDisplay);
        }
        //------------------------------------------------------------------------------
        //Metodo Para Label Standard
        //------------------------------------------------------------------------------
        private void NuevoLabelStandar()
        {
            objLabelTercerDisplay = new Label(); //Inicializar El Campo
            cls_CnsDisplayTres.ConstructorDeDisplayTres(objLabelTercerDisplay, this);
            this.Controls.Add(objLabelTercerDisplay);
        }

        //------------------------------------------------------------------------------
        //Metodo Para CrearSegundoDisplay
        //------------------------------------------------------------------------------
        public void SegundoDisplay()
        {
            objLabelSegundoDisplay = new Label(); //Inicializar El Campo
            cls_CnsDisplayDos.ConstructorDeDisplayDos(objLabelSegundoDisplay, this);
            this.Controls.Add(objLabelSegundoDisplay);
        }

        //------------------------------------------------------------------------------
        //Metodo Para CrearBotones
        //------------------------------------------------------------------------------
        private void NuevosBotones()
        {
            //------------------------------------------------------------------------------
            //Button ±
            //------------------------------------------------------------------------------
            Button objButton1 = new Button();
            objButton1.Location = new Point(8, 440); //Filas Columnas
            objButton1.Text = "±";
            cls_CnsBotones.ConstructorDeBotones(objButton1);
            this.Controls.Add(objButton1);

            //------------------------------------------------------------------------------
            //Button 1
            //------------------------------------------------------------------------------
            Button objButton2 = new Button();
            objButton2.Location = new Point(8, 386);
            objButton2.Text = "1";
            cls_CnsBotones.ConstructorDeBotones(objButton2);
            objButton2.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton2);

            //------------------------------------------------------------------------------
            //Button 4
            //------------------------------------------------------------------------------
            Button objButton3 = new Button();
            objButton3.Location = new Point(8, 332);
            objButton3.Text = "4";
            cls_CnsBotones.ConstructorDeBotones(objButton3);
            objButton3.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton3);

            //------------------------------------------------------------------------------
            //Button 7
            //------------------------------------------------------------------------------
            Button objButton4 = new Button();
            objButton4.Location = new Point(8,278);
            objButton4.Text = "7";
            cls_CnsBotones.ConstructorDeBotones(objButton4);
            objButton4.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton4);

            //------------------------------------------------------------------------------
            //Button 0
            //------------------------------------------------------------------------------
            Button objButton5 = new Button();
            objButton5.Location = new Point(78,440);
            objButton5.Text = "0";
            cls_CnsBotones.ConstructorDeBotones(objButton5);
            objButton5.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton5);

            //------------------------------------------------------------------------------
            //Button ,
            //------------------------------------------------------------------------------
            Button objButton6 = new Button();
            objButton6.Location = new Point(148, 440);
            objButton6.Text = ",";
            cls_CnsBotones.ConstructorDeBotones(objButton6);
            this.Controls.Add(objButton6);

            //------------------------------------------------------------------------------
            //Button =
            //------------------------------------------------------------------------------
            Button objButton7 = new Button();
            objButton7.Location = new Point(218, 440);
            objButton7.Text = "=";
            cls_CnsBotones.ConstructorDeBotones(objButton7);
            objButton7.BackColor = Color.SteelBlue; //En Esta Propiedad Se Sobreescribe El Metodo Del Color
            objButton7.ForeColor = Color.White; //Asignar El Evento Click Al Button
            objButton7.Click += Event_Button_Resultado;
            this.Controls.Add(objButton7);

            //------------------------------------------------------------------------------
            //Button 2
            //------------------------------------------------------------------------------
            Button objButton8 = new Button();
            objButton8.Location = new Point(78,386);
            objButton8.Text = "2";
            cls_CnsBotones.ConstructorDeBotones(objButton8);
            objButton8.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton8);

            //------------------------------------------------------------------------------
            //Button 3
            //------------------------------------------------------------------------------
            Button objButton9 = new Button();
            objButton9.Location = new Point(148,386);
            objButton9.Text = "3";
            cls_CnsBotones.ConstructorDeBotones(objButton9);
            objButton9.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton9);

            //------------------------------------------------------------------------------
            //Button 5
            //------------------------------------------------------------------------------
            Button objButton11 = new Button();
            objButton11.Location = new Point(78,332);
            objButton11.Text = "5";
            cls_CnsBotones.ConstructorDeBotones(objButton11);
            objButton11.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton11);

            //------------------------------------------------------------------------------
            //Button 6
            //------------------------------------------------------------------------------
            Button objButton12 = new Button();
            objButton12.Location = new Point(148,332);
            objButton12.Text = "6";
            cls_CnsBotones.ConstructorDeBotones(objButton12);
            objButton12.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton12);
            
            //------------------------------------------------------------------------------
            //Button 8
            //------------------------------------------------------------------------------
            Button objButton14 = new Button();
            objButton14.Location = new Point(78,278);
            objButton14.Text = "8";
            cls_CnsBotones.ConstructorDeBotones(objButton14);
            objButton14.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton14);

            //------------------------------------------------------------------------------
            //Button 9
            //------------------------------------------------------------------------------
            Button objButton15 = new Button();
            objButton15.Location = new Point(148,278);
            objButton15.Text = "9";  
            cls_CnsBotones.ConstructorDeBotones(objButton15);
            objButton15.Click += Event_Button_Click; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton15);

            //------------------------------------------------------------------------------
            //Button «
            //------------------------------------------------------------------------------
            Button objButton18 = new Button();
            objButton18.Location = new Point(218,170);
            objButton18.Text = "«";
            cls_CnsBotones.ConstructorDeBotones(objButton18);
            objButton18.BackColor = Color.WhiteSmoke;
            objButton18.ForeColor = Color.SteelBlue;
            objButton18.Click += Event_Button_Deletec; //Evento Click Event_Button_Deletec
            this.Controls.Add(objButton18);

            //------------------------------------------------------------------------------
            // Button "1/x"
            //------------------------------------------------------------------------------
            Button objButton19 = new Button();
            objButton19.Location = new Point(8,224);
            objButton19.Text = "1/x";
            objButton19.Click += Event_Button_Reciproco;
            cls_CnsBotones.ConstructorDeBotones(objButton19);
            this.Controls.Add(objButton19);

            //------------------------------------------------------------------------------
            //Button x2 
            //------------------------------------------------------------------------------
            Button objButton20 = new Button();
            objButton20.Location = new Point(78,224);
            objButton20.Text = "x²";
            objButton20.Click += Event_Button_Exponente;
            cls_CnsBotones.ConstructorDeBotones(objButton20);
            this.Controls.Add(objButton20);

            //------------------------------------------------------------------------------
            //Button 2√x
            //------------------------------------------------------------------------------
            Button objButton21 = new Button();
            objButton21.Location = new Point(148, 224);
            objButton21.Text = "2√x";
            objButton21.Click += Event_Button_RaizCuadrada;
            cls_CnsBotones.ConstructorDeBotones(objButton21);
            this.Controls.Add(objButton21);

            //------------------------------------------------------------------------------
            //Button ‰ 
            //------------------------------------------------------------------------------
            Button objButton22 = new Button();
            objButton22.Location = new Point(8,170);
            objButton22.Text = "‰";
            cls_CnsBotones.ConstructorDeBotones(objButton22);
            objButton22.BackColor = Color.WhiteSmoke;
            objButton22.ForeColor = Color.SteelBlue;
            objButton22.Click += Event_Button_Porcentaje;
            this.Controls.Add(objButton22);

            //------------------------------------------------------------------------------
            //Buton CE
            //------------------------------------------------------------------------------
            Button objButton23 = new Button();
            objButton23.Location = new Point(78,170);
            objButton23.Text = "CE";
            cls_CnsBotones.ConstructorDeBotones(objButton23);
            objButton23.Click += Event_Button_Delete; //Asignar El Evento Click Al Button
            objButton23.BackColor = Color.WhiteSmoke;
            objButton23.ForeColor = Color.SteelBlue;
            this.Controls.Add(objButton23);

            //------------------------------------------------------------------------------
            //Button C
            //------------------------------------------------------------------------------
            Button objButton24 = new Button();
            objButton24.Location = new Point(148,170);
            objButton24.Text = "C";
            cls_CnsBotones.ConstructorDeBotones(objButton24);
            objButton24.Click += Event_Button_Delete; //Asignar El Evento Click Al Button
            objButton24.BackColor = Color.WhiteSmoke;
            objButton24.ForeColor = Color.SteelBlue;
            this.Controls.Add(objButton24);

            //------------------------------------------------------------------------------
            //Button +
            //------------------------------------------------------------------------------
            Button objButton10 = new Button();
            objButton10.Location = new Point(218, 386);
            objButton10.Text = "+";
            cls_CnsBotones.ConstructorDeBotones(objButton10);
            objButton10.BackColor = Color.WhiteSmoke;
            objButton10.ForeColor = Color.SteelBlue;
            objButton10.Click += Event_Button_Sumar;
            this.Controls.Add(objButton10);

            //------------------------------------------------------------------------------
            //Button -
            //------------------------------------------------------------------------------
            Button objButton13 = new Button();
            objButton13.Location = new Point(218, 332);
            objButton13.Text = "-";
            cls_CnsBotones.ConstructorDeBotones(objButton13);
            objButton13.BackColor = Color.WhiteSmoke; 
            objButton13.ForeColor = Color.SteelBlue;
            objButton13.Click += Event_Button_Restar;
            this.Controls.Add(objButton13);

            //------------------------------------------------------------------------------
            //Button *
            //------------------------------------------------------------------------------
            Button objButton16 = new Button();
            objButton16.Location = new Point(218, 278);
            objButton16.Text = "*";
            cls_CnsBotones.ConstructorDeBotones(objButton16);
            objButton16.BackColor = Color.WhiteSmoke;
            objButton16.ForeColor = Color.SteelBlue;
            objButton16.Click += Event_Button_Multiplicar; //Asignar El Evento Click Al Button
            this.Controls.Add(objButton16);

            //------------------------------------------------------------------------------
            //Button ÷
            //------------------------------------------------------------------------------
            Button objButton17 = new Button();
            objButton17.Location = new Point(218, 224);
            objButton17.Text = "÷";
            cls_CnsBotones.ConstructorDeBotones(objButton17);
            objButton17.BackColor = Color.WhiteSmoke;
            objButton17.ForeColor = Color.SteelBlue;
            objButton17.Click += Event_Button_Dividir;
            this.Controls.Add(objButton17);

        }

        private void ObjButton17_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //------------------------------------------------------------------------------
        //Metodo Evento Click Borrar
        //------------------------------------------------------------------------------
        public void Event_Button_Delete(object sender, EventArgs e)
        {
            objLabelDisplay.Text = "0";
            objLabelSegundoDisplay.Text = "";
        }

        //------------------------------------------------------------------------------
        //Metodo Evento_Click Borrar El Ultimo Caracter Ingresado
        //------------------------------------------------------------------------------
        public void Event_Button_Deletec(object sender, EventArgs e)
        {
            //Verifica Si El Display No Esta Vacio
            if (objLabelDisplay.Text.Length >0)
            {
                //Eliminar El Ultimo Caracter Ingresado
                objLabelDisplay.Text = objLabelDisplay.Text.Substring(0, objLabelDisplay.Text.Length -1);
            }
        }

        //------------------------------------------------------------------------------
        //Metodo Que Imprime En El Display La Selección Del Usuario
        //------------------------------------------------------------------------------
        public void Event_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; //Marca El Boton Que Hizo Click

            if (objLabelDisplay.Text == "0")
            {
                objLabelDisplay.Text = clickedButton.Text;
                
            }
            else
            {
                objLabelDisplay.Text += clickedButton.Text;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.SuspendLayout();
            // 
            // frmCalculator
            // 
            this.ClientSize = new System.Drawing.Size(290, 494);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load_1);
            this.ResumeLayout(false);

        }

        private void frmCalculator_Load_1(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------
        //Metodo Sumar +
        //------------------------------------------------------------------------------
        private void Event_Button_Sumar(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("+");
            //Limpiar El Display Para Ingresar El Siguiente Valor
            objLabelDisplay.Text = "";
        }
        //------------------------------------------------------------------------------
        //Metodo Restar -
        //------------------------------------------------------------------------------
        private void Event_Button_Restar(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("-");
            //Limpiar El Display Para Ingresar El Siguiente Valor
            objLabelDisplay.Text = "";
        }
        //------------------------------------------------------------------------------
        //Metodo Multiplicar *
        //------------------------------------------------------------------------------
        private void Event_Button_Multiplicar(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //almacenar El Operador
            obj_Operaciones.SetOperador("*");
            //Limpiar El Display Para Ingresar El Siguiente Valor
            objLabelDisplay.Text = "";
        }

        //------------------------------------------------------------------------------
        //Metodo Dividir /
        //------------------------------------------------------------------------------
        private void Event_Button_Dividir(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("/");
            //Limpiar El Display Para Ingresar El Siguiente Valor
            objLabelDisplay.Text = "";
        }
        //------------------------------------------------------------------------------
        //Metodo Exponente x²
        //------------------------------------------------------------------------------
        private void Event_Button_Exponente(object sender, EventArgs a)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("x²");
        }

        //------------------------------------------------------------------------------
        //Metodo 2√x  
        //------------------------------------------------------------------------------
        private void Event_Button_RaizCuadrada(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("2√x");
        }

        //------------------------------------------------------------------------------
        //Metodo 1/x
        //------------------------------------------------------------------------------
        private void Event_Button_Reciproco(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("1/x");
        }
        //------------------------------------------------------------------------------
        //Metodo ‰
        //------------------------------------------------------------------------------
        private void Event_Button_Porcentaje(object sender, EventArgs e)
        {
            //Almacenar El Primer Número
            obj_Operaciones.SetNum1(double.Parse(objLabelDisplay.Text));
            //Almacenar El Operador
            obj_Operaciones.SetOperador("‰");
        }

        //------------------------------------------------------------------------------
        //Metodo Resultado =
        //------------------------------------------------------------------------------
        private void Event_Button_Resultado(object sender, EventArgs e)
        {
            //Almacenar El Segundo Número
            obj_Operaciones.SetNum2(double.Parse(objLabelDisplay.Text));

            //Iterar Sobre Un Valor En Cero
            if (obj_Operaciones.GetOperador() == "/" && obj_Operaciones.GetNum2() == 0)
            {
                //No Permitido
                objLabelDisplay.Text = "Not Allowed";
            }
            else
            {
                //Realizar La Operación
                double salida = obj_Operaciones.OperacionesMatematicas();

                //Imprimir el resultado
                objLabelDisplay.Text = salida.ToString();
            }
            
            // Usar los métodos get para obtener los valores de num1 y num2
            objLabelSegundoDisplay.Text = "(" + obj_Operaciones.GetNum1().ToString() + "" + obj_Operaciones.GetOperador().ToString() + "" + obj_Operaciones.GetNum2().ToString() + ")=";
        }
    }
}