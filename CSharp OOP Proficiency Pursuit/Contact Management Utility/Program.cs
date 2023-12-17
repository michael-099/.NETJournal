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

    public void AddContact(string firstName, string lastName, string phoneNumber)
    {
        Contact newcontact = new Contact(firstName, lastName, phoneNumber);
        contacts.Add(newcontact);

    }
    public void Display()
    {
        if (contacts.Count > 0)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }



    }
    public void Search(string firstName)
    {
        for (int i=0; i < contacts.Count; i++)
        {
            if (contacts[i].firstName == firstName)
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
        ContactManager x=new ContactManager();
        x.AddContact("x" ,"xx" ,"111");
        x.Display();
        x.Search("x");
        


    }
}