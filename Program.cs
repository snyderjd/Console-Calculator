using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int userSelection = -1;
            int num1 = 0;
            int num2 = 0;

            while (userSelection != 0) 
            {
                Console.WriteLine("Welcome to Calculatron 3000!");
                Console.WriteLine("1) Add two numbers");
                Console.WriteLine("2) Subtract two numbers");
                Console.WriteLine("3) Multiply two numbers");
                Console.WriteLine("4) Divide two numbers");
                Console.WriteLine("5) Square");
                Console.WriteLine("6) Square root");
                Console.WriteLine("7) Advanced");
                Console.WriteLine("0) Exit");
                Console.WriteLine();
                Console.Write("> ");

                try
                {
                    userSelection = int.Parse(Console.ReadLine());
                    Calculator calculator = new Calculator();

                    if (userSelection == 5)
                    {
                        Console.Write("Please enter a number to square: _");
                        num1 = int.Parse(Console.ReadLine());

                        int result = calculator.Square(num1);
                        Console.WriteLine($"{num1} squared is {result}");
                    }

                    if (userSelection == 6)
                    {
                        Console.Write("Please enter a number to get square root of: _");
                        num1 = int.Parse(Console.ReadLine());

                        double result = calculator.SquareRoot(num1);
                        Console.WriteLine($"The square root of {num1} is {result}.");
                    }

                    // if (userSelection == 7)
                    // {
                    //     Console.Write("Please enter a simple math formula: _");
                    //     string userInput = Console.ReadLine();
                    //     string [] splitInput = userInput.Split(" ");
                    //     num1 = int.Parse(splitInput[0]);
                    //     num2 = int.Parse(splitInput[2]);
                        
                    //     if (splitInput[1] == "+")
                    //     {
                    //         int result = calculator.AddNums(num1, num2);
                    //         Console.WriteLine($"The result of adding {num1} and {num2} is {result}.");                              }
                    //     }

                    // }
                    if (userSelection == 7)
                    {
                        Console.Write("Please enter a simple math formula: _");
                        string userInput = Console.ReadLine();
                        string [] splitInput = userInput.Split(" ");
                        num1 = int.Parse(splitInput[0]);
                        num2 = int.Parse(splitInput[2]);

                        if (splitInput[1] == "+")
                        {
                            int result = calculator.AddNums(num1, num2);
                            Console.WriteLine($"The result of adding {num1} and {num2} is {result}.");
                        }
                        else if (splitInput[1] == "-")
                        {
                            int result = calculator.AddNums(num1, num2);
                            Console.WriteLine($"The result of subtracting {num2} from {num1} is {result}.");
                        }
                        else if (splitInput[1] == "*")
                        {
                            int result = calculator.MultiplyNums(num1, num2);
                            Console.WriteLine($"The result of multiplying {num1} and {num2} is {result}.");
                        }
                        else if (splitInput[1] == "/")
                        {
                            try
                            {
                                int result = calculator.DivideNums(num1, num2);
                                Console.WriteLine($"The result of dividing {num1} by {num2} is {result}.");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine($"Unable to divide by zero.");
                            }
                        }
                    }
                        

                    if (userSelection != 0 && userSelection != 5 && userSelection != 6 && userSelection != 7)
                    {
                        Console.Write("Please enter two numbers with a space in between: _");
                        string userInput = Console.ReadLine();
                        string[] splitInput = userInput.Split(" ");
                        num1 = int.Parse(splitInput[0]);
                        num2 = int.Parse(splitInput[1]);
                    }

                    if (userSelection == 1)
                    {
                        int result = calculator.AddNums(num1, num2);
                        Console.WriteLine($"The result of adding {num1} and {num2} is {result}.");
                    }
                    else if (userSelection == 2)
                    {
                        int result = calculator.SubtractNums(num1, num2);
                        Console.WriteLine($"The result of subtracting {num2} from {num1} is {result}.");
                    }
                    else if (userSelection == 3)
                    {
                        int result = calculator.MultiplyNums(num1, num2);
                        Console.WriteLine($"The result of multiplying {num1} and {num2} is {result}.");
                    }
                    else if (userSelection == 4)
                    {
                        try
                        {
                            int result = calculator.DivideNums(num1, num2);
                            Console.WriteLine($"The result of dividing {num1} by {num2} is {result}.");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine($"Unable to divide by zero.");
                        }
                        
                    }

                }
                catch
                {
                    Console.WriteLine("Please enter numbers only!");
                }

                Console.WriteLine();
            }

        
        }
    }
}
