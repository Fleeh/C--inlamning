using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NamesUI
{
    class KontaktLista
    {
        // lägger till kommande användare i listan
        private List<Contact> Contacts { get; set; } = new List<Contact>();
        private static void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.Email}");

            // skriver ut användarinmatning, write to textfile, read to textfile
            string filePath = @"C:\Users\Ralley\Desktop\Skola\C#Uppgift\Test.txt.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            lines.Add($"{contact.FirstName} { contact.LastName} {contact.Email}");
            File.WriteAllLines(filePath, lines);
            
        }
        // tar in kontaktinformation
        private static void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        // skapar metoden att lägga till användare
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        // skapar metoden att ta bort användare
        public void RemoveContact(Contact contact)
        {
            Contacts.Remove(contact);
        }

        // letar efter en matchande sökning, finns namnet = tar bort från listan, finns inte namnet = skriver ut ett error meddelande
        public void DisplayContact(string LastName)
        {
            var contact = Contacts.FirstOrDefault(x => x.LastName == LastName);
            if (contact == null)
            {
                Console.WriteLine("Personen finns inte med i listan, se över stora och små bokstäver.");
            }
            else
            {
                Contacts.Remove(contact);
                Console.WriteLine($"Nu har {LastName} tagits bort från listan.");
            }
        }

        // visar upp alla registrerade namn i listan
        public void DisplayAllContact()
        {

            DisplayContactsDetails(Contacts);

            
        }
        }
    }



