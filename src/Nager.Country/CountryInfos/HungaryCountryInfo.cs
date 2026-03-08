using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Hungary
    /// </summary>
    public sealed class HungaryCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Hungary";

        /// <inheritdoc/>
        public string OfficialName => "Hungary";

        /// <inheritdoc/>
        public string NativeName => "Magyarország";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HUN;

        /// <inheritdoc/>
        public int NumericCode => 348;

        /// <inheritdoc/>
        public string[] TLD => [".hu"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AT,
            Alpha2Code.HR,
            Alpha2Code.RO,
            Alpha2Code.RS,
            Alpha2Code.SK,
            Alpha2Code.SI,
            Alpha2Code.UA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new HufCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["36"];
    }
}
