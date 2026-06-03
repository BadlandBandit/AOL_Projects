using PolymorphismAssignment;

// This creates a new Employee object with sample data.
Employee employee = new Employee
{
	// This sets the employee's first name.
	FirstName = "Jane",

	// This sets the employee's last name.
	LastName = "Doe",

	// This sets the employee's ID number.
	Id = 42
};

// This calls the overridden SayName method on the Employee instance.
employee.SayName();

// This uses polymorphism by storing an Employee object in an IQuittable variable.
IQuittable quittableEmployee = employee;

// This calls Quit through the interface reference.
quittableEmployee.Quit();
