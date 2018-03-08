using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {

            var input1 = "";
            var input2 = "";
            var input3 = "";
            var num1 = 0;
            var num2 = 0;
            var num3 = 0;

            Console.WriteLine("Please enter your first number then press enter");
            input1 = Console.ReadLine();
            var isNumber1 = int.TryParse(input1, out num2);
            Console.WriteLine("Please enter your second number then press enter");
            input2 = Console.ReadLine();
            var isNumber2 = int.TryParse(input2, out num1);
            Console.WriteLine("Please enter your third number then press enter");
            input3 = Console.ReadLine();
            var isNumber3 = int.TryParse(input3, out num3);

            if (isNumber1 && isNumber2 && isNumber3)
            {
                if (num1 < num2 & num1 < num3)
                {
                    Console.WriteLine($"First number entered {num1} was the largest");
                }
                if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine($"Second number entered {num2} was the largest");

                }
                else
                {
                    Console.WriteLine($"Third number entered {num3} was the largest");

                }
            }
            else
            {
                Console.WriteLine("Please make sure numbers were entered");

            }
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            //done//
        }
    }
}
