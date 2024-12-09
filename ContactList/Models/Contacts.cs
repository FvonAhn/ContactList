namespace ContactList.Models;
public class Contacts
{
    public int ID { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    protected Contacts(string firstName, string lastName, string address, string email)
    {
        if (string.IsNullOrEmpty(firstName))
            throw new ArgumentException("First name field cannot be empty");
        if (string.IsNullOrEmpty(lastName))
            throw new ArgumentException("Last name field cannot be empty");
        if (string.IsNullOrEmpty(address))
            throw new ArgumentException("Adress field cannot be empty");
        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email cannot be empty");

        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Email = email;
    }
}
