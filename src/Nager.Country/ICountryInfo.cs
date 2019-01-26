namespace Nager.Country
{
    public interface ICountryInfo
    {
        string CommonName { get; }
        string OfficialName { get; }
        Translation[] Translations { get; }

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

        Region Region { get; }
        SubRegion SubRegion { get; }

        Alpha2Code[] BorderCountrys { get; }

        string[] Currencies { get; }
        string[] CallingCodes { get; }
    }
}
