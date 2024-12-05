namespace ContactList.Menu;
internal class Menu
{
    public void MainMenu()
    {
        Console.WriteLine("Welcome!");
        Console.ReadKey();

        while (true)
        {
            MenuMessage();
        }

    }
    public void MenuMessage()
    {
        Console.Clear();
        Console.WriteLine("Choose!");
        Console.WriteLine($"{"1.",-5} List Contacts.");
        Console.WriteLine($"{"2.",-5} New Contact.");
        Console.WriteLine($"{"Q.",-5} Close Application.");
        var answer = Console.ReadLine()!;

        switch (answer.ToLower())
        {
            case "1":
                Console.WriteLine("You choose to List contacts.");
                break;
            case "2":
                Console.WriteLine("You choose to add a contact.");
                break;
            case "q":
                QuitApp();
                break;
            default:
                Console.WriteLine("You need to answer the Question with 1, 2 or Q.");
                break;
        }
        Console.ReadKey();
    }
    public void QuitApp()
    {
        Console.WriteLine("Are you sure you want to quit?");
        Console.WriteLine($"{"",-10}Y / N");
        var QuitAppAnswer = Console.ReadLine()!;

        if (QuitAppAnswer.ToLower() == "y")
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
