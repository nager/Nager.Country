using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.Country;
using System;
using System.Linq;

namespace Nager.Date.UnitTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void DuplicateTranslationTest()
        {
            ICountryProvider countryProvider = new CountryProvider();
            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryInfo = countryProvider.GetCountry(countryCode);
                if (countryInfo == null)
                {
                    continue;
                }

                var duplicateTranslation = countryInfo.Translations.GroupBy(o => o.LanguageCode).Where(o => o.Count() > 1).Any();
                Assert.IsFalse(duplicateTranslation);
            }
        }
    }
}
