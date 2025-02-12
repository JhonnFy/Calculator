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
            }
            return resultado;
        }
    }

}
