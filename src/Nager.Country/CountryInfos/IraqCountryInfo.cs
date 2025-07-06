using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iraq
    /// </summary>
    public sealed class IraqCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Iraq";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Iraq";

        /// <inheritdoc/>
        public string NativeName => "العراق";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IQ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IRQ;

        /// <inheritdoc/>
        public int NumericCode => 368;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".iq" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IR,
            Alpha2Code.JO,
            Alpha2Code.KW,
            Alpha2Code.SA,
            Alpha2Code.SY,
            Alpha2Code.TR,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new IqdCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "964" };
    }
}
