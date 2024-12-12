﻿using ContactList.Models;
using System.Diagnostics.Contracts;

namespace ContactList.Dialogs;
public class MenuDialog
{
    public void MainMenu()
    {
        Console.WriteLine("Welcome!");
        Console.ReadKey();

        while (true)
        {
            MenuMessage();
        }

    }
    public void MenuMessage()
    {
        Console.Clear();
        Console.WriteLine("Choose!");
        Console.WriteLine($"{"1.",-5} List Contacts.");
        Console.WriteLine($"{"2.",-5} New Contact.");
        Console.WriteLine($"{"3.",-5} Show Latest Contact Added.");
        Console.WriteLine($"{"Q.",-5} Close Application.");
        var answer = Console.ReadLine()!;

        switch (answer.ToLower())
        {
            case "1":
                ListContacts();
                break;
            case "2":
                var AddContact = new ContactDialog();
                ContactDialog.AddContactFactory();
                break;
            case "3":
                LatestContact();
                break;
            case "q":
                QuitApp();
                break;
            default:
                Console.WriteLine("You need to answer the Question with 1, 2 or Q.");
                break;
        }
        Console.ReadKey();
    }
    public void ListContacts()
    {
        Console.Clear();
        Console.WriteLine("List of contacts:");
        foreach (var contact in TheContactList.Contacts)
            Console.WriteLine($"{contact.FirstName} {contact.LastName}, {contact.Address}, {contact.Email}, {contact.Phone}");
    }
    public void LatestContact()
    {
        if (TheContactList.Contacts.Count > 0)
        {
            var latestContact = TheContactList.Contacts.Last();
            Console.Clear();
            Console.WriteLine("Latest contact added:");
            Console.WriteLine($"{latestContact.FirstName} {latestContact.LastName}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("No contacts available");
        }
    }
    public void QuitApp()
    {
        Console.Clear();
        Console.WriteLine("Are you sure you want to quit?");
        Console.WriteLine($"{"",-11}Y / N");
        var quitAppAnswer = Console.ReadLine()!;

        if (quitAppAnswer.ToLower() == "y")
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}