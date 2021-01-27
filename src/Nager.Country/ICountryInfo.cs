namespace Nager.Country
{
    /// <summary>
    /// ICountryInfo
    /// </summary>
    public interface ICountryInfo
    {
        /// <summary>
        /// CommonName
        /// </summary>
        string CommonName { get; }
        /// <summary>
        /// OfficialName
        /// </summary>
        string OfficialName { get; }

        /// <summary>
        /// ISO-3166-1 Alpha2 code
        /// </summary>
        Alpha2Code Alpha2Code { get; }
        /// <summary>
        /// ISO-3166-1 Alpha3 code
        /// </summary>
        Alpha3Code Alpha3Code { get; }
        /// <summary>
        /// ISO-3166-1 Numeric code
        /// </summary>
        int NumericCode { get; }
        /// <summary>
        /// Top Level Domain
        /// </summary>
        string[] TLD { get; }

        /// <summary>
        /// Region
        /// </summary>
        Region Region { get; }
        /// <summary>
        /// SubRegion
        /// </summary>
        SubRegion SubRegion { get; }

        /// <summary>
        /// The border countries of this country
        /// </summary>
        Alpha2Code[] BorderCountries { get; }

        /// <summary>
        /// Currency informations
        /// </summary>
        ICurrency[] Currencies { get; }
        /// <summary>
        /// CallingCodes
        /// </summary>
        string[] CallingCodes { get; }
    }
}
