using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2_Calculator_using_classes_
{
    class Calculator
    {
        private readonly Double number1, number2;
        private Double output;
        private readonly Char optr;
        public Calculator(double n1, double n2, char optr)
        {
            this.number1 = n1;
            this.number2 = n2;
            this.optr = optr;
        }

        public void Calculate()
        {
            switch (optr)
            {
                case '+':
                    {

                        output = number1 + number2;
                    }

                    break;
                case '-':
                    {

                        output = number1 - number2;
                    }

                    break;
                case '*':
                    {

                        output = number1 * number2;
                    }

                    break;
                case '/':
                    {

                        output = number1 / number2;
                    }
                    break;

            }
            Console.WriteLine(output);

        }
    }
}
