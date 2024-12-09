namespace ContactList.Models;
public class TheContactList
{
    private List<string> Contacts = [];

    public TheContactList() 
    {
        Contacts = new List<string>();
    }

    public void AddContact(string contacts)
    {
        Contacts.Add(contacts);
    }
}
