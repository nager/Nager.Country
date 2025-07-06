using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vatican City
    /// </summary>
    public sealed class VaticanCityCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Vatican City";

        /// <inheritdoc/>
        public string OfficialName => "Vatican City State";

        /// <inheritdoc/>
        public string NativeName => "Stato della Città del Vaticano";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VAT;

        /// <inheritdoc/>
        public int NumericCode => 336;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".va" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IT,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "3906698", "379" };
    }
}
