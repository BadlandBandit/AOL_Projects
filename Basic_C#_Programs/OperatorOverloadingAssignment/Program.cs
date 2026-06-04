// Program.cs
// Entry point for the OperatorOverloadingAssignment console application.
// Demonstrates the overloaded == and != operators on the Employee class.

// The 'using' directive imports the namespace so we can reference Employee
// without writing the full qualified name each time.
using OperatorOverloadingAssignment;

// ============================================================
// EXAMPLE 1 — Two different employees (different Ids)
// ============================================================

// Instantiate the first Employee object using object-initializer syntax.
// The curly-brace block sets each property right after construction.
Employee emp1 = new Employee
{
    Id = 1,              // Unique identifier for this employee
    FirstName = "Alice", // First name
    LastName  = "Smith"  // Last name
};

// Instantiate a second Employee with a completely different Id and name.
Employee emp2 = new Employee
{
    Id = 2,
    FirstName = "Bob",
    LastName  = "Jones"
};

// Print both employee records to the console so we can see what we're comparing.
// ToString() is called implicitly by the interpolated string ($"...").
Console.WriteLine("=== Example 1: Two Different Employees ===");
Console.WriteLine($"  emp1: {emp1}");
Console.WriteLine($"  emp2: {emp2}");

// Use the overloaded == operator.
// This calls our custom 'operator ==' which compares Id values.
// Expected result: false, because 1 != 2.
bool areEqual = (emp1 == emp2);
Console.WriteLine($"  emp1 == emp2  →  {areEqual}");   // False

// Use the overloaded != operator (must be paired with ==).
// Expected result: true, because the Ids differ.
bool areNotEqual = (emp1 != emp2);
Console.WriteLine($"  emp1 != emp2  →  {areNotEqual}"); // True

Console.WriteLine();

// ============================================================
// EXAMPLE 2 — Same Id, different names
// ============================================================

// Create two employees that share the same Id but have different names.
// Our operator considers them equal because equality is based on Id only.
Employee emp3 = new Employee { Id = 5, FirstName = "Carol", LastName = "White" };
Employee emp4 = new Employee { Id = 5, FirstName = "David", LastName = "Black" };

Console.WriteLine("=== Example 2: Same Id, Different Names ===");
Console.WriteLine($"  emp3: {emp3}");
Console.WriteLine($"  emp4: {emp4}");

// Expected: true — both have Id = 5, so == returns true.
Console.WriteLine($"  emp3 == emp4  →  {emp3 == emp4}");

// Expected: false — since == is true, != is false.
Console.WriteLine($"  emp3 != emp4  →  {emp3 != emp4}");

Console.WriteLine();

// ============================================================
// EXAMPLE 3 — Same object reference compared to itself
// ============================================================

// When both sides of == point to the exact same object in memory,
// the Ids are obviously identical, so the operator still returns true.
Employee emp5 = new Employee { Id = 10, FirstName = "Eve", LastName = "Green" };

Console.WriteLine("=== Example 3: Same Object Reference ===");
Console.WriteLine($"  emp5: {emp5}");

// Suppress CS1718 ("comparison made to same variable") because the self-comparison
// is intentional here — we want to show that our operator handles this case correctly.
#pragma warning disable CS1718
// Expected: true — same object, same Id.
Console.WriteLine($"  emp5 == emp5  →  {emp5 == emp5}");

// Expected: false.
Console.WriteLine($"  emp5 != emp5  →  {emp5 != emp5}");
#pragma warning restore CS1718

Console.WriteLine();

// ============================================================
// EXAMPLE 4 — Null comparisons (edge cases)
// ============================================================

// The overloaded == operator handles null references gracefully.
// null == null  →  true  (both sides are null)
// emp  == null  →  false (one side has a real object)

Employee? nullEmp = null; // Explicitly null Employee reference

Console.WriteLine("=== Example 4: Null Comparisons ===");

// Create a second null reference to demonstrate null == null.
Employee? nullEmp2 = null;

// Comparing two null references — both sides are null, so == returns true.
Console.WriteLine($"  null == null  →  {nullEmp == nullEmp2}");

// Comparing a real employee to null — returns false.
Console.WriteLine($"  emp1 == null  →  {emp1 == nullEmp}");

// Comparing null to a real employee — returns false.
Console.WriteLine($"  null == emp1  →  {nullEmp == emp1}");

Console.WriteLine();

// ============================================================
// EXAMPLE 5 — Using Equals() (consistent with ==)
// ============================================================

// object.Equals() has been overridden in the Employee class so it
// agrees with the == operator.  Collections and LINQ use Equals()
// internally, so this override keeps behaviour consistent.

Console.WriteLine("=== Example 5: Equals() Method ===");

// emp1.Id = 1, emp2.Id = 2  →  not equal.
Console.WriteLine($"  emp1.Equals(emp2)  →  {emp1.Equals(emp2)}");

// emp3.Id = 5, emp4.Id = 5  →  equal.
// emp4 is a non-null Employee so the Equals call is safe here.
Console.WriteLine($"  emp3.Equals(emp4)  →  {emp3.Equals((object)emp4)}");

Console.WriteLine();

// ============================================================
// EXAMPLE 6 — Practical use: searching a list
// ============================================================

// Because == is overloaded, you can use it inside any expression,
// including LINQ queries, loops, or conditional logic.

// Build a list of employees.
List<Employee> employees = new List<Employee>
{
    new Employee { Id = 101, FirstName = "Frank",  LastName = "Hill"   },
    new Employee { Id = 102, FirstName = "Grace",  LastName = "Stone"  },
    new Employee { Id = 103, FirstName = "Hank",   LastName = "Rivers" },
};

// The employee we are searching for (same Id as the second entry).
Employee searchTarget = new Employee { Id = 102, FirstName = "Unknown", LastName = "Unknown" };

Console.WriteLine("=== Example 6: Searching a List with == ===");
Console.WriteLine($"  Looking for: {searchTarget}");

// Iterate through the list and use our overloaded == to compare.
foreach (Employee e in employees)
{
    // The == here calls our custom operator, comparing Id values only.
    if (e == searchTarget)
    {
        // Found a match — print the full record (name included).
        Console.WriteLine($"  Match found: {e}");
    }
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
