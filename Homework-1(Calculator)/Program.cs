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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.This is Calculator");
            Console.WriteLine("If you want to finish please enter  'end' ");
            Console.WriteLine("You can use ',' for float numbers and /,*,-,+ as operators.");

            while (true)
            {
                try
                {

                    Console.WriteLine("Please enter a mathematical expression ");
                    String input = Console.ReadLine();
                    if (input == "end")
                    {
                        break;
                    }
                    String number1_string = "";
                    String number2_string = "";
                    Char optr = ' ';
                    if (!Char.IsDigit(input[0]))
                    {
                        throw new InvalidInput();
                    }
                    for (int i = 0; i < input.Length; i++)
                    {

                        while (Char.IsDigit(input[i]) || (input[i] == ','))
                        {
                            number1_string += input[i];
                            i++;
                            if (i == input.Length) break;
                        }




                        switch (input[i])
                        {
                            case '+':
                                {
                                    optr = '+';
                                    i++;
                                }

                                break;
                            case '-':
                                {
                                    optr = '-';
                                    i++;
                                }

                                break;
                            case '*':
                                {
                                    optr = '*';
                                    i++;
                                }

                                break;
                            case '/':
                                {
                                    optr = '/';
                                    i++;
                                }

                                break;

                        }
                        if ((!Char.IsDigit(input[i]) || (i - 1 == input.Length - 1)))
                        {
                            throw new InvalidInput();

                        }




                        if (Char.IsDigit(input[i]))
                        {
                            while (Char.IsDigit(input[i]) || (input[i] == ','))
                            {
                                number2_string += input[i];
                                i++;
                                if (i == input.Length) break;
                            }

                            if (i != input.Length)
                            {
                                throw new InvalidInput();
                            }

                        }


                    }
                    Double number1;
                    Double.TryParse(number1_string, out number1);
                    Double number2;
                    Double.TryParse(number2_string, out number2);
                    Double output = 0;
                    if (optr == '/' && number2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    switch (optr)

                    {
                        case '+': output = number1 + number2; break;
                        case '-': output = number1 - number2; break;
                        case '*': output = number1 * number2; break;
                        case '/': output = number1 / number2; break;

                    }
                    Console.WriteLine(output);
                }
                catch (InvalidInput e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }




            }
        }
    }
}