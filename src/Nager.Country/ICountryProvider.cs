using System.Collections.Generic;
using System.Globalization;

namespace Nager.Country
{
    public interface ICountryProvider
    {
        IEnumerable<ICountryInfo> GetCountries();

        ICountryInfo GetCountry(string alpha2or3Code);
        ICountryInfo GetCountry(Alpha2Code alpha2Code);
        ICountryInfo GetCountry(Alpha3Code alpha3Code);

        ICountryInfo GetCountryByName(string countryName);

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
