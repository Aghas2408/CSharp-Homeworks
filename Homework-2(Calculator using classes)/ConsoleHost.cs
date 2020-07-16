using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2_Calculator_using_classes_
{
   abstract class ConsoleHost
    {
        static public  void Run()
        {
            Console.WriteLine("Hello.This is Calculator");
            Console.WriteLine("If you want to finish please enter  'end' ");
            Console.WriteLine("You can use ',' for float numbers and /,*,-,+ as operators.");
            while (true)

            {
                Console.WriteLine("Please enter a mathematical expression ");
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var Tester_obj = new Tester(input);
                Tester_obj.Test();
                var Calculator_obj = new Calculator(Tester_obj.Number1, Tester_obj.Number2, Tester_obj.Optr);
                Calculator_obj.Calculate();
            }
        }
    }
}
