using System.Globalization;
using System.Runtime.CompilerServices;

namespace Modul3HW2
{
    internal class Program
    {
        internal static void Main()
        {
            Service service = new Service();
            CultureInfo cultureUA = new CultureInfo("uk-UA");
            CultureInfo cultureEN = new CultureInfo("en-US");
            CultureInfo cultureFr = new CultureInfo("fr-FR");
            service.AddContacToPhoneBook(new Contact() { Name = "edya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "/Pitya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "Petya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "Putya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "Федір", Surname = "укпкурп", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "1214", Surname = "укпкурп", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "Федір", Surname = "укпкурп", PhoneNumber = "0324032457821" });
            service.AddContacToPhoneBook(new Contact() { Name = "йвцвйдір", Surname = "укпкурп", PhoneNumber = "0324032457821" });
            service.GetPhonBook(cultureFr);
        }
    }
}