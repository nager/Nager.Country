using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Slovakia
    /// </summary>
    public sealed class SlovakiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Slovakia";

        /// <inheritdoc/>
        public string OfficialName => "Slovak Republic";

        /// <inheritdoc/>
        public string NativeName => "Slovensko";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SVK;

        /// <inheritdoc/>
        public int NumericCode => 703;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".sk" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.CZ,
            Alpha2Code.HU,
            Alpha2Code.PL,
            Alpha2Code.UA,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "421" };
    }
}
