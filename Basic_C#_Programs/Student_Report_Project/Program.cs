using System;

// This namespace groups the classes in this daily report program.
namespace StudentReport
{
    // This class contains the main program logic for the daily report application.
    class Program
    {
        // This method is the entry point of the program, where execution begins.
        static void Main(string[] args)
        {
            // This line prints the required school name at the start of the program.
            Console.WriteLine("Academy of Learning Career College");

            // This line prints the required report title underneath the school name.
            Console.WriteLine("Student Daily Report.");

            // This blank line makes the console output easier for the user to read.
            Console.WriteLine();

            // This line asks the student to enter their name.
            Console.Write("What is your name? ");

            // This variable will store the student's name after a non-blank answer is entered.
            string? name = Console.ReadLine();

            // This loop keeps asking for the student's name until a non-blank answer is entered.
            while (string.IsNullOrWhiteSpace(name))
            {
                // This line tells the user the input was blank and asks for the name again.
                Console.Write("Name cannot be blank. Please enter your name: ");
                name = Console.ReadLine();
            }

            // This line asks the student which course they are currently working on.
            Console.Write("What course are you on? ");

            // This variable will store the course after a non-blank answer is entered.
            string? course = Console.ReadLine();

            // This loop keeps asking for the course until a non-blank answer is entered.
            while (string.IsNullOrWhiteSpace(course))
            {
                // This line tells the user the input was blank and asks for the course again.
                Console.Write("Course cannot be blank. Please enter your course: ");
                course = Console.ReadLine();
            }

            // This line asks the student for the page number they are currently on.
            Console.Write("What page number? ");

            // This variable will store the valid page number after the user enters a whole number.
            int pageNum;

            // This loop keeps asking for the page number until the user enters a valid integer.
            while (!int.TryParse(Console.ReadLine(), out pageNum))
            {
                // This line tells the user the input was invalid and asks them to try again.
                Console.Write("Please enter a valid whole number for the page number: ");
            }

            // This line asks whether the student needs help and tells them to answer with true or false.
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\". ");

            // This variable will store the valid true or false answer after the user enters it correctly.
            bool needHelp;

            // This loop keeps asking the question until the user enters either true or false.
            while (!bool.TryParse(Console.ReadLine(), out needHelp))
            {
                // This line tells the user the input was invalid and asks for true or false again.
                Console.Write("Invalid entry. Please type \"true\" or \"false\": ");
            }

            // This line asks the student to share any positive experiences from the day.
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics. ");

            // This variable will store the positive experience response after a non-blank answer is entered.
            string? positiveExperiences = Console.ReadLine();

            // This loop keeps asking for positive experiences until a non-blank answer is entered.
            while (string.IsNullOrWhiteSpace(positiveExperiences))
            {
                // This line tells the user the input was blank and asks for the response again.
                Console.Write("This answer cannot be blank. Please share your positive experiences: ");
                positiveExperiences = Console.ReadLine();
            }

            // This line asks the student for any additional feedback they would like to provide.
            Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");

            // This variable will store the additional feedback after a non-blank answer is entered.
            string? feedback = Console.ReadLine();

            // This loop keeps asking for feedback until a non-blank answer is entered.
            while (string.IsNullOrWhiteSpace(feedback))
            {
                // This line tells the user the input was blank and asks for the feedback again.
                Console.Write("Feedback cannot be blank. Please enter your feedback: ");
                feedback = Console.ReadLine();
            }

            // This line asks how many hours the student studied today.
            Console.Write("How many hours did you study today? ");

            // This variable will store the valid study hours after the user enters a number.
            decimal studyHoursNum;

            // This loop keeps asking for study hours until the user enters a valid number.
            while (!decimal.TryParse(Console.ReadLine(), out studyHoursNum))
            {
                // This line tells the user the input was invalid and asks them to enter the hours again.
                Console.Write("Please enter a valid number for hours studied: ");
            }

            // This blank line adds space before the final message is shown.
            Console.WriteLine();

            // This line prints the required closing message and ends the program.
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
    }
}
