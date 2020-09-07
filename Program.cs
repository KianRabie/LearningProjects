using System;
using System.Xml;

//User inputs string
//String is split into floats
//Checks what strings are floats or operators
//Input values into specified operator formula
//Outputs result

class Calculator
{
    public static void Main()
    {
        //Asks for math
        Console.WriteLine("Input MATH:");

        //Reads input
        string userInput = Console.ReadLine();

        //Splits string
        string[] inputList = userInput.Split(' ');

        var inputNum  = inputList[0];
        var operation = inputList[1];
        var inputNum2 = inputList[2];

        //Makes sure theres a valid amount of strings
        if (inputList.Length < 3)
        {
            Console.WriteLine("PLEASE adhere to # operator # format, thanks");
            Console.WriteLine();
        }
        //Turns split strings into floats
        float num1, num2;
        float.TryParse(inputNum, out num1); 
        float.TryParse(inputNum2, out num2);

        //Figures out what operator "operation" is
        float result;
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"The answer is {result}");
                break;
                
            case "-":
                result = num1 - num2;
                Console.WriteLine($"The answer is {result}");
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"The answer is {result}");
                break;

            case "/":
                result = num1 / num2;
                Console.WriteLine($"The answer is {result}");
                break;
        }
        
    }
}
 
