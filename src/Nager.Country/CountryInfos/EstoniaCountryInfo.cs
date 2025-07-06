using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Estonia
    /// </summary>
    public sealed class EstoniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Estonia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Estonia";

        /// <inheritdoc/>
        public string NativeName => "Eesti";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.EE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.EST;

        /// <inheritdoc/>
        public int NumericCode => 233;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".ee" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.LV,
            Alpha2Code.RU,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "372" };
    }
}
