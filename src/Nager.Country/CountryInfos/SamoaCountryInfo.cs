using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Samoa
    /// </summary>
    public sealed class SamoaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Samoa";

        /// <inheritdoc/>
        public string OfficialName => "Independent State of Samoa";

        /// <inheritdoc/>
        public string NativeName => "Samoa";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.WS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.WSM;

        /// <inheritdoc/>
        public int NumericCode => 882;

        /// <inheritdoc/>
        public string[] TLD => [".ws"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new WstCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["685"];
    }
}
