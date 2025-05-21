using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Honduras
    /// </summary>
    public class HondurasCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Honduras";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Honduras";
        /// <inheritdoc/>
        public string NativeName => "Honduras";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HN;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HND;
        /// <inheritdoc/>
        public int NumericCode => 340;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".hn" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.SV,
            Alpha2Code.NI,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new HnlCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "504" };
    }
}
