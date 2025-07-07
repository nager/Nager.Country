using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Svalbard and Jan Mayen
    /// </summary>
    public sealed class SvalbardAndJanMayenCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Svalbard and Jan Mayen";

        /// <inheritdoc/>
        public string OfficialName => "Svalbard og Jan Mayen";

        /// <inheritdoc/>
        public string NativeName => "Svalbard og Jan Mayen";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SJ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SJM;

        /// <inheritdoc/>
        public int NumericCode => 744;

        /// <inheritdoc/>
        public string[] TLD => [".sj"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new NokCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["4779"];
    }
}
