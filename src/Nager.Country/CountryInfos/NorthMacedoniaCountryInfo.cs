using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// North Macedonia
    /// </summary>
    public class NorthMacedoniaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "North Macedonia";
        ///<inheritdoc/>
        public string OfficialName => "Republic of North Macedonia";
        ///<inheritdoc/>
        public string NativeName => "Северна Македонија";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MK;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MKD;
        ///<inheritdoc/>
        public int NumericCode => 807;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".mk" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BG,
            Alpha2Code.GR,
            Alpha2Code.RS,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] {new MkdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "389" };
    }
}
