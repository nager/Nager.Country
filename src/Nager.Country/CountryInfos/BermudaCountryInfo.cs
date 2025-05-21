using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bermuda
    /// </summary>
    public class BermudaCountryInfo : ICountryInfo
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
        public string[] TLD => new [] { ".bm" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new BmdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "1441" };
    }
}
