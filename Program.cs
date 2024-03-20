using System;

class Calculator
{
    static void Main(string[] args)
    {
        int num1, num2;
        char operation = '\0'; 
        bool continueCalculation = true;

        Console.WriteLine(" Simple Calculator ");

        while (continueCalculation)
        {
            Console.Write("Enter first number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter a number.");
                Console.Write("Enter first number: ");
            }

            Console.Write("Enter second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a number.");
                Console.Write("Enter second number: ");
            }

            bool validOperation = false;
            while (!validOperation)
            {
                Console.Write("Enter an operation (+, -, *, /): ");
                operation = Convert.ToChar(Console.ReadLine());

                if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
                {
                    validOperation = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid operation (+, -, *, /).");
                }
            }

            int result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;
            }

            Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to continue? (Y/N): ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (char.ToUpper(choice) != 'Y')
                continueCalculation = false;
        }

        Console.WriteLine("Thank you!");
    }
}
