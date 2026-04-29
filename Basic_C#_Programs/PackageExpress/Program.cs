// Display the required welcome message as the first line of the program.
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask the user to enter the package weight.
Console.WriteLine("Please enter the package weight:");

// Read the package weight from the console, convert it to a decimal number, and store it.
decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

// Check whether the package weight is greater than the maximum allowed weight of 50.
if (packageWeight > 50)
{
    // Display the required error message when the package is too heavy to ship.
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

    // End the program immediately because the package does not meet the weight requirement.
    return;
}

// Ask the user to enter the package width.
Console.WriteLine("Please enter the package width:");

// Read the package width from the console, convert it to a decimal number, and store it.
decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter the package height.
Console.WriteLine("Please enter the package height:");

// Read the package height from the console, convert it to a decimal number, and store it.
decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter the package length.
Console.WriteLine("Please enter the package length:");

// Read the package length from the console, convert it to a decimal number, and store it.
decimal packageLength = Convert.ToDecimal(Console.ReadLine());

// Add the package width, height, and length together to get the total package dimensions.
decimal dimensionTotal = packageWidth + packageHeight + packageLength;

// Check whether the total dimensions are greater than the maximum allowed total of 50.
if (dimensionTotal > 50)
{
    // Display the required error message when the package is too large to ship.
    Console.WriteLine("Package too big to be shipped via Package Express.");

    // End the program immediately because the package does not meet the size requirement.
    return;
}

// Multiply the package height, width, and length together, multiply that result by the package weight, then divide by 100 to calculate the shipping quote.
decimal shippingQuote = packageHeight * packageWidth * packageLength * packageWeight / 100;

// Display the calculated shipping quote as a dollar amount with two decimal places.
Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote.ToString("0.00"));

// Thank the user after displaying the quote.
Console.WriteLine("Thank you!");

// Keep the console window open until the user presses Enter.
Console.ReadLine();
