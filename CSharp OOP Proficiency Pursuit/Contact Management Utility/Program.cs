using System;
using System.Collections.Generic;
namespace Contact_Management;

public class Contact
{

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string poneNumber { get; set; }
    public Contact(string firstName, string lastName, string poneNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.poneNumber = poneNumber;

    }
}
public class ContactManager
{
    public List<Contact> contacts = new List<Contact>();

    public void AddContact(string firstName, string lastName, string poneNumber)
    {
        Contact newcontact = new Contact(firstName, lastName, poneNumber);
        contacts.Add(newcontact);

    }
    public void Display()
    {
        if (contact.Count > 0)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }



    }
    public void Search(string firstName)
    {
        for (int i; i < contacts.Count; i++)
        {
            if (contact[i].firstName == firstName)
            {
                Console.WriteLine(contacts[i]);
            }
        }


    }


}
class Program
{
    public static void Main(string[] args)
    {


    }
}