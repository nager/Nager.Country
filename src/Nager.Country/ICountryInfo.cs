namespace Nager.Country
{
    /// <summary>
    /// Provides standardized information about a country based on ISO 3166.
    /// </summary>
    public interface ICountryInfo
    {
        /// <summary>
        /// Gets the commonly used English name of the country.
        /// </summary>
        string CommonName { get; }

        /// <summary>
        /// Gets the official full name of the country.
        /// </summary>
        string OfficialName { get; }

        /// <summary>
        /// Gets the native name of the country in its local language.
        /// </summary>
        string NativeName { get; }

        /// <summary>
        /// Gets a URL- and system-friendly identifier (lowercase, ASCII, hyphen-separated).
        /// </summary>
        /// <example>aland-islands</example>
        string Slug { get; }

        /// <summary>
        /// Gets the ISO 3166-1 alpha-2 country code.
        /// </summary>
        Alpha2Code Alpha2Code { get; }

        /// <summary>
        /// Gets the ISO 3166-1 alpha-3 country code.
        /// </summary>
        Alpha3Code Alpha3Code { get; }

        /// <summary>
        /// Gets the ISO 3166-1 numeric country code.
        /// </summary>
        int NumericCode { get; }

        /// <summary>
        /// Gets the top-level domain(s) assigned to the country (e.g. ".at").
        /// </summary>
        string[] TLD { get; }

        /// <summary>
        /// Gets the geographic region of the country.
        /// </summary>
        Region Region { get; }

        /// <summary>
        /// Gets the geographic subregion of the country.
        /// </summary>
        SubRegion SubRegion { get; }

        /// <summary>
        /// Gets the neighboring countries defined by their ISO 3166-1 alpha-2 codes.
        /// </summary>
        Alpha2Code[] BorderCountries { get; }

        /// <summary>
        /// Gets the currencies used in the country.
        /// </summary>
        ICurrency[] Currencies { get; }

        /// <summary>
        /// Gets the international calling codes of the country (e.g. "+43").
        /// </summary>
        string[] CallingCodes { get; }
    }
}
