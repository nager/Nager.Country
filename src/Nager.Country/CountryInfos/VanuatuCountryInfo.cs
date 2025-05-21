using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vanuatu
    /// </summary>
    public class VanuatuCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Vanuatu";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Vanuatu";
        /// <inheritdoc/>
        public string NativeName => "Vanuatu";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VU;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VUT;
        /// <inheritdoc/>
        public int NumericCode => 548;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".vu" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new VuvCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "678" };
    }
}
