using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montserrat
    /// </summary>
    public sealed class MontserratCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Montserrat";

        /// <inheritdoc/>
        public string OfficialName => "Montserrat";

        /// <inheritdoc/>
        public string NativeName => "Montserrat";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MSR;

        /// <inheritdoc/>
        public int NumericCode => 500;

        /// <inheritdoc/>
        public string[] TLD => [".ms"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XcdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1664"];
    }
}
