using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cameroon
    /// </summary>
    public class CameroonCountryInfo : ICountryInfo
    {
        public string CommonName => "Cameroon";
        public string OfficialName => "Republic of Cameroon";
        public Alpha2Code Alpha2Code => Alpha2Code.CM;
        public Alpha3Code Alpha3Code => Alpha3Code.CMR;
        public int NumericCode => 120;
        public string[] TLD => new [] { ".cm" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CF,
            Alpha2Code.TD,
            Alpha2Code.CG,
            Alpha2Code.GQ,
            Alpha2Code.GA,
            Alpha2Code.NG,
        };

        public ICurrency[] Currencies => new [] { new XafCurrency() };
        public string[] CallingCodes => new [] { "237" };
    }
}
