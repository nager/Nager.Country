using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Kitts and Nevis
    /// </summary>
    public sealed class SaintKittsAndNevisCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saint Kitts and Nevis";

        /// <inheritdoc/>
        public string OfficialName => "Federation of Saint Christopher and Nevisa";

        /// <inheritdoc/>
        public string NativeName => "Saint Kitts and Nevis";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KN;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KNA;

        /// <inheritdoc/>
        public int NumericCode => 659;

        /// <inheritdoc/>
        public string[] TLD => [".kn"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XcdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1869"];
    }
}
