using ContactList.Models;

namespace ContactList.Factory;
public class ContactFactory
{
    public void AddContactFactory()
    {
        bool addContactBool = true;
        while (addContactBool) 
        {
            Console.Clear();
            Console.WriteLine("Add new contact.");
            Console.WriteLine($"{"",-5}Y / N");
            string addContactAnswer = Console.ReadLine()!;

            if (addContactAnswer.ToLower() == "y")
            {
                Console.Clear();
                Console.Write("First name: "); string addFirstName = Console.ReadLine()!;
                Console.Write("Last name: "); string addLastName = Console.ReadLine()!;
                Console.Write("Adress: "); string addAdress = Console.ReadLine()!;
                Console.Write("Email: "); string addEmail = Console.ReadLine()!;
                Console.Write("Phone number: "); string addPhone = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("New contact added.");
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
