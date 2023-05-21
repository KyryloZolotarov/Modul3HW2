using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW2
{
    internal class Service
    {
        private PhoneBook _phoneBook;
        private CultureInfo cultureUA = new CultureInfo("uk-UA");
        private CultureInfo cultureEN = new CultureInfo("en-US");
        public Service()
        {
            _phoneBook = new PhoneBook();
        }

        public void AddContacToPhoneBook(Contact contact)
        {
            var key = string.Empty;
            if (contact != null)
            {
                key = contact.Name[0].ToString();
                if (char.IsDigit(key[0]))
                {
                    key = "0-9";
                }
                else if (!char.IsLetter(key[0]) && !char.IsDigit(key[0]))
                {
                    key = "#";
                }

                key = key.ToLower();
                _phoneBook.AddToPhoneBook(key, contact);
            }
        }

        public void GetPhonBook(CultureInfo cultureInfo)
        {
            _phoneBook.DisplayPhoneBook(cultureInfo);
        }
    }
}
