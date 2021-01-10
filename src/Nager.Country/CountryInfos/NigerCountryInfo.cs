using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Niger
    /// </summary>
    public class NigerCountryInfo : ICountryInfo
    {
        public string CommonName => "Niger";
        public string OfficialName => "Republic of Niger";
        public Alpha2Code Alpha2Code => Alpha2Code.NE;
        public Alpha3Code Alpha3Code => Alpha3Code.NER;
        public int NumericCode => 562;
        public string[] TLD => new [] { ".ne" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.BJ,
            Alpha2Code.BF,
            Alpha2Code.TD,
            Alpha2Code.LY,
            Alpha2Code.ML,
            Alpha2Code.NG,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "227" };
    }
}
