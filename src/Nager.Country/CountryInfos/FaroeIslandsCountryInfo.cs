using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Faroe Islands
    /// </summary>
    public sealed class FaroeIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Faroe Islands";

        /// <inheritdoc/>
        public string OfficialName => "Faroe Islands";

        /// <inheritdoc/>
        public string NativeName => "Føroyar";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FRO;

        /// <inheritdoc/>
        public int NumericCode => 234;

        /// <inheritdoc/>
        public string[] TLD => [".fo"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new DkkCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["298"];
    }
}
