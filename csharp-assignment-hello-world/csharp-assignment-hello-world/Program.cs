class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Display x = y^2 + 2y + 1 for y = -5 to 5");
            Console.WriteLine("3. Speed calculation");
            Console.WriteLine("4. Sphere surface and volume");
            Console.WriteLine("5. Character type check");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            if (choice == null)
            {
                Console.WriteLine("No input received. Exiting.");
                return;
            }
            switch (choice)
            {
                case "1": Calculator(); break;
                case "2": DisplayFunctionValues(); break;
                case "3": SpeedCalculation(); break;
                case "4": SphereCalculation(); break;
                case "5": CharacterTypeCheck(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice. Try again.\n"); break;
            }
        }
    }

    static void Calculator()
    {
        Console.Write("Enter first number: ");
        string? input1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input1))
        {
            Console.WriteLine("No input received for first number.");
            return;
        }
        double num1 = double.Parse(input1);

        Console.Write("Enter second number: ");
        string? input2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input2))
        {
            Console.WriteLine("No input received for second number.");
            return;
        }
        double num2 = double.Parse(input2);

        Console.Write("Enter operation (+, -, *, x, /): ");
        string? op = Console.ReadLine();
        if (op == null)
        {
            Console.WriteLine("No operation entered.");
            return;
        }
        double result = 0;
        bool valid = true;
        switch (op)
        {
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*":
            case "x": result = num1 * num2; break;
            case "/":
                if (num2 != 0) result = num1 / num2;
                else { Console.WriteLine("Cannot divide by zero."); valid = false; }
                break;
            default: Console.WriteLine("Invalid operation."); valid = false; break;
        }
        if (valid) Console.WriteLine($"Result: {result}\n");
    }

    static void DisplayFunctionValues()
    {
        Console.WriteLine("y\tx");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"{y}\t{x}");
        }
        Console.WriteLine();
    }

    static void SpeedCalculation()
    {
        Console.Write("Enter distance in kilometers: ");
        string? distanceInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(distanceInput))
        {
            Console.WriteLine("No input received for distance.");
            return;
        }
        double distance = double.Parse(distanceInput);

        Console.Write("Enter hours: ");
        string? hoursInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(hoursInput))
        {
            Console.WriteLine("No input received for hours.");
            return;
        }
        int hours = int.Parse(hoursInput);

        Console.Write("Enter minutes: ");
        string? minutesInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(minutesInput))
        {
            Console.WriteLine("No input received for minutes.");
            return;
        }
        int minutes = int.Parse(minutesInput);

        Console.Write("Enter seconds: ");
        string? secondsInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(secondsInput))
        {
            Console.WriteLine("No input received for seconds.");
            return;
        }
        int seconds = int.Parse(secondsInput);

        double totalHours = hours + minutes / 60.0 + seconds / 3600.0;
        if (totalHours == 0)
        {
            Console.WriteLine("Time cannot be zero.\n");
            return;
        }
        double kmph = distance / totalHours;
        double miles = distance * 0.621371;
        double mph = miles / totalHours;
        Console.WriteLine($"Speed: {kmph:F2} km/h, {mph:F2} miles/h\n");
    }

    static void SphereCalculation()
    {
        Console.Write("Enter radius of sphere: ");
        string? radiusInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(radiusInput))
        {
            Console.WriteLine("No input received for radius.");
            return;
        }
        double r = double.Parse(radiusInput);
        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * r * r * r;
        Console.WriteLine($"Surface area: {surface:F2}");
        Console.WriteLine($"Volume: {volume:F2}\n");
    }

    static void CharacterTypeCheck()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if ("aeiouAEIOU".IndexOf(ch) >= 0)
            Console.WriteLine("It is a vowel.\n");
        else if (char.IsDigit(ch))
            Console.WriteLine("It is a digit.\n");
        else
            Console.WriteLine("It is another symbol.\n");
    }
}


