using ContactList.Services;
using ContactList.Menu;

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
                Console.WriteLine("You choose to List contacts."); // placeholder line
                break;
            case "2":
                var AddContact = new ContactDialog();
                AddContact.AddContactDialog();
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
        Console.Clear();
        Console.WriteLine("Are you sure you want to quit?");
        Console.WriteLine($"{"",-11}Y / N");
        var quitAppAnswer = Console.ReadLine()!;

        if (quitAppAnswer.ToLower() == "y")
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
