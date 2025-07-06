using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tunisia
    /// </summary>
    public sealed class TunisiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Tunisia";

        /// <inheritdoc/>
        public string OfficialName => "Tunisian Republic";

        /// <inheritdoc/>
        public string NativeName => "تونس";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TN;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TUN;

        /// <inheritdoc/>
        public int NumericCode => 788;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".tn" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.LY,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new TndCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "216" };
    }
}
