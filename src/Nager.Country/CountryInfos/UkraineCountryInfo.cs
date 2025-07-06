using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ukraine
    /// </summary>
    public sealed class UkraineCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Ukraine";

        /// <inheritdoc/>
        public string OfficialName => "Ukraine";

        /// <inheritdoc/>
        public string NativeName => "Україна";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.UKR;

        /// <inheritdoc/>
        public int NumericCode => 804;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".ua", ".укр" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BY,
            Alpha2Code.HU,
            Alpha2Code.MD,
            Alpha2Code.PL,
            Alpha2Code.RO,
            Alpha2Code.RU,
            Alpha2Code.SK,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new UahCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "380" };
    }
}
