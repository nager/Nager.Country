using System.Collections.Generic;
using System.Globalization;

namespace Nager.Country.Translation
{
    /// <summary>
    /// Translation Provider Interface
    /// </summary>
    public interface ITranslationProvider
    {
        IEnumerable<ILanguageTranslation> GetLanguages();

        ILanguageTranslation GetLanguage(string languageCode);
        ILanguageTranslation GetLanguage(LanguageCode languageCode);

        ICountryTranslation GetCountryTranslation(Alpha2Code alpha2Code);

        string GetCountryTranslatedName(string alpha2or3Code, LanguageCode languageCode);
        string GetCountryTranslatedName(Alpha2Code alpha2Code, LanguageCode languageCode);
        string GetCountryTranslatedName(Alpha3Code alpha3Code, LanguageCode languageCode);

        string GetCountryTranslatedName(string alpha2or3Code, string languageCode);
        string GetCountryTranslatedName(Alpha2Code alpha2Code, string languageCode);
        string GetCountryTranslatedName(Alpha3Code alpha3Code, string languageCode);

        string GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture);
        string GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture);
        string GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture);

        string GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture, LanguageCode defaultLanguageCode);
        string GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture, LanguageCode defaultLanguageCode);
        string GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture, LanguageCode defaultLanguageCode);
    }
}
