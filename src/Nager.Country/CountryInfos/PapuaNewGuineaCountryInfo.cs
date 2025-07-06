using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Papua New Guinea
    /// </summary>
    public sealed class PapuaNewGuineaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Papua New Guinea";

        /// <inheritdoc/>
        public string OfficialName => "Independent State of Papua New Guinea";

        /// <inheritdoc/>
        public string NativeName => "Papua Niugini";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PNG;

        /// <inheritdoc/>
        public int NumericCode => 598;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".pg" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ID,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new PgkCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "675" };
    }
}
