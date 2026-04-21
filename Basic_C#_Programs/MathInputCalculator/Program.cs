// Ask the user to type a number that will be multiplied by 50.
Console.Write("Enter a number to multiply by 50: ");

// Read the user's typed number, convert it to a decimal, multiply it by 50, and store the result.
decimal multipliedResult = Convert.ToDecimal(Console.ReadLine()) * 50;

// Print the multiplication result to the console.
Console.WriteLine("Your number multiplied by 50 is: " + multipliedResult);

// Ask the user to type a number that will have 25 added to it.
Console.Write("Enter a number to add 25 to: ");

// Read the user's typed number, convert it to a decimal, add 25, and store the result.
decimal additionResult = Convert.ToDecimal(Console.ReadLine()) + 25;

// Print the addition result to the console.
Console.WriteLine("Your number plus 25 is: " + additionResult);

// Ask the user to type a number that will be divided by 12.5.
Console.Write("Enter a number to divide by 12.5: ");

// Read the user's typed number, convert it to a decimal, divide it by 12.5, and store the result.
decimal divisionResult = Convert.ToDecimal(Console.ReadLine()) / 12.5m;

// Print the division result to the console.
Console.WriteLine("Your number divided by 12.5 is: " + divisionResult);

// Ask the user to type a number that will be compared to 50.
Console.Write("Enter a number to check if it is greater than 50: ");

// Read the user's typed number, convert it to a decimal, check whether it is greater than 50, and store true or false.
bool isGreaterThanFifty = Convert.ToDecimal(Console.ReadLine()) > 50;

// Print the true or false comparison result to the console.
Console.WriteLine("Your number is greater than 50: " + isGreaterThanFifty);

// Ask the user to type a whole number that will be divided by 7 to find the remainder.
Console.Write("Enter a whole number to divide by 7 and find the remainder: ");

// Read the user's typed whole number, convert it to a long integer, divide it by 7 with the modulus operator, and store the remainder.
long remainderResult = Convert.ToInt64(Console.ReadLine()) % 7;

// Print the remainder result to the console.
Console.WriteLine("The remainder after dividing your number by 7 is: " + remainderResult);

// Keep the console window open until the user presses Enter.
Console.ReadLine();
