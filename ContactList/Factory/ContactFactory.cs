using ContactList.Models;

namespace ContactList.Factory;
public class ContactFactory
{
    public void AddContactFactory()
    {
        bool addContactBool = true;
        var contact = new Contacts();
        while (addContactBool) 
        {
            Console.Clear();
            Console.WriteLine("Add new contact.");
            Console.WriteLine($"{"",-5}Y / N");
            string addContactAnswer = Console.ReadLine()!;

            if (addContactAnswer.ToLower() == "y")
            {
                Console.Clear();
                Console.Write("First name: "); contact.FirstName = Console.ReadLine()!;
                Console.Write("Last name: "); contact.LastName = Console.ReadLine()!;
                Console.Write("Adress: "); contact.Address = Console.ReadLine()!;
                Console.Write("Email: "); contact.Email = Console.ReadLine()!;
                Console.Write("Phone number: "); contact.Phone = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("New contact added:");
                Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                addContactBool = false;
            }
            if (addContactAnswer.ToLower() == "n")
            {
                Console.Clear();
                Console.WriteLine("No new contacts added.");
                addContactBool = false;
            }
        }
    }
}
