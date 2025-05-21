using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    public class GuineaBissauCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guinea-Bissau";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Guinea-Bissau";
        /// <inheritdoc/>
        public string NativeName => "Guiné-Bissau";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GW;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GNB;
        /// <inheritdoc/>
        public int NumericCode => 624;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".gw" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GN,
            Alpha2Code.SN,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "245" };
    }
}
