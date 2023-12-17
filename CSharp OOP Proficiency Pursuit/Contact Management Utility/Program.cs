using System;
using System.Collections.Generic;
namespace Contact_Management;

public class Contact
{

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }
    public Contact(string firstName, string lastName, string phoneNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;

    }
    public override string ToString()
    {
        return $"firstName:{firstName}\nlastName:{lastName}\nphoneNumber:{phoneNumber}\n\n";
    }

}
public class ContactManager
{
    public static  List<Contact> contacts = new List<Contact>();

    public static void AddContact(string firstName, string lastName, string phoneNumber)
    {
        ;
        contacts.Add( new Contact(firstName, lastName, phoneNumber));

    }
    public static void Display()
    {
        if (contacts.Count > 0)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }




    }
    public static void Search(string firstName)
    {
        for (int i = 0; i < contacts.Count; i++)
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
        ContactManager.AddContact("John", "Doe", "1234567890");
        ContactManager.AddContact("Jane", "Smith", "9876543210");
        ContactManager.AddContact("Alice", "Johnson", "5555555555");
        ContactManager.AddContact("Michael", "Brown", "1111111111");
        ContactManager.AddContact("Emily", "Davis", "2222222222");
        ContactManager.AddContact("David", "Wilson", "3333333333");
        ContactManager.AddContact("Sarah", "Miller", "4444444444");
        ContactManager.AddContact("Robert", "Anderson", "5555555555");
        ContactManager.AddContact( "Olivia", "Taylor", "6666666666");
        ContactManager.AddContact("William", "Thomas", "7777777777");


        ContactManager.Search("Olivia");
        ContactManager.Display();
       



    }
}