using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bermuda
    /// </summary>
    public sealed class BermudaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bermuda";

        /// <inheritdoc/>
        public string OfficialName => "Bermuda";

        /// <inheritdoc/>
        public string NativeName => "Bermuda";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BMU;

        /// <inheritdoc/>
        public int NumericCode => 060;

        /// <inheritdoc/>
        public string[] TLD => [".bm"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [BmdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1441"];
    }
}
