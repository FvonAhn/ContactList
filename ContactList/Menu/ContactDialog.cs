namespace ContactList.Menu;
public class ContactDialog
{
    public void AddContactDialog() 
    {
        Console.WriteLine("Add new contact.");
        Console.ReadKey();
        Console.Write("First name: "); var addFirstName = Console.ReadLine()!;
        Console.Write("Last name: "); var addLastName = Console.ReadLine()!;
        Console.Write("Adress: "); var addAdress = Console.ReadLine()!;
        Console.Write("Email: "); var addEmail = Console.ReadLine()!;
        Console.Write("Phone number: "); var addPhone = Console.ReadLine()!;
    }
}
