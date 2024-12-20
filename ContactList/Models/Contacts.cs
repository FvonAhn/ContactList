﻿using System.ComponentModel.DataAnnotations;

namespace ContactList.Models;
public class Contact
{
    public string ID { get; set; } = null!;

    [Required (ErrorMessage = "First name is required.")]
    [MinLength(2, ErrorMessage = "First name need atleast two characters in length.")]
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public Contact()
    {
        ID = Guid.NewGuid().ToString();
    }
}
