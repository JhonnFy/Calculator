﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Calculator
{
    public class cls_CnsOperations
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

        public string GetOperator()
        {
            return operador;
        }


        public void SetNum1(double valor)
        {
            num1 = valor;
        }

        public void SetOperator(string operador)
        {
            this.operador = operador;
        }

       
        public void SetNum2(double valor)
        {
            num2 = valor;
        }

        public double MathematicalOperations()
        {
            double result = 0;

            switch (operador)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        result =0;
                    }
                    break;
                case "x²":
                    result = num1 * num1;
                    break;
                case "2√x":
                    result = Math.Sqrt(num1);
                    break;
                case "1/x":
                    result = 1 / num1;
                        break;
                case "‰":
                    result = num1 / 1000;
                    break;
            }
            return result;
        }
    }

}
