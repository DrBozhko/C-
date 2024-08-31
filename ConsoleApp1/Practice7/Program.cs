namespace ConsoleApp1.Practice7;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("Contact Management System");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Delete Contact");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact(contacts);
                    break;
                case "2":
                    DeleteContact(contacts);
                    break;
                case "3":
                    SearchContact(contacts);
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddContact(Dictionary<string, string> contacts)
    {
        Console.Write("Enter contact name: ");
        string name = Console.ReadLine();
        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists.");
        }
        else
        {
            Console.Write("Enter contact phone number: ");
            string phoneNumber = Console.ReadLine();
            contacts[name] = phoneNumber;
            Console.WriteLine("Contact added successfully.");
        }
    }

    static void DeleteContact(Dictionary<string, string> contacts)
    {
        Console.Write("Enter the name of the contact to delete: ");
        string name = Console.ReadLine();
        if (contacts.Remove(name))
        {
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void SearchContact(Dictionary<string, string> contacts)
    {
        Console.Write("Enter the name of the contact to search: ");
        string name = Console.ReadLine();
        if (contacts.TryGetValue(name, out string phoneNumber))
        {
            Console.WriteLine($"Contact found: {name} - {phoneNumber}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}