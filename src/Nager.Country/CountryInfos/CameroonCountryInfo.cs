using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cameroon
    /// </summary>
    public class CameroonCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Cameroon";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Cameroon";
        /// <inheritdoc/>
        public string NativeName => "Cameroon";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CM;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CMR;
        /// <inheritdoc/>
        public int NumericCode => 120;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".cm" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CF,
            Alpha2Code.TD,
            Alpha2Code.CG,
            Alpha2Code.GQ,
            Alpha2Code.GA,
            Alpha2Code.NG,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XafCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "237" };
    }
}
