namespace PolymorphismAssignment;

// This base class stores common person information.
public class Person
{
    // This property holds a person's first name.
    public string FirstName { get; set; } = string.Empty;

    // This property holds a person's last name.
    public string LastName { get; set; } = string.Empty;

    // This virtual method prints the person's full name and can be overridden.
    public virtual void SayName()
    {
        // This writes the full name to the console.
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}
