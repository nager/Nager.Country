using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.Country.Translation;
using System;
using System.Linq;

namespace Nager.Country.UnitTest
{
    [TestClass]
    public class CountryTest
    {
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
                Assert.Fail($"Cannot found countryCode: {countryCode}");
            }
        }

        [DataTestMethod]
        [DataRow("DE", true)]
        [DataRow("de", true)]
        [DataRow("De", true)]
        [DataRow("dE", true)]
        [DataRow("DE ", true)]
        [DataRow(" DE", true)]
        [DataRow("D1E", false)]
        public void TryGetCountry(string countryCode, bool isSuccessful)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var successful = countryProvider.TryGetCountry(countryCode, out var countryInfo);
            if (isSuccessful)
            {
                Assert.IsTrue(successful);
                Assert.IsNotNull(countryInfo);
            }
            else
            {
                Assert.IsFalse(successful);
                Assert.IsNull(countryInfo);
            }
        }

        [DataTestMethod]
        [DataRow("Austria")]
        [DataRow("Republic of Austria")]
        public void GetCountryByName(string countryName)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var countryInfo = countryProvider.GetCountryByName(countryName);
            Assert.AreEqual(Alpha2Code.AT, countryInfo.Alpha2Code);
        }

        [DataTestMethod]
        [DataRow("Austria")]
        [DataRow("Republic of Austria")]
        [DataRow("austria")]
        [DataRow("Österreich")]
        [DataRow("Austrija")]
        [DataRow("Oostenrijk")]
        [DataRow("Österrike")]
        public void GetCountryByNameConsiderTranslation(string countryName)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var countryInfo = countryProvider.GetCountryByNameConsiderTranslation(countryName);
            Assert.AreEqual(Alpha2Code.AT, countryInfo.Alpha2Code);
        }

        public void GetCountries()
        {
            ICountryProvider countryProvider = new CountryProvider();
            var countries = countryProvider.GetCountries();
            var availableCountryCodes = (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code));

            foreach (var countryCode in availableCountryCodes)
            {
                if (!countries.Any(x => x.Alpha2Code == countryCode))
                {
                    Assert.Fail($"Cannot found a CountryInfo for countryCode: {countryCode}");
                }
            }
        }
    }
}
