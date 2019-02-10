using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.Country;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nager.Date.UnitTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void DuplicateTranslationTest()
        {
            var missingCountries = new List<Alpha2Code>();

            ICountryProvider countryProvider = new CountryProvider();
            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryInfo = countryProvider.GetCountry(countryCode);
                if (countryInfo == null)
                {
                    missingCountries.Add(countryCode);
                    continue;
                }

                var duplicateTranslation = countryInfo.Translations.GroupBy(o => o.LanguageCode).Where(o => o.Count() > 1).Any();
                Assert.IsFalse(duplicateTranslation);
            }

            if (missingCountries.Count > 0)
            {
                Assert.Inconclusive(string.Join(",", missingCountries));
            }
        }

        [TestMethod]
        public void CheckTranslationsAvailableTest()
        {
            ICountryProvider countryProvider = new CountryProvider();
            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryInfo = countryProvider.GetCountry(countryCode);
                if (countryInfo == null)
                {
                    continue;
                }

                var translationCount = countryInfo.Translations.Length;
                Assert.IsTrue(translationCount > 5, $"missing translations {countryCode}");
            }
        }

        [DataTestMethod]
        [DataRow("DE")]
        [DataRow("de")]
        [DataRow("De")]
        [DataRow("dE")]
        [DataRow("DE ")]
        [DataRow(" DE")]
        public void GetCountry(string countryCode)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var countryInfo = countryProvider.GetCountry(countryCode);
            if (countryInfo == null)
            {
                Assert.Fail($"Found country not {countryCode}");
            }
        }
    }
}
