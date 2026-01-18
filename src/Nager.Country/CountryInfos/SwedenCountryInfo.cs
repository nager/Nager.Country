using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sweden
    /// </summary>
    public sealed class SwedenCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Sweden";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Sweden";

        /// <inheritdoc/>
        public string NativeName => "Sverige";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SWE;

        /// <inheritdoc/>
        public int NumericCode => 752;

        /// <inheritdoc/>
        public string[] TLD => [".se"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.FI,
            Alpha2Code.NO,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [SekCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["46"];
    }
}
