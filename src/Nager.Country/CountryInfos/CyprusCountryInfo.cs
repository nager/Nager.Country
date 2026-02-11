using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cyprus
    /// </summary>
    public sealed class CyprusCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Cyprus";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Cyprus";

        /// <inheritdoc/>
        public string NativeName => "������";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CY;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CYP;

        /// <inheritdoc/>
        public int NumericCode => 196;

        /// <inheritdoc/>
        public string[] TLD => [".cy"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["357"];
    }
}
