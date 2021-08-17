using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Calculator

            //Prompting for inputs and assigning variables
            Console.WriteLine("First operand: ");
            double firstVar = Console.ReadLine();
            Console.WriteLine("Operator: ");
            char operator = Console.ReadLine();
            Console.WriteLine("Second operand: ");
            double secondVar = Console.ReadLine();

            double answer;

            //Checking operator and solving appropirately
            //Assigning to answer
            if(operator=='+') answer = firstVar+secondVar; solvable = true;
            else if(operator=='-') answer = firstVar-secondVar; solvable = true;
            else if(operator=='*') answer = firstVar*secondVar; solvable = true;
            else if(operator=='/') answer = firstVar/secondVar;
            else Console.WriteLine("Error: Invalid operator");          //Printing error if bad operator

            //Printing the answer
            Console.WriteLine(firstVar + " " + operator + " " + secondVar + " = " + answer);
        }
    }
}