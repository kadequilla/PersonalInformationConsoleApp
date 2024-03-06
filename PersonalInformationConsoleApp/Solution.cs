namespace PersonalInformationConsoleApp;

public static class Solution
{
    private const int LegalDrinkingAge = 21;

    public static void Run()
    {
        int age;
        double height;


        Console.WriteLine("Welcome to Your Personal Information System!\r\n");

        Console.Write("Please enter your name: ");
        var name = Console.ReadLine()!;

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

        //CONVERSION SECTION
        var doubleAge = Convert.ToDouble(age);
        var roundedHeight = Convert.ToInt32(height);

        PrintPersonalInfo(name, age, height);
        Validations(name, age);
        PrintPersonalInfoSummary(name, age, height);
    }


    static void PrintPersonalInfo(string name, int age, double height)
    {
        Console.WriteLine("\n\n-----------------------------------\n");
        Console.WriteLine($"" +
                          $"Your Personal Details:\n" +
                          $"Name: {name}\n" +
                          $"Age: {age}\n" +
                          $"Height: {height} meters\n");
    }

    private static void PrintPersonalInfoSummary(string name, int age, double height)
    {
        var personalInfo = $"" +
                           $"Personal Details Presentation:\n" +
                           $"Your Personal Information: {name}, {age} years old, {height} meters tall.";
        Console.WriteLine(personalInfo);
        Console.Write("\n-----------------------------------\n" +
                      "Thank you for using Your Personal Information System!\n\n\n");
    }

    private static void Validations(string name, int age)
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
        if (age >= LegalDrinkingAge)
        {
            Console.WriteLine($"Cheers, {name}! You are legally allowed to drink.\n");
        }
        else
        {
            Console.WriteLine("Sorry, you are underage for drinking.\n");
        }
    }

    private static bool ValidateString(string s)
    {
        const string nums = "0123456789";

        foreach (var num in nums.ToArray())
        {
            if (s.Contains(num)) return true;
        }

        return false;
    }
}