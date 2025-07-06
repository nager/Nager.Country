using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Martin
    /// </summary>
    public sealed class SaintMartinCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saint Martin";

        /// <inheritdoc/>
        public string OfficialName => "Saint Martin";

        /// <inheritdoc/>
        public string NativeName => "Saint Martin";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MF;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MAF;

        /// <inheritdoc/>
        public int NumericCode => 663;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".fr", ".gp" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SX,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "590" };
    }
}
