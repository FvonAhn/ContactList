using ContactList.Models;

namespace ContactList.Factory;
public class ContactFactory
{
    public static void AddContactFactory()
    {
        bool isTrue = true;

        while (isTrue) 
        {
            var contact = new Contact();
            Console.Clear();
            Console.Write("First name: "); contact.FirstName = Console.ReadLine()!;
            Console.Write("Last name: "); contact.LastName = Console.ReadLine()!;
            Console.Write("Adress: "); contact.Address = Console.ReadLine()!;
            Console.Write("Email: "); contact.Email = Console.ReadLine()!;
            Console.Write("Phone number: "); contact.Phone = Console.ReadLine()!;
            Console.Clear();
            Console.WriteLine("Add new contact.");
            Console.WriteLine($"{"",-5}Y / N");
            string addContactAnswer = Console.ReadLine()!;

            if (addContactAnswer.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                TheContactList.Contacts.Add(contact);
                Console.Clear();
                Console.WriteLine("New contact added:");
                Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                isTrue = false;
            }
            if (addContactAnswer.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine("No new contacts added.");
                isTrue = false;
            }
        }
    }
}
