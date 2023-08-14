using contactsbook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ContactBook
{
    public List<ContactClass> contatcs { get; set; } = new List<ContactClass>();
    public ContactClass Add()
    {
        ContactClass c = new ContactClass();
        Console.Write("Enter Name");
        c.Name = Console.ReadLine();
        Console.Write("Enter Last Name");
        c.LastName = Console.ReadLine();
        Console.Write("Enter phonnumber");
        c.PhoneNumber = Console.ReadLine();

        c.FullName = c.Name + "-" + c.LastName;

        contatcs.Add(c);
        return c;

    }
    public void ShowOneContact(ContactClass c)
    {
        Console.WriteLine($"FullName:{c.FullName} ** PhoneNumber: {c.PhoneNumber}");
    }
    public void ShowAllContacts()
    {
        foreach (ContactClass c in contatcs)
        {
            //Console.WriteLine($"FullName:{c.FullName} ** PhoneNumber: {c.PhoneNumber}");
            ShowOneContact(c);
        }

    }
    public ContactClass SearchContact()
    {
        Console.Write("shomare vared namaiid:");
        string phonenumber = Console.ReadLine();
        bool find = false;
        ContactClass contact = new ContactClass();
        for (int i = 0; i < contatcs.Count; i++)
        {
            if (phonenumber == contatcs[i].PhoneNumber)
            {
                contact = contatcs[i];
                ShowOneContact(contatcs[i]);
                find = true;
                break;
            }
        }
        if (!find)
        {
            Console.WriteLine("not found");
        }
        return contact;

    }
    public void update()
    {

        ContactClass contact = new ContactClass();
        contact = SearchContact();

        if (contact == null)
        {
            Console.WriteLine("not Found!!!!!! please try again.");
            return;
        }
        string oldphonenumber = contact.PhoneNumber;
        Console.WriteLine("please enter new phone number: ");
        contact.PhoneNumber = Console.ReadLine();

        for (int i = 0; i < contatcs.Count; i++)
        {
            if (oldphonenumber == contatcs[i].PhoneNumber)
            {
                contatcs[i].PhoneNumber = contact.PhoneNumber;
                break;
            }
        }
        Console.WriteLine($"shomare {oldphonenumber} karbar{contact.FullName} be shomare {contact.PhoneNumber} ba movafaghiyat taghir yaft.");

    }

}
  



