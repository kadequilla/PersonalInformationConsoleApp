internal class Program
{

    const int LEGAL_DRINKING_AGE = 21;

    private static void Main(string[] args)
    {
        string name;
        int age;
        double height;

        double doubleAge;
        double roundedHeight;



        Console.WriteLine("Welcome to Your Personal Information System!\r\n");

        Console.Write("Please enter your name: ");
        name = Console.ReadLine()!;

        //if name contains 0-9 digit returns true
        while (ValidateString(name))
        {
            Console.Write("" +
                "Invalid input. Name must not contain numbers.\n" +
                "Please enter your name: ");
            name = Console.ReadLine()!;
        }




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

        PersonalInfo(name, age, height);
        Validations(name, age);
        PersonalInfoSummary(name, age, height);


    }

    static void PersonalInfo(string name, int age, double height)
    {
        Console.WriteLine("\n\n-----------------------------------\n");
        Console.WriteLine($"" +
            $"Your Personal Details:\n" +
            $"Name: {name}\n" +
            $"Age: {age}\n" +
            $"Height: {height} meters\n");
    }

    static void PersonalInfoSummary(string name, int age, double height)
    {
        string personalInfo = $"" +
       $"Personal Details Presentation:\n" +
       $"Your Personal Information: {name}, {age} years old, {height} meters tall.";
        Console.WriteLine(personalInfo);
        Console.Write("\n-----------------------------------\n" +
            "Thank you for using Your Personal Information System!\n\n\n");
    }

    static void Validations(string name, int age)
    {
        //Check if a user is eligible for additional features based on their age
        Console.WriteLine("Age Check:");
        if (age >= 18)
        {
            Console.WriteLine($"Welcome, {name}! You're eligible for additional features.\n");
        }
        else
        {
            Console.WriteLine("You are still a minor.\n");
        }

        //Verify if a user is of legal drinking age. 
        Console.WriteLine("Legal Drinking Age Verification:");
        if (age >= LEGAL_DRINKING_AGE)
        {
            Console.WriteLine($"Cheers, {name}! You are legally allowed to drink.\n");
        }
        else
        {
            Console.WriteLine("Sorry, you are underage for drinking.\n");
        }
    }

    static bool ValidateString(string s)
    {
        const string NUMS = "0123456789";

        foreach (var num in NUMS.ToArray())
        {
            if (s.Contains(num)) return true;
        }
        return false;
    }
}