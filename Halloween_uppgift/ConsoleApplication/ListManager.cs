using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesUI
{
    class PhoneBook
    {
        private List<Contact> Contacts { get; set; } = new List<Contact>();
        private static void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.Email}");
        }

        private static void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            Contacts.Remove(contact);
        }

        public void DisplayContact(string LastName)
        {
            var contact = Contacts.FirstOrDefault(x => x.LastName == LastName);
            if (contact == null)
            {
                Console.WriteLine("Personen finns inte");
            }
            else
            {
                Contacts.Remove(contact);
            }
        }

        public void DisplayAllContact()
        {
            DisplayContactsDetails(Contacts);
        }


        public void DisplayMatchingContacts(string searchPhrase)
        {
            // named bill
            // search ill
            var matchingContacts = Contacts.Where(x => x.FirstName.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }

        
    }
}


