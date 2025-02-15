using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class cls_CnsOperaciones
    {
        private double num1;
        private double num2;
        private string operador;

        public double GetNum1()
        {
            return num1;
        }

        public double GetNum2()
        {
            return num2;
        }

        public string GetOperador()
        {
            return operador;
        }


        public void SetNum1(double valor)
        {
            num1 = valor;
        }

        public void SetOperador(string operador)
        {
            this.operador = operador;
        }

       
        public void SetNum2(double valor)
        {
            num2 = valor;
        }

        public double OperacionesMatematicas()
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        resultado =0;
                    }
                    break;
                case "x²":
                    resultado = num1 * num1;
                    break;
            }
            return resultado;
        }
    }

}
