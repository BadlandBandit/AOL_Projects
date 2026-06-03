namespace PolymorphismAssignment;

// This class inherits from Person and implements the IQuittable interface.
public class Employee : Person, IQuittable
{
    // This property stores the employee's unique ID.
    public int Id { get; set; }

    // This override prints employee-specific details.
    public override void SayName()
    {
        // This writes the employee's full name and ID to the console.
        Console.WriteLine($"Employee: {FirstName} {LastName}, ID: {Id}");
    }

    // This explicit interface implementation can be called through an IQuittable reference.
    void IQuittable.Quit()
    {
        // This writes a quit message to the console for this employee.
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}
