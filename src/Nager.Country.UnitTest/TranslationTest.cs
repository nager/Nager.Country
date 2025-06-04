using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.Country.Translation;
using System;
using System.Globalization;
using System.Linq;

namespace Nager.Country.UnitTest
{
    [TestClass]
    public class TranslationTest
    {
        [TestMethod]
        public void DuplicateTranslationTest()
        {
            ITranslationProvider translationProvider = new TranslationProvider();
            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);

                var duplicateTranslation = countryTranslation.Translations.GroupBy(o => o.LanguageCode).Any(o => o.Count() > 1);
                Assert.IsFalse(duplicateTranslation);
            }
        }

        [TestMethod]
        public void CheckTranslationsAvailableTest()
        {
            ITranslationProvider translationProvider = new TranslationProvider();
            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation == null)
                {
                    continue;
                }

                var translationCount = countryTranslation.Translations.Length;
                Assert.IsTrue(translationCount > 5, $"Missing translations for countryCode: {countryCode}");
            }
        }

        [TestMethod]
        public void GetCountryTranslatedName_GermanyInEnglish_Successful()
        {
            ITranslationProvider translationProvider = new TranslationProvider();

            var translatedCountryName = translationProvider.GetCountryTranslatedName(Alpha2Code.DE, LanguageCode.EN);
            Assert.AreEqual("Germany", translatedCountryName);
        }

        [TestMethod]
        [ExpectedException(typeof(UnknownCountryException), "Cannot found a country for code XX")]
        public void GetCountryTranslatedName_InvalidAlphaCode_ThrowException()
        {
            ITranslationProvider translationProvider = new TranslationProvider();
            translationProvider.GetCountryTranslatedName("XX", LanguageCode.EN);
        }

        [TestMethod]
        public void CheckAllCulture()
        {
            ITranslationProvider translationProvider = new TranslationProvider();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation == null)
                    continue;

                var expectedLanguages = countryTranslation.Translations.Select(x => x.LanguageCode).ToList();
                foreach (var culture in cultures)
                {
                    bool expectResult = false;
                    if (Enum.TryParse(culture.TwoLetterISOLanguageName, true, out LanguageCode code))
                    {
                        expectResult = expectedLanguages.Any(x => x == code);
                    }

                    var translatedCountryName = translationProvider.GetCountryTranslatedName(countryCode, culture);
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
            ITranslationProvider translationProvider = new TranslationProvider();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var countryCode in (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code)))
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation == null)
                    continue;

                var expectedLanguages = countryTranslation.Translations.Select(x => x.LanguageCode).ToList();
                foreach (var culture in cultures)
                {
                    bool expectResult = false;
                    if (Enum.TryParse(culture.TwoLetterISOLanguageName, true, out LanguageCode code))
                    {
                        expectResult = expectedLanguages.Any(x => x == code);
                    }

                    var translatedCountryName = translationProvider.GetCountryTranslatedName(countryCode, culture, defaultLanguageCode);
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

        [TestMethod]
        public void CheckHyphenTest()
        {
            var searchValues = new string[] { "–", " - " };

            ITranslationProvider translationProvider = new TranslationProvider();

            foreach (var countryCode in Enum.GetValues<Alpha2Code>())
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation is null)
                {
                    continue;
                }

                foreach (var translation in countryTranslation.Translations)
                {
                    var x = searchValues.Select(searchValue => translation.Name.Contains(searchValue)).ToList();

                    if (searchValues.Where(searchValue => translation.Name.Contains(searchValue)).Any())
                    {
                        Assert.Fail($"Check hyphen in country:{countryCode}, {translation.Name}");
                    }
                }
            }

            foreach (var languageCode in Enum.GetValues<LanguageCode>())
            {
                var languageTranslation = translationProvider.GetLanguage(languageCode);
                if (languageTranslation is null)
                {
                    continue;
                }

                foreach (var translation in languageTranslation.Translations)
                {
                    if (searchValues.Where(searchValue => translation.Name.Contains(searchValue)).Any())
                    {
                        Assert.Fail($"Check hyphen in language:{languageCode}, {translation.Name}");
                    }
                }
            }
        }
    }
}
