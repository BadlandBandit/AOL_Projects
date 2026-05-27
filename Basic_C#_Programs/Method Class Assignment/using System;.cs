using System;

// Define a class to perform mathematical operations
class MathOperations
{
    // Void method that takes two integers as parameters
    // Performs a math operation on the first integer and displays the second integer
    public void ProcessNumbers(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (multiply by 2)
        int result = firstNumber * 2;
        
        // Display the second integer to the screen
        Console.WriteLine($"Second number: {secondNumber}");
        
        // Also display the result of the math operation for clarity
        Console.WriteLine($"First number doubled: {result}");
    }
}

// Main program entry point
class Program
{
    // Main method - the starting point of the console application
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();
        
        // Call the method with positional arguments (two numbers)
        mathOps.ProcessNumbers(5, 10);
        
        // Call the method again, specifying parameters by name
        mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 15);
    }
}
