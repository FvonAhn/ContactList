﻿namespace ContactList.Models;
public class Contacts
{
    public string ID { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public Contacts()
    {
        ID = Guid.NewGuid().ToString();
    }
}
