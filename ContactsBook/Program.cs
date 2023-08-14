

using contactsbook;
using System.Collections.Generic;




ContactBook book = new ContactBook();

while (true)
{
    Console.Clear();
    Console.WriteLine("****************************************************");
    Console.WriteLine("Enter your choice:\n1)Add Contact\n2)Show All\n3)search contact\n4)Update");

    Console.Write("Enter key between 1 - 2 - 3 - 4:");
    string key = Console.ReadLine();
    int keyNumber = Convert.ToInt32(key);
    Console.WriteLine("****************************************************");
    if (keyNumber == 1 || keyNumber == 2 || keyNumber == 3 || keyNumber == 4)
    {
        Console.Clear();
        switch (keyNumber)
        {
            case 1:
                ContactClass contact = book.Add();
                book.ShowOneContact(contact);

                break;
            case 2:
                book.ShowAllContacts();
                break;

            case 3:
                book.SearchContact();

                break;
            case 4:
                book.ShowAllContacts();
                Console.WriteLine("_______________________________________________________________");
                book.update();

                break;
            default:
                Console.WriteLine("end go back to menu");
                break;
        }
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("!!! Please enter number between 1 and 2 and 3  and 4!!!");
        Console.ReadKey();    

    }
}






