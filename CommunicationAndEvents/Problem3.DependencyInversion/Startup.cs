using System;
using Problem3.DependencyInversion.Contracts;
using Problem3.DependencyInversion.Strategies;

namespace Problem3.DependencyInversion
{

    public class Startup
    {
        public static void Main()
        {
            var calculator = new PrimitiveCalculator();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArgs = input.Split();
                if (inputArgs[0] == "mode")
                {
                    switch (inputArgs[1][0])
                    {
                        case '/':
                            IStrategy division = new DivisionStrategy();
                            calculator.changeStrategy(division);
                            break;
                        case '*':
                            IStrategy multiply = new MultiplicationStrategy();
                            calculator.changeStrategy(multiply);
                            break;
                        case '-':
                            IStrategy subtraction = new SubtractionStrategy();
                            calculator.changeStrategy(subtraction);
                            break;
                        case '+':
                            IStrategy addition = new AdditionStrategy();
                            calculator.changeStrategy(addition);
                            break;
                        default:
                            throw new InvalidOperationException("None operator!");
                    }
                }
                else
                {
                    int firstOperand = int.Parse(inputArgs[0]);
                    int secondOperand = int.Parse(inputArgs[1]);
                    int result = calculator.PerformCalculation(firstOperand, secondOperand);
                    Console.WriteLine(result);
                }
                input = Console.ReadLine();
            }
        }
    }
}