using System;
using System.Collections.Generic;
namespace Contact_Management;

public class Contact
{

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }
    public int age {get;set;}
    public Contact(string firstName, string lastName, string phoneNumber,int age )
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.age=age;

    }
    public override string ToString()
    {
        return $"firstName:{firstName}\nlastName:{lastName}\nphoneNumber:{phoneNumber}\nage:{age}\n\n";
    }

}
public class ContactManager
{
    public static List<Contact> contacts = new List<Contact>();

    public static void AddContact(string firstName, string lastName, string phoneNumber,int age )
    {

        contacts.Add(new Contact(firstName, lastName, phoneNumber,age));

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
        ContactManager.AddContact("John", "Doe", "1234567890",44);
        ContactManager.AddContact("Jane", "Smith", "9876543210",66);
        ContactManager.AddContact("Alice", "Johnson", "5555555555",43);
        ContactManager.AddContact("Michael", "Brown", "1111111111",54);
        ContactManager.AddContact("Emily", "Davis", "2222222222",24);
        ContactManager.AddContact("David", "Wilson", "3333333333",53);
        ContactManager.AddContact("Sarah", "Miller", "4444444444",64);
        ContactManager.AddContact("Robert", "Anderson", "5555555555",46);
        ContactManager.AddContact("Olivia", "Taylor", "6666666666",53);
        ContactManager.AddContact("William", "Thomas", "7777777777",63);
        try
        {
            Console.Write("Enter the first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter the phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter the age : ");
            int age = int.Parse(Console.ReadLine());
            ContactManager.AddContact(firstName, lastName, phoneNumber, age);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter numeric valid value for age.");
        }
        

        
        ContactManager.Search("Olivia");
        ContactManager.Display();




    }
}