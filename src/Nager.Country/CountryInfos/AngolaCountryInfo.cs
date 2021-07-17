using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Angola
    /// </summary>
    public class AngolaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Angola";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Angola";
        ///<inheritdoc/>
        public string NativeName => "Angola";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AO;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AGO;
        ///<inheritdoc/>
        public int NumericCode => 024;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ao" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CG,
            Alpha2Code.CD,
            Alpha2Code.ZM,
            Alpha2Code.NA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AoaCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "244" };
    }
}
