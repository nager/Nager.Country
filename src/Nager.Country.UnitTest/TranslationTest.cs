using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.Country.Translation;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

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
                if (countryTranslation is null)
                {
                    Assert.Fail($"Missing country translation for {countryCode}");
                }

                var duplicateTranslation = countryTranslation.Translations.GroupBy(o => o.LanguageCode).Any(o => o.Count() > 1);
                Assert.IsFalse(duplicateTranslation);
            }
        }

        [TestMethod]
        public void CheckTranslationsAvailableTest()
        {
            ITranslationProvider translationProvider = new TranslationProvider();
            foreach (var countryCode in Enum.GetValues<Alpha2Code>())
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation is null)
                {
                    continue;
                }

                var translationCount = countryTranslation.Translations.Length;
                Assert.IsGreaterThan(5, translationCount, $"Missing translations for countryCode: {countryCode}");
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
        public void GetCountryTranslatedName_InvalidAlphaCode_ThrowException()
        {
            ITranslationProvider translationProvider = new TranslationProvider();

            var exception = Assert.ThrowsExactly<UnknownCountryException>(() =>
                translationProvider.GetCountryTranslatedName("XX", LanguageCode.EN));

            Assert.AreEqual("Cannot found a country for code XX", exception.Message);
        }

        [TestMethod]
        public void CheckAllCulture()
        {
            ITranslationProvider translationProvider = new TranslationProvider();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var countryCode in Enum.GetValues<Alpha2Code>())
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation is null)
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

            foreach (var countryCode in Enum.GetValues<Alpha2Code>())
            {
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation is null)
                {
                    continue;
                }

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
        public void EnglishTranslationMatchesCommonNameTest()
        {
            ICountryProvider countryProvider = new CountryProvider();
            ITranslationProvider translationProvider = new TranslationProvider();

            foreach (var countryCode in Enum.GetValues<Alpha2Code>())
            {
                var countryInfo = countryProvider.GetCountry(countryCode);
                var countryTranslation = translationProvider.GetCountryTranslation(countryCode);
                if (countryTranslation is null)
                {
                    continue;
                }

                var enTranslation = countryTranslation.Translations.FirstOrDefault(t => t.LanguageCode == LanguageCode.EN);
                if (enTranslation is null)
                {
                    continue;
                }

                Assert.AreEqual(countryInfo.CommonName, enTranslation.Name,
                    $"EN translation for {countryCode} does not match CommonName. Expected '{countryInfo.CommonName}' but got '{enTranslation.Name}'");
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

        [TestMethod]
        public void Translations_ShouldNotContainHiddenControlCharacters()
        {
            // 1. Find all classes that implement ICountryTranslation
            var translationInterfaceType = typeof(ICountryTranslation);
            var assembly = Assembly.GetAssembly(translationInterfaceType);

            if (assembly is null)
            {
                Assert.Fail("The assembly containing the translations could not be loaded.");
                return;
            }

            var translationClasses = assembly.GetTypes()
                .Where(t => translationInterfaceType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // List of unwanted, invisible characters (e.g., soft hyphens from Wikipedia copy-pastes)
            char[] forbiddenChars =
            [
                '\u00AD', // Soft Hyphen
                '\u200B', // Zero Width Space
                '\u200D', // Zero Width Joiner
                '\u2060', // Word Joiner
                '\uFEFF', // Byte Order Mark

                // Whitespace variants
                '\u180E', // Mongolian Vowel Separator (deprecated but still seen)
            ];

            foreach (var translationClass in translationClasses)
            {
                // Dynamically instantiate the translation class
                var instance = Activator.CreateInstance(translationClass) as ICountryTranslation;
                if (instance?.Translations is null)
                {
                    continue;
                }

                foreach (var translation in instance.Translations)
                {
                    // Adjust 'translation.Name' if the property name differs in your Nager.Country version
                    var text = translation.Name;

                    if (!string.IsNullOrEmpty(text))
                    {
                        // Check if any of the forbidden characters are present in the text
                        var containsForbiddenChar = text.Any(c => forbiddenChars.Contains(c));

                        if (containsForbiddenChar)
                        {
                            // MSTest aborts immediately with a detailed failure message
                            Assert.Fail($"Error in class '{translationClass.Name}' for language '{translation.LanguageCode}': " +
                                        $"The string \"{text}\" contains hidden control characters (e.g., soft hyphen).");
                        }
                    }
                }
            }
        }
    }
}
