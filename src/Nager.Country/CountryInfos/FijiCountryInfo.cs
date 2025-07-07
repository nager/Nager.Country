using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Fiji
    /// </summary>
    public sealed class FijiCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Fiji";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Fiji";

        /// <inheritdoc/>
        public string NativeName => "Fiji";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FJ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FJI;

        /// <inheritdoc/>
        public int NumericCode => 242;

        /// <inheritdoc/>
        public string[] TLD => [".fj"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new FjdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["679"];
    }
}
