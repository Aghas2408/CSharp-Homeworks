using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2_Calculator_using_classes_
{
    class Calculator
    {
        private  Double number1, number2;
        private Double output;
        private   Char optr;
        private  readonly Validator validator=new Validator();
      
         public Calculator()
        {

        }

        public void Calculate(string input)
        {
           

            if (validator.Test(input))
                {
                this.number1 = validator.Number1;
                this.number2 = validator.Number2;
                this.optr = validator.Optr;

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
}
