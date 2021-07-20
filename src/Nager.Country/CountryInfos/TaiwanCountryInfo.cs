using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Taiwan
    /// </summary>
    public class TaiwanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Taiwan";
        ///<inheritdoc/>
        public string OfficialName => "Republic of China";
        ///<inheritdoc/>
        public string NativeName => "臺灣";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TW;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TWN;
        ///<inheritdoc/>
        public int NumericCode => 158;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tw", ".台湾", ".台灣" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new TwdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "886" };
    }
}
