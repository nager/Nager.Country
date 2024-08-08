using System;
using System.Linq;

namespace Nager.Country.Translation
{
    public static class CountryProviderExtension
    {
        private static ITranslationProvider _translationProviderSingleton;
            
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

                var countryTranslation = GetTranslationProviderInstance().GetCountryTranslation(country.Alpha2Code);
                if (countryTranslation.Translations.Any(translation => translation.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase)))
                {
                    return country;
                }
            }

            return null;
        }
        
        private static ITranslationProvider GetTranslationProviderInstance()
        {
            return _translationProviderSingleton 
                   ?? (_translationProviderSingleton = new TranslationProvider());
        }
    }
}