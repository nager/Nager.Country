using System.Collections.Generic;

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif

namespace Nager.Country
{
    /// <summary>
    /// CountryProvider Interface
    /// </summary>
    public interface ICountryProvider
    {
        /// <summary>
        /// Retrieves information for all available countries.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{ICountryInfo}"/> containing all country information.</returns>
        IEnumerable<ICountryInfo> GetCountries();

        /// <summary>
        /// Retrieves information for a specific country by its ISO alpha-2 or alpha-3 code.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO alpha-2 or alpha-3 code of the country.</param>
        /// <returns>The <see cref="ICountryInfo"/> corresponding to the specified code.</returns>
        /// <exception cref="UnknownCountryException">Thrown if no country matches the provided code.</exception>
        ICountryInfo GetCountry(string alpha2or3Code);

#if NETSTANDARD2_0 || NET48

        /// <summary>
        /// Attempts to retrieve country information by its ISO alpha-2 or alpha-3 code.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO alpha-2 or alpha-3 code of the country.</param>
        /// <param name="countryInfo">
        /// When this method returns, contains the <see cref="ICountryInfo"/> 
        /// for the specified code if found; otherwise, null.
        /// </param>
        /// <returns>
        /// <c>true</c> if a country matching the specified code was found; otherwise, <c>false</c>.
        /// </returns>
        bool TryGetCountry(string alpha2or3Code, out ICountryInfo? countryInfo);

#endif

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Attempts to retrieve country information by its ISO alpha-2 or alpha-3 code.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO alpha-2 or alpha-3 code of the country.</param>
        /// <param name="countryInfo">
        /// When this method returns, contains the <see cref="ICountryInfo"/> 
        /// for the specified code if found; otherwise, null.
        /// </param>
        /// <returns>
        /// <c>true</c> if a country matching the specified code was found; otherwise, <c>false</c>.
        /// </returns>
        bool TryGetCountry(string alpha2or3Code, [NotNullWhen(true)] out ICountryInfo? countryInfo);

#endif

        /// <summary>
        /// Retrieves information about a country using its ISO 3166-1 alpha-2 code.
        /// </summary>
        /// <param name="alpha2Code">The ISO alpha-2 code of the country.</param>
        /// <returns>The <see cref="ICountryInfo"/> corresponding to the specified code.</returns>
        /// <exception cref="UnknownCountryException">Thrown if no country matches the provided code.</exception>
        ICountryInfo GetCountry(Alpha2Code alpha2Code);

        /// <summary>
        /// Retrieves information about a country using its ISO 3166-1 alpha-3 code.
        /// </summary>
        /// <param name="alpha3Code">The ISO alpha-3 code of the country.</param>
        /// <returns>The <see cref="ICountryInfo"/> corresponding to the specified code.</returns>
        /// <exception cref="UnknownCountryException">Thrown if no country matches the provided code.</exception>
        ICountryInfo GetCountry(Alpha3Code alpha3Code);

        /// <summary>
        /// Get country by Name, check CommonName and OfficialName.<br/>
        /// If you also need all translations then you can install the Nuget package <see href="https://www.nuget.org/packages/Nager.Country.Translation">Nager.Country.Translation</see>
        /// </summary>
        /// <remarks>
        /// GetCountryByNameConsiderTranslation -> <see href="https://github.com/nager/Nager.Country/blob/master/src/Nager.Country.Translation/CountryProviderExtension.cs>">CountryProviderExtension</see>
        /// </remarks>
        /// <param name="countryName"></param>
        /// <returns>The <see cref="ICountryInfo"/> corresponding to the specified code.</returns>
        /// <exception cref="UnknownCountryException">Thrown if no country matches the provided code.</exception>
        ICountryInfo GetCountryByName(string countryName);
    }
}
