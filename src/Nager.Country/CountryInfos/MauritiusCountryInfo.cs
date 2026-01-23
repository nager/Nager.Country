using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mauritius
    /// </summary>
    public sealed class MauritiusCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Mauritius";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Mauritius";

        /// <inheritdoc/>
        public string NativeName => "Maurice";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MUS;

        /// <inheritdoc/>
        public int NumericCode => 480;

        /// <inheritdoc/>
        public string[] TLD => [".mu"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [MurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["230"];
    }
}
