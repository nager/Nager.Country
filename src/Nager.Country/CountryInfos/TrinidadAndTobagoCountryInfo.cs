using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Trinidad and Tobago
    /// </summary>
    public sealed class TrinidadAndTobagoCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Trinidad and Tobago";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Trinidad and Tobago";

        /// <inheritdoc/>
        public string NativeName => "Trinidad and Tobago";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TTO;

        /// <inheritdoc/>
        public int NumericCode => 780;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".tt" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new TtdCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "1868" };
    }
}
