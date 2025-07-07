using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    public sealed class SaintPierreAndMiquelonCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saint Pierre and Miquelon";

        /// <inheritdoc/>
        public string OfficialName => "Saint Pierre and Miquelon";

        /// <inheritdoc/>
        public string NativeName => "Saint Pierre et Miquelon";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SPM;

        /// <inheritdoc/>
        public int NumericCode => 666;

        /// <inheritdoc/>
        public string[] TLD => [".pm"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["508"];
    }
}
