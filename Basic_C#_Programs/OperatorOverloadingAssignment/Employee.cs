// Employee.cs
// Defines the Employee class used throughout this project.

namespace OperatorOverloadingAssignment
{
    // The Employee class represents a single employee record.
    // It holds identifying information and supports equality comparison by Id.
    public class Employee
    {
        // Auto-property: stores the unique numeric identifier for this employee.
        // Each employee should have a distinct Id to distinguish them from others.
        public int Id { get; set; }

        // Auto-property: stores the employee's first name (e.g., "Jane").
        public string FirstName { get; set; } = string.Empty;

        // Auto-property: stores the employee's last name (e.g., "Doe").
        public string LastName { get; set; } = string.Empty;

        // ------------------------------------------------------------------
        // Operator Overloading
        // ------------------------------------------------------------------
        // In C#, comparison operators must be overloaded in pairs:
        //   ==  must be paired with  !=
        //   <   must be paired with  >
        //   <=  must be paired with  >=
        // Here we overload == and != so that two Employee references are
        // considered "equal" when they share the same Id value, regardless
        // of name or any other property.
        // ------------------------------------------------------------------

        // Overloads the == operator for Employee objects.
        // Returns true if both employees have the same Id; otherwise false.
        // The 'operator ==' keyword tells the compiler to use this method
        // whenever the == symbol is used between two Employee instances.
        public static bool operator ==(Employee? left, Employee? right)
        {
            // Guard against null references on either side before comparing.
            // If both references are null they are equal; if only one is null
            // they are not equal.
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;

            // The actual equality check: two employees are equal if their
            // Id values match.
            return left.Id == right.Id;
        }

        // Overloads the != operator for Employee objects.
        // Returns true if the two employees have different Id values.
        // Required by C# any time == is overloaded (they must be paired).
        public static bool operator !=(Employee? left, Employee? right)
        {
            // Reuse the == operator and negate its result to avoid
            // duplicating the comparison logic.
            return !(left == right);
        }

        // ------------------------------------------------------------------
        // Equals() and GetHashCode() overrides
        // ------------------------------------------------------------------
        // Whenever == is overloaded it is best practice to also override
        // Equals() and GetHashCode() so that the object behaves correctly
        // in collections (List<T>, Dictionary<TKey,TValue>, HashSet<T>, etc.)
        // and when compared through object references (e.g., object.Equals()).
        // ------------------------------------------------------------------

        // Overrides object.Equals() so it is consistent with the == operator.
        // Returns true when the other object is an Employee with the same Id.
        public override bool Equals(object? obj)
        {
            // Use pattern matching to safely cast obj to Employee.
            // If obj is not an Employee (or is null), the cast returns null
            // and the == operator handles the null case.
            return this == (obj as Employee);
        }

        // Overrides GetHashCode() to be consistent with Equals().
        // Objects that are "equal" must produce the same hash code.
        // Since equality is based solely on Id, the hash code is derived
        // from Id as well.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Overrides ToString() to provide a human-readable representation
        // of an Employee, useful when printing to the console or in
        // debugging sessions.
        public override string ToString()
        {
            return $"Employee {{ Id={Id}, Name={FirstName} {LastName} }}";
        }
    }
}
