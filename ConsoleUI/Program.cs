using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AddressModel> addressBook = new List<AddressModel>();
            List<PersonModel> people = new List<PersonModel>();

            string makeAnotherEntry;

            do
            {
                string firstName = UserMessages.GetAString("First Name: ");
                string lastName = UserMessages.GetAString("Last Name: ");

                string street = UserMessages.GetAString("Street: ");
                string city = UserMessages.GetAString("City: ");
                string region = UserMessages.GetAString("Region: ");
                string country = UserMessages.GetAString("Country: ");
                string zipCode = UserMessages.GetAString("ZipCode: ");

                PersonModel person = new PersonModel
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                AddressModel address = new AddressModel
                {
                    Street = street,
                    City = city,
                    Region = region,
                    Country = country,
                    ZipCode = zipCode
                };

                people.Add(person);
                addressBook.Add(address);

                makeAnotherEntry = UserMessages.GetAString("Do you want to make another entry (y/n)");

            } while (makeAnotherEntry.ToLower() == "y");

            
            foreach (AddressModel item in addressBook)
            {
                
                Console.WriteLine($"{item.Address}");
            }


            Console.ReadLine();
        }
    }
}