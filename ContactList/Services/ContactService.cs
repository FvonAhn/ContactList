namespace ContactList.Services;
public class ContactService
{
    public int ID { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Adress { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int Phone { get; set; }
}
