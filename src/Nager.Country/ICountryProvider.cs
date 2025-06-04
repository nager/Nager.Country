using System.Collections.Generic;

namespace Nager.Country
{
    /// <summary>
    /// ICountryProvider
    /// </summary>
    public interface ICountryProvider
    {
        /// <summary>
        /// Get all country informations
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICountryInfo> GetCountries();

        /// <summary>
        /// Get country by alpha2 or alpha3 code
        /// </summary>
        /// <param name="alpha2or3Code"></param>
        /// <returns></returns>
        ICountryInfo GetCountry(string alpha2or3Code);

        /// <summary>
        /// Try get country by alpha2 or alpha3 code
        /// </summary>
        /// <param name="alpha2or3Code"></param>
        /// <param name="countryInfo"></param>
        /// <returns></returns>
        bool TryGetCountry(string alpha2or3Code, out ICountryInfo? countryInfo);

        /// <summary>
        /// Get country by alpha2 code
        /// </summary>
        /// <param name="alpha2Code"></param>
        /// <returns></returns>
        ICountryInfo GetCountry(Alpha2Code alpha2Code);

        /// <summary>
        /// Get country by alpha3 code
        /// </summary>
        /// <param name="alpha3Code"></param>
        /// <returns></returns>
        ICountryInfo GetCountry(Alpha3Code alpha3Code);

        /// <summary>
        /// Get country by Name, check CommonName and OfficialName.<br/>
        /// If you also need all translations then you can install the Nuget package <see href="https://www.nuget.org/packages/Nager.Country.Translation">Nager.Country.Translation</see>
        /// </summary>
        /// <remarks>
        /// GetCountryByNameConsiderTranslation -> <see href="https://github.com/nager/Nager.Country/blob/master/src/Nager.Country.Translation/CountryProviderExtension.cs>">CountryProviderExtension</see>
        /// </remarks>
        /// <param name="countryName"></param>
        /// <returns></returns>
        ICountryInfo GetCountryByName(string countryName);
    }
}
