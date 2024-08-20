using System;
using System.Linq;

namespace Nager.Country.Translation
{
    /// <summary>
    /// CountryProvider Extension
    /// </summary>
    public static class CountryProviderExtension
    {
        private static readonly Lazy<TranslationProvider> TranslationProvider = new Lazy<TranslationProvider>();

        ///<inheritdoc/>
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

                var countryTanslation = TranslationProvider.Value.GetCountryTranslation(country.Alpha2Code);
                if (countryTanslation.Translations.Any(translation => translation.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase)))
                {
                    return country;
                }
            }

            return null;
        }
    }
}
