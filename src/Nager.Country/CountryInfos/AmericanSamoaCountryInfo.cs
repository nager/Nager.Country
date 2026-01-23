using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// American Samoa
    /// </summary>
    public sealed class AmericanSamoaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "American Samoa";

        /// <inheritdoc/>
        public string OfficialName => "American Samoa";

        /// <inheritdoc/>
        public string NativeName => "American Samoa";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ASM;

        /// <inheritdoc/>
        public int NumericCode => 016;

        /// <inheritdoc/>
        public string[] TLD => [".as"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [UsdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1684"];
    }
}
