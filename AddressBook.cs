using System;
using System.Collections.Generic;

namespace address_book_practice
{
    public class AddressBook
    {
        // Here we are listing a Dictionary as a property. Since Dictionaries have key/value pairs, we have to specify what TYPE we are passing in as each. We know we want the email as our key, so that's a string. And since we want all of our contact's information to appear as the value, we're just going to pass in the type Contact.
        public Dictionary<string, Contact> ContactBook { get; set; } = new Dictionary<string, Contact>();
        public void AddContact(Contact contact)
        {
            // To add a new contact to our dictionary called ContactBook, we're passing in contact.Email which is ONLY the email address, and then contact to display the full details as the value.
            ContactBook.Add(contact.Email, contact);
        }
        public Contact GetByEmail(string email)
        {
            // our method GetByEmail is a method that allows us to get all of the contact information by searching through the emails. We're returning the object in our dictionary that has the key of email.
            return ContactBook[email];
        }
    }
}