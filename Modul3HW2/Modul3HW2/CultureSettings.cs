using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW2
{
    internal class CultureSettings
    {
        private List<string> alphabetEN = new List<string>();
        private List<string> alphabetUA = new List<string>();
        private CultureInfo culture = new CultureInfo("uk-UA");
        public CultureSettings()
        {
            for (int i = 0; i < 26; i++)
            {
                var letter = ((char)('a' + i)).ToString();
                alphabetEN.Add(letter);
            }

            for (int i = 0; i < 33; i++)
            {
                var letter = ((char)('а' + i)).ToString();
                alphabetUA.Add(letter);
            }

            alphabetEN.Add("0-9");
        }

        public (List<string>, List<string>, CultureInfo) GetCulture()
        {
            return (alphabetEN, alphabetUA, culture);
        }
    }
}
