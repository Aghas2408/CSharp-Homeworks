using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2_Calculator_using_classes_
{
    class InvalidInput : Exception
    {
        public InvalidInput()
        {
            Console.WriteLine("Invalid Input.Please try again");
        }
    }

    class Validator
    {
       
        private char optr;
        private readonly char[] delimiterChars = { '-', '+', '/', '*' };
        private Double number1 , number2;
      

        public char Optr
        { 
          get
            {
                return optr;
            }
            
        }
        public Double Number1
        {
            get
            {
                return number1;
            }

        }
        public Double Number2
        {
            get
            {
                return number2;
            }

        }
        public Validator()
        {
          
        }

       public bool Test(string input)
        {
          
            string[] numbers = input.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
           
            try
            {
                if ((numbers.Length <= 1) || (numbers.Length > 2))
                {
                    throw new InvalidInput();
                }

                if (input[0] == '-')
                {
                    Double.TryParse(numbers[0], out number1);
                    number1 *= -1;
                }
                else
                {
                    Double.TryParse(numbers[0], out number1);
                }

                int x = input.IndexOfAny(delimiterChars, 1);
                optr = input[x];

                if ((input[x + 1] == '-') && (Char.IsDigit(input[x + 2])))
                {
                    Double.TryParse(numbers[1], out number2);
                    number2 *= -1;
                }
                else if (!Char.IsDigit(input[x + 1]))
                {
                    throw new InvalidInput();
                }
                else if (input.IndexOfAny(delimiterChars, x + 1) != -1)
                {
                    throw new InvalidInput();
                }
                else
                {
                    Double.TryParse(numbers[1], out number2);
                }

                if ((optr == '/') && (number2 == 0))
                {
                    throw new DivideByZeroException();
                }
                return true;


            }

            catch (InvalidInput e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                
            }



        }


    }
}
