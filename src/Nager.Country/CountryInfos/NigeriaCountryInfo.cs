using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nigeria
    /// </summary>
    public class NigeriaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Nigeria";
        ///<inheritdoc/>
        public string OfficialName => "Federal Republic of Nigeria";
        ///<inheritdoc/>
        public string NativeName => "Nigeria";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NG;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NGA;
        ///<inheritdoc/>
        public int NumericCode => 566;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ng" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.NE,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new NgnCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "234" };
    }
}
