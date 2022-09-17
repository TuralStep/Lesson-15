using System.Collections.Specialized;

namespace Lesson_15;

class Program
{

    public static Doctor pediatir1 = new("Mia", "Yang", 2);
    public static Doctor pediatir2 = new("Joanna", "Smith", 4);
    public static Doctor pediatir3 = new("Leonie", "Green", 1);

    public static Doctor travmatoloq1 = new("Ashley", "Miller", 10);
    public static Doctor travmatoloq2 = new("Peter", "White", 4);

    public static Doctor stamatoloq1 = new("Melody", "Clark", 6);
    public static Doctor stamatoloq2 = new("Ruby", "Yang", 3);
    public static Doctor stamatoloq3 = new("Bob", "Lee", 1);
    public static Doctor stamatoloq4 = new("Angel", "Hill", 5);

    public static void pediatirlar()
    {
        string msg = "";
        Console.Clear();
        Console.WriteLine("----------Pediatirlar----------");
        Console.WriteLine($"1) {pediatir1}");
        Console.WriteLine($"2) {pediatir2}");
        Console.WriteLine($"3) {pediatir3}\n{msg}");

        Console.Write("Your choise : ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                showTimes(pediatir1);
                break;
            case "2":
                showTimes(pediatir2);
                break;
            case "3":
                showTimes(pediatir3);
                break;
            default:
                msg = "Invalid input...";
                pediatirlar();
                break;
        }

    }

    public static void travmatoloqlar()
    {
        string msg = "";
        Console.Clear();
        Console.WriteLine("----------Travmatoloqlar----------");
        Console.WriteLine($"1) {travmatoloq1}");
        Console.WriteLine($"2) {travmatoloq2}\n{msg}");

        Console.Write("Your choise : ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                showTimes(travmatoloq1);
                break;
            case "2":
                showTimes(travmatoloq2);
                break;
            default:
                msg = "Invalid input...";
                travmatoloqlar();
                break;
        }
    }

    public static void stamatoloqlar()
    {
        string msg = "";
        Console.Clear();
        Console.WriteLine("----------Stamatoloqlar----------");
        Console.WriteLine($"1) {stamatoloq1}");
        Console.WriteLine($"2) {stamatoloq2}");
        Console.WriteLine($"3) {stamatoloq3}");
        Console.WriteLine($"4) {stamatoloq4}\n{msg}");

        Console.Write("Your choise : ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                showTimes(stamatoloq1);
                break;
            case "2":
                showTimes(stamatoloq2);
                break;
            case "3":
                showTimes(stamatoloq3);
                break;
            case "4":
                showTimes(stamatoloq4);
                break;
            default:
                msg = "Invalid input...";
                stamatoloqlar();
                break;
        }
    }


    public static void showTimes(Doctor d)
    {
        string msg = "";
        List<string> times = new()
        {
            "09:00 - 11:00",
            "12:00 - 14:00",
            "15:00 - 17:00"
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"----------Dr. {d.Name}----------");
            for (int i = 0; i < 3; i++)
            {
                string reserve = "Not reserved";
                if (d.isReserved[i] == true)
                    reserve = "Reserved";
                Console.WriteLine($"{i + 1}) {times[i]} - {reserve}");
            }
            Console.WriteLine("0) Go back");

            Console.WriteLine($"\n{msg}");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    if (d.isReserved[0] == false)
                    {
                        d.isReserved[0] = true;
                        msg = "Succesfully reserved...";
                    }
                    else
                    {
                        msg = "Already reserved...";
                    }
                    break;
                case ConsoleKey.D2:
                    if (d.isReserved[1] == false)
                    {
                        d.isReserved[1] = true;
                        msg = "Succesfully reserved...";
                    }
                    else
                    {
                        msg = "Already reserved...";
                    }
                    break;
                case ConsoleKey.D3:
                    if (d.isReserved[2] == false)
                    {
                        d.isReserved[2] = true;
                        msg = "Succesfully reserved...";
                    }
                    else
                    {
                        msg = "Already reserved...";
                    }
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    return;
            }

        }

    }


    static void Main()
    {

        Console.WriteLine("----------Entering----------");

        Console.Write("Enter your name : ");
        string name = Console.ReadLine();

        Console.Write("Enter your surname : ");
        string surname = Console.ReadLine();

        Console.Write("Enter your email : ");
        string email = Console.ReadLine();

        Console.Write("Enter your phone number : ");
        string number = Console.ReadLine();

        Console.Clear();

        while (true)
        {
            string msg = "";
            Console.WriteLine("----------Hospital----------");

            Console.WriteLine("1) Pediatriya");
            Console.WriteLine("2) Travmatologiya");
            Console.WriteLine($"3) Stamotologiya\n{msg}");

            Console.Write("\nChoose your opinion : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    pediatirlar();
                    break;
                case "2":
                    travmatoloqlar();
                    break;
                case "3":
                    stamatoloqlar();
                    break;
                default:
                    msg = "Invalid input...";
                    break;
            }

        }
    }

}