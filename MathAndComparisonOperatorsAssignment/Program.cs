// Print the program title to the console.
Console.WriteLine("Anonymous Income Comparison Program");

// Print a blank line to make the console output easier to read.
Console.WriteLine();

// Print the heading for the first person's information.
Console.WriteLine("Person 1");

// Ask the user to enter Person 1's hourly rate.
Console.Write("Hourly Rate: ");

// Read Person 1's hourly rate from the console, convert it to a decimal number, and store it.
decimal personOneHourlyRate = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter how many hours Person 1 works per week.
Console.Write("Hours worked per week: ");

// Read Person 1's weekly hours from the console, convert it to a decimal number, and store it.
decimal personOneHoursPerWeek = Convert.ToDecimal(Console.ReadLine());

// Print a blank line to separate Person 1's input from Person 2's input.
Console.WriteLine();

// Print the heading for the second person's information.
Console.WriteLine("Person 2");

// Ask the user to enter Person 2's hourly rate.
Console.Write("Hourly Rate: ");

// Read Person 2's hourly rate from the console, convert it to a decimal number, and store it.
decimal personTwoHourlyRate = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter how many hours Person 2 works per week.
Console.Write("Hours worked per week: ");

// Read Person 2's weekly hours from the console, convert it to a decimal number, and store it.
decimal personTwoHoursPerWeek = Convert.ToDecimal(Console.ReadLine());

// Calculate Person 1's annual salary by multiplying hourly rate by weekly hours, then by 52 weeks.
decimal personOneAnnualSalary = personOneHourlyRate * personOneHoursPerWeek * 52;

// Calculate Person 2's annual salary by multiplying hourly rate by weekly hours, then by 52 weeks.
decimal personTwoAnnualSalary = personTwoHourlyRate * personTwoHoursPerWeek * 52;

// Compare both annual salaries and store whether Person 1 makes more money than Person 2.
bool personOneMakesMore = personOneAnnualSalary > personTwoAnnualSalary;

// Print a blank line to separate the input section from the results section.
Console.WriteLine();

// Print the label for Person 1's annual salary.
Console.WriteLine("Annual salary of Person 1:");

// Print Person 1's calculated annual salary on the line below the label.
Console.WriteLine(personOneAnnualSalary);

// Print the label for Person 2's annual salary.
Console.WriteLine("Annual salary of Person 2:");

// Print Person 2's calculated annual salary on the line below the label.
Console.WriteLine(personTwoAnnualSalary);

// Print the comparison statement required by the assignment.
Console.WriteLine("Person 1 makes more money than Person 2");

// Print the true or false result of the salary comparison on the line below the statement.
Console.WriteLine(personOneMakesMore);

// Keep the console window open until the user presses Enter.
Console.ReadLine();
