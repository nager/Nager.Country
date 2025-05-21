using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Singapore
    /// </summary>
    public class SingaporeCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Singapore";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Singapore";
        /// <inheritdoc/>
        public string NativeName => "Singapore";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SG;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SGP;
        /// <inheritdoc/>
        public int NumericCode => 702;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".sg", ".新加坡", ".சிங்கப்பூர்" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new SgdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "65" };
    }
}
