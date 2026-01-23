using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Western Sahara
    /// </summary>
    public sealed class WesternSaharaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Western Sahara";

        /// <inheritdoc/>
        public string OfficialName => "Sahrawi Arab Democratic Republic";

        /// <inheritdoc/>
        public string NativeName => "الصحراء الغربية";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.EH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ESH;

        /// <inheritdoc/>
        public int NumericCode => 732;

        /// <inheritdoc/>
        public string[] TLD => [".eh"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.DZ,
            Alpha2Code.MR,
            Alpha2Code.MA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies =>
        [
            MadCurrency.Instance,
            DzdCurrency.Instance,
            MroCurrency.Instance,
        ];

        /// <inheritdoc/>
        public string[] CallingCodes => ["212"];
    }
}
