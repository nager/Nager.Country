using System;
using System.Linq;

namespace Nager.Country.Translation
{
    public static class CountryProviderExtension
    {
        public static ICountryInfo GetCountryByNameConsiderTranslation(
            this ICountryProvider countryProvider,
            string countryName)
        {
            var countries = countryProvider.GetCountries();

            foreach (var country in countries)
            {
                if (country.CommonName.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                {
                    return country;
                }

                if (country.OfficialName.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                {
                    return country;
                }

                var translationProvider = new TranslationProvider();
                var countryTanslation = translationProvider.GetCountryTranslation(country.Alpha2Code);
                if (countryTanslation.Translations.Any(translation => translation.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase)))
                {
                    return country;
                }
            }

            return null;
        }
    }
}
