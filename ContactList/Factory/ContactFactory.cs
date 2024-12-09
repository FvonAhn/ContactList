using ContactList.Models;

namespace ContactList.Factory;
public class ContactFactory
{
    public void AddContactFactory()
    {
        Console.WriteLine("Add new contact.");
        Console.ReadKey();
        Console.Write("First name: "); string addFirstName = Console.ReadLine()!;
        Console.Write("Last name: "); string addLastName = Console.ReadLine()!;
        Console.Write("Adress: "); string addAdress = Console.ReadLine()!;
        Console.Write("Email: "); string addEmail = Console.ReadLine()!;
        Console.Write("Phone number: "); string addPhone = Console.ReadLine()!;
    }
}
