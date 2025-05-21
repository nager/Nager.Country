using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iceland
    /// </summary>
    public class IcelandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Iceland";
        /// <inheritdoc/>
        public string OfficialName => "Iceland";
        /// <inheritdoc/>
        public string NativeName => "Ísland";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IS;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ISL;
        /// <inheritdoc/>
        public int NumericCode => 352;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".is" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new IskCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "354" };
    }
}
