using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Nager.Country.UnitTest
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

                var duplicateTranslation = countryInfo.Translations.GroupBy(o => o.LanguageCode).Any(o => o.Count() > 1);
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
                Assert.IsTrue(translationCount > 5, $"Missing translations for countryCode: {countryCode}");
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
                Assert.Fail($"Cannot found countryCode: {countryCode}");
            }
        }

        [DataTestMethod]
        [DataRow("austria")]
        [DataRow("Österreich")]
        [DataRow("Austria")]
        [DataRow("Republic of Austria")]
        [DataRow("Austrija")]
        [DataRow("Oostenrijk")]
        [DataRow("Österrike")]
        public void GetCountryByName(string countryName)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var countryInfo = countryProvider.GetCountryByName(countryName);
            Assert.AreEqual(Alpha2Code.AT, countryInfo.Alpha2Code);
        }

        [TestMethod]
        public void GetCountryTranslatedName()
        {
            ICountryProvider countryProvider = new CountryProvider();

            var translatedCountryName = countryProvider.GetCountryTranslatedName(Alpha2Code.DE, LanguageCode.EN);
            Assert.AreEqual("Germany", translatedCountryName);
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

        [TestMethod]
        public void CheckAllCulture()
        {
            ICountryProvider countryProvider = new CountryProvider();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryInfo = countryProvider.GetCountry(countryCode);
                if (countryInfo == null)
                    continue;

                var expectedLanguages = countryInfo.Translations.Select(x => x.LanguageCode).ToList();
                foreach (var culture in cultures)
                {
                    bool expectResult = false;
                    if (Enum.TryParse(culture.TwoLetterISOLanguageName, true, out LanguageCode code))
                    {
                        expectResult = expectedLanguages.Any(x => x == code);
                    }

                    var translatedCountryName = countryProvider.GetCountryTranslatedName(countryCode, culture);
                    if (expectResult && string.IsNullOrWhiteSpace(translatedCountryName))
                    {
                        Assert.Fail($"A result was expected but there was no translated country name found for {countryCode} and culture {culture.Name} (language {culture.TwoLetterISOLanguageName})");
                    }
                }
            }
        }

        [TestMethod]
        [DataRow(LanguageCode.EN)]
        [DataRow(LanguageCode.AA)]
        [DataRow(LanguageCode.DE)]
        [DataRow(LanguageCode.RU)]
        public void CheckAllCultureWithDefault(LanguageCode defaultLanguageCode)
        {
            ICountryProvider countryProvider = new CountryProvider();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryInfo = countryProvider.GetCountry(countryCode);
                if (countryInfo == null)
                    continue;

                var expectedLanguages = countryInfo.Translations.Select(x => x.LanguageCode).ToList();
                foreach (var culture in cultures)
                {
                    bool expectResult = false;
                    if (Enum.TryParse(culture.TwoLetterISOLanguageName, true, out LanguageCode code))
                    {
                        expectResult = expectedLanguages.Any(x => x == code);
                    }

                    var translatedCountryName = countryProvider.GetCountryTranslatedName(countryCode, culture, defaultLanguageCode);
                    if (expectResult && string.IsNullOrWhiteSpace(translatedCountryName))
                    {
                        Assert.Fail($"A result was expected but there was no translated country name found for {countryCode} and culture {culture.Name} (language {culture.TwoLetterISOLanguageName})");
                    }
                    else
                    {
                        expectResult = expectedLanguages.Any(x => x == defaultLanguageCode);
                        if (expectResult && string.IsNullOrWhiteSpace(translatedCountryName))
                        {
                            Assert.Fail($"A result was expected for default value but there was no translated country name found for {countryCode} and default language code {defaultLanguageCode}");
                        }
                    }
                }
            }
        }
    }
}
