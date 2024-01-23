internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        double height;

        double doubleAge;
        double roundedHeight;

        const int LEGAL_DRINKING_AGE = 21;

        Console.WriteLine("Welcome to Your Personal Information System!\r\n");

        Console.Write("Please enter your name: ");
        name = Console.ReadLine()!;


        //It prompts the user to enter their age and reads the input from
        //the standard input stream using the Console.ReadLine() method.
        //The TryParse() method is then used to convert the input string to an integer value.
        //If the input is invalid or negative, the program will display an error message and prompt the user to enter their age again
        Console.Write("Please enter your age: ");
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Invalid input! \nPlease enter your age: ");
        }

        Console.Write("Please enter your height in meters: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
        {
            Console.Write("Invalid input! \nPlease enter your height in meters: ");
        }

        //CONVERTION SECTION
        doubleAge = Convert.ToDouble(age);
        roundedHeight = Convert.ToInt32(height);

        //PERSONAL INFORMATION SECTION
        Console.WriteLine("\n\n-----------------------------------\n");
        Console.WriteLine($"" +
            $"Your Personal Details:\n" +
            $"Name: {name}\n" +
            $"Age: {age}\n" +
            $"Height: {height} meters\n");


        //AGE CHECK SECTION
        Console.WriteLine("Age Check:");
        if (age >= 18)
        {
            Console.WriteLine($"Welcome, {name}! You're eligible for additional features.\n");
        }
        else
        {
            Console.WriteLine("You are still a minor.\n");
        }


        //LEGAL AGE DRINKING VALIDATION
        Console.WriteLine("Legal Drinking Age Verification:");
        if (age >= LEGAL_DRINKING_AGE)
        {
            Console.WriteLine($"Cheers, {name}! You are legally allowed to drink.\n");
        }
        else
        {
            Console.WriteLine("Sorry, you are underage for drinking.\n");
        }

        string personalInfo = $"" +
            $"Personal Details Presentation:\n" +
            $"Your Personal Information: {name}, {age} years old, {height} meters tall.";
        Console.WriteLine(personalInfo);
        Console.Write("\n-----------------------------------\n" +
            "Thank you for using Your Personal Information System!\n\n\n");


    }
}