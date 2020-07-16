using System;

namespace Homework1
{
    class InvalidInput : Exception
    {
        public InvalidInput()
        {

            Console.WriteLine("Invalid Input.Please try again");
        }
    }
    class Program
    {


        static void Main()
        {
            Console.WriteLine("Hello.This is Calculator");
            Console.WriteLine("If you want to finish please enter  'end' ");
            Console.WriteLine("You can use ',' for float numbers and /,*,-,+ as operators.");

            while (true)
            {
                Console.WriteLine("Please enter a mathematical expression ");
                char optr;
                char[] delimiterChars = { '-', '+', '/', '*' };
                Double number1, number2, output = 0;
                try
                {
                   
                    String input = Console.ReadLine();
                    if (input == "end")
                    {
                        break;
                    }
                   
                    string[] numbers = input.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
                     
                    if ((numbers.Length <= 1) || (numbers.Length >2))
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

                    if ((input[x + 1] == '-') && (Char.IsDigit(input[x + 1])))
                    {
                        Double.TryParse(numbers[1], out number2);
                        number2 *= -1;
                    }
                    else if (!Char.IsDigit(input[x + 1]))
                    {
                        throw  new InvalidInput();
                    }
                    else if (input.IndexOfAny(delimiterChars, x+1) != -1)
                    {
                        throw new InvalidInput();
                    }
                    else
                    {
                        Double.TryParse(numbers[1], out number2);
                    }

                    if ((optr=='/') && (number2 == 0)){
                        throw new DivideByZeroException();
                    }
                }
              
                catch (InvalidInput e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;

                }



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