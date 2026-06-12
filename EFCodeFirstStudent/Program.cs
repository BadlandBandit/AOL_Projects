using EFCodeFirstStudent;

// Create database and add one student
using (var context = new SchoolContext())
{
    // Create database
    context.Database.EnsureCreated();

    // Create a new student
    var student = new Student
    {
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@example.com"
    };

    // Add student to context
    context.Students.Add(student);

    // Save changes to database
    context.SaveChanges();

    Console.WriteLine("Student added successfully!");
    Console.WriteLine($"Student: {student.FirstName} {student.LastName} ({student.Email})");
}
