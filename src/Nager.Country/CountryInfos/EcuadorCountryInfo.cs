using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ecuador
    /// </summary>
    public class EcuadorCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Ecuador";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Ecuador";
        /// <inheritdoc/>
        public string NativeName => "Ecuador";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.EC;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ECU;
        /// <inheritdoc/>
        public int NumericCode => 218;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".ec" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CO,
            Alpha2Code.PE,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "593" };
    }
}
