using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Polynesia
    /// </summary>
    public sealed class FrenchPolynesiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "French Polynesia";

        /// <inheritdoc/>
        public string OfficialName => "French Polynesia";

        /// <inheritdoc/>
        public string NativeName => "Polynésie française";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PF;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PYF;

        /// <inheritdoc/>
        public int NumericCode => 258;

        /// <inheritdoc/>
        public string[] TLD => [".pf"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XpfCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["689"];
    }
}
