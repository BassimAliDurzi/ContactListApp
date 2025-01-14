using System.Text.RegularExpressions;
using Business.Factories;
using Business.Interfaces;

namespace ConsoleApp.Dialogs;

public class MenuDialogs(IContactService contactService)
{
    private readonly IContactService _contactService = contactService;


    public void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("*** Menu Options ***");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("9. Exit");
            Console.Write("\nChoose your option: ");

            var option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    AddContactOption();
                    break;

                case "2":
                    ViewAllContactsOption();
                    break;

                case "9":
                    ExitApp();
                    break;

                default:
                    ChooseValidOptin();
                    break;
            }
        }
    }

    public void AddContactOption()
    {
        var form = ContactFactory.Create();

        Console.Clear();
        Console.WriteLine("*** New Contact ***");

        form.FirstName = ValidateName("First Name");
        form.LastName = ValidateName("Last Name");
        form.Email = ValidateEmail("Email");
        form.PhoneNumber = ValidatePhoneNumber("Phone Number");
        form.Street = ValidateStreet("Street");
        form.PostalCode = ValidatePostalCode("Postal Code");
        form.City = ValidateName("City");

        var result = _contactService.Create(form);

        if (result)
        {
            Console.WriteLine("Contact was created successfully.");
        }
        else
        {
            Console.WriteLine("Contact was not created.");
        }

        Console.ReadKey();
    }

    public void ViewAllContactsOption()
    {
        Console.Clear();
        Console.WriteLine("*** All Contacts ***");
        Console.WriteLine("");

        var contacts = _contactService.GetAll();

        if(contacts.Count() == 0) Console.WriteLine("The list is empty.");

        int count = 0;
        foreach (var contact in contacts)
        {
            count++;
            Console.WriteLine($"Contact: {count}" +
                $"\n " +
                $"\n{contact.FullName}" +
                $"\n{contact.ContactInfo}" +
                $"\n{contact.Street}, {contact.PostalCode} {contact.City}" +
                $"\n-------------------------------------------------------");
        }

        Console.ReadKey();
    }


    public static void ChooseValidOptin()
    {
        Console.Clear();
        Console.WriteLine("Invalid option. Please try again.");
        Console.ReadKey();
    }

    public static void ExitApp()
    {
        Console.WriteLine("Exting...");
        Environment.Exit(0);
    }

    private static string ValidateName(string fieldName)
    {
        while (true)
        {
            Console.Write($"{fieldName}: ");
            string input =(Console.ReadLine() ?? string.Empty).Trim();

            if(Regex.IsMatch(input, @"^[a-zA-ZåäöÅÄÖ-]+$"))
            {
                return input;
            }
            else
            {
                Console.WriteLine($"Invalid {fieldName}. Field must contain letters only.");
            }
        }
    }

    private static string ValidateEmail(string fieldName)
    {
        while (true)
        {
            Console.Write($"{fieldName}: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return input;
            }
            else
            {
                Console.WriteLine($"Invalid {fieldName}. Please enter a valid email.");
            }
        }
    }

    private static string ValidatePhoneNumber(string fieldName)
    {
        while (true)
        {
            Console.Write($"{fieldName}: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (Regex.IsMatch(input, @"^\d{10}$"))
            {
                return input;
            }
            else
            {
                Console.WriteLine($"Invalid {fieldName}. Please enter a valid telephone number (10 digits).");
            }
        }
    }

    private static string ValidateStreet(string fieldName)
    {
        while (true)
        {
            Console.Write($"{fieldName}: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (Regex.IsMatch(input, @"^[a-zA-ZåäöÅÄÖ0-9\s]+$"))
            {
                return input;
            }
            else
            {
                Console.WriteLine($"Invalid {fieldName}.");
            }
        }
    }

    private static string ValidatePostalCode(string fieldName)
    {
        while (true)
        {
            Console.Write($"{fieldName}: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (Regex.IsMatch(input, @"^\d{5}$"))
            {
                return input;
            }
            else
            {
                Console.WriteLine($"Invalid {fieldName}. Please enter a valid postal code (5 digits).");
            }
        }
    }


}
