using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nicaragua
    /// </summary>
    public sealed class NicaraguaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Nicaragua";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Nicaragua";

        /// <inheritdoc/>
        public string NativeName => "Nicaragua";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NI;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NIC;

        /// <inheritdoc/>
        public int NumericCode => 558;

        /// <inheritdoc/>
        public string[] TLD => [".ni"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CR,
            Alpha2Code.HN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [NioCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["505"];
    }
}
