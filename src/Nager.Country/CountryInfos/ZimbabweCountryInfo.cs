using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Zimbabwe
    /// </summary>
    public class ZimbabweCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Zimbabwe";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Zimbabwe";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ZW;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ZWE;
        ///<inheritdoc/>
        public int NumericCode => 716;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".zw" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BW,
            Alpha2Code.MZ,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new ZwlCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "263" };
    }
}
