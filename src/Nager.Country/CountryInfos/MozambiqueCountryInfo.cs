using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mozambique
    /// </summary>
    public class MozambiqueCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Mozambique";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Mozambique";
        /// <inheritdoc/>
        public string NativeName => "Moçambique";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MZ;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MOZ;
        /// <inheritdoc/>
        public int NumericCode => 508;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".mz" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MW,
            Alpha2Code.ZA,
            Alpha2Code.SZ,
            Alpha2Code.TZ,
            Alpha2Code.ZM,
            Alpha2Code.ZW,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new MznCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "258" };
    }
}
