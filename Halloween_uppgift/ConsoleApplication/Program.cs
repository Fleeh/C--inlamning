using Discounting;
using NamesUI;
using People;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication
{


    class Program
    {


        public static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            //Rensar upp
            Console.Clear();
            Console.WriteLine("Välkommen till Halloweenfesten!");
            Console.WriteLine("Vänligen registrera dig nedan, tryck Enter för att gå tillbaka");
            Console.WriteLine("1. Registrera en ny gäst");
            Console.WriteLine("2. Lista på gäster");
            Console.WriteLine("3. Ta bort en befintligt gäst");
            Console.WriteLine("4. Skapa en rabattkod");
            Console.WriteLine("5. tryck på 'x' för att Avsluta");
            var userInput = Console.ReadLine();
            // main-loops through menu and calls method based on choice
            var phoneBook = new PhoneBook();



            while (true)
            {

                // loop condition
                switch (userInput)
                {
                    case "1":

                        // Navigerar till att lägga till en gäst                 
                        Console.Write("Ange Förnamn : ");
                        string FirstName = Console.ReadLine();

                        Console.Write("Ange Efternamn : ");
                        string LastName = Console.ReadLine();

                        Console.Write("Ange Epostadress : ");
                        string Email = Console.ReadLine();

                        Console.Write("Ange din utklädnad : ");
                        Console.ReadLine();

                        var newContact = new Contact(FirstName, LastName, Email);
                        phoneBook.AddContact(newContact);

                        Console.WriteLine($"Välkommen till halloweenfesten {FirstName} {LastName}!");
                        Task.Delay(800).Wait();
                        Console.WriteLine("------------------------------------------------------------");
                        Task.Delay(800).Wait();
                        Console.WriteLine("Tryck på '1' för att lägga till en ny gäst");
                        Task.Delay(800).Wait();
                        Console.WriteLine("Tryck på '2' för att se lista på alla gäster");
                        Task.Delay(800).Wait();
                        Console.WriteLine("Tryck på '3' för att ta bort en gäst");

                        break;

                    case "2":
                        // Navigerar till listan  

                        Task.Delay(800).Wait();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Följande personer kommer på festen");
                        Console.WriteLine("------------------------------------------------------------");
                        Task.Delay(800).Wait();
                        phoneBook.DisplayAllContact();


                        break;

                    case "3":
                        // Navigera till att ta bort en gäst
                       
                        Console.Write("Skriv in efternamnet på personen du vill ta bort från listan : ");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);                 
                        Console.WriteLine($"Nu har {searchNumber} tagits bort från listan.");
                        

                        break;

                    case "4":
                        // Navigera till rabattkoden
                        Rabatt();
                        break;

                    case "x":
                        Console.WriteLine("Vill du verkligen avsluta programmet?");
                        Task.Delay(500).Wait();
                        Console.WriteLine("Tryck på Enter för att bekräfta!");
                        Task.Delay(500).Wait();
                        Console.ReadLine();
                        Environment.Exit(1);
                        // Navigera till Avsluta funktionen
                        return;
                }

                Task.Delay(800).Wait();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Välj ett nytt alternativ från listan");
                userInput = Console.ReadLine();


            }

            //metod
            static void Rabatt()
            {

                Console.WriteLine("Här kommer din rabattkod");
                Task.Delay(800).Wait();
                var discount1 = new Discount(Guid.NewGuid(), "discounted");
                Console.WriteLine($"{discount1.DiscountId}");
                Task.Delay(800).Wait();
                Console.WriteLine("Vem vill du skicka rabattkoden till? Skriv personens förnamn.");
                var FirstName = Console.ReadLine();
                Console.WriteLine("Du har skickat rabattkoden till : " + FirstName);
                Console.ReadKey();
            }


        }
    }
}
