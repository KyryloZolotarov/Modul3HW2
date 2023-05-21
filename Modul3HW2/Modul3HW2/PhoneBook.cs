using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW2
{
    internal class PhoneBook
    {
        private SortedDictionary<string, List<Contact>> _phoneBook = new SortedDictionary<string, List<Contact>>();
        private List<string> alphabetEN = new List<string>();
        private List<string> alphabetUA = new List<string>();
        private CultureInfo cultureUA;

        internal PhoneBook()
        {
            (alphabetEN, alphabetUA, cultureUA) = new CultureSettings().GetCulture();
            foreach (var letter in alphabetEN)
            {
                _phoneBook.Add(letter, new List<Contact>());
            }

            foreach (var letter in alphabetUA)
            {
                _phoneBook.Add(letter, new List<Contact>());
            }

            alphabetUA.Add("0-9");
            _phoneBook.Add("#", new List<Contact>());
        }

        public void AddToPhoneBook(string key, Contact value)
        {
            if (_phoneBook.ContainsKey(key))
            {
                _phoneBook[key].Add(value);
            }
        }

        public void DisplayPhoneBook(CultureInfo curentCulture)
        {
            if (curentCulture.Equals(cultureUA))
            {
                LogicOfDicplay(alphabetUA);
            }
            else
            {
                LogicOfDicplay(alphabetEN);
            }
        }

        private void LogicOfDicplay(List<string> alphabet)
        {
            foreach (KeyValuePair<string, List<Contact>> kvp in _phoneBook)
            {
                if (kvp.Value.Count > 0)
                {
                    if (alphabet.Contains(kvp.Key))
                    {
                        Console.WriteLine($"{kvp.Key}");
                        kvp.Value.Sort();
                        foreach (Contact contact in kvp.Value)
                        {
                            Console.WriteLine($" - {contact.Name} {contact.Surname} {contact.PhoneNumber}");
                        }
                    }
                }
            }

            Console.WriteLine("#");
            foreach (KeyValuePair<string, List<Contact>> kvp in _phoneBook)
            {
                if (kvp.Value.Count > 0)
                {
                    if (!alphabet.Contains(kvp.Key))
                    {
                        kvp.Value.Sort();
                        foreach (Contact contact in kvp.Value)
                        {
                            Console.WriteLine($" - {contact.Name} {contact.Surname} {contact.PhoneNumber}");
                        }
                    }
                }
            }
        }
    }
}
