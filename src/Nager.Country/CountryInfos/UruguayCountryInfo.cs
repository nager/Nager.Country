using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uruguay
    /// </summary>
    public class UruguayCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Uruguay";
        /// <inheritdoc/>
        public string OfficialName => "Oriental Republic of Uruguay";
        /// <inheritdoc/>
        public string NativeName => "Uruguay";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UY;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.URY;
        /// <inheritdoc/>
        public int NumericCode => 858;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".uy" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new UyuCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "598" };
    }
}
