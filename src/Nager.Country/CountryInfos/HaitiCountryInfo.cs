using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Haiti
    /// </summary>
    public sealed class HaitiCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Haiti";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Haiti";

        /// <inheritdoc/>
        public string NativeName => "Haïti";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HTI;

        /// <inheritdoc/>
        public int NumericCode => 332;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".ht" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DO,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new HtgCurrency(), new UsdCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "509" };
    }
}
