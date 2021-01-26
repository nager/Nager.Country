using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Central African Republic
    /// </summary>
    public class CentralAfricanRepublicCountryInfo : ICountryInfo
    {
        public string CommonName => "Central African Republic";
        public string OfficialName => "Central African Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.CF;
        public Alpha3Code Alpha3Code => Alpha3Code.CAF;
        public int NumericCode => 140;
        public string[] TLD => new [] { ".cf" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.CD,
            Alpha2Code.CG,
            Alpha2Code.SS,
            Alpha2Code.SD,
        };

        public ICurrency[] Currencies => new [] { new XafCurrency() };
        public string[] CallingCodes => new [] { "236" };
    }
}
