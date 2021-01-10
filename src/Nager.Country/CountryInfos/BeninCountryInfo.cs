using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Benin
    /// </summary>
    public class BeninCountryInfo : ICountryInfo
    {
        public string CommonName => "Benin";
        public string OfficialName => "Republic of Benin";
        public Alpha2Code Alpha2Code => Alpha2Code.BJ;
        public Alpha3Code Alpha3Code => Alpha3Code.BEN;
        public int NumericCode => 204;
        public string[] TLD => new [] { ".bj" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BF,
            Alpha2Code.NE,
            Alpha2Code.NG,
            Alpha2Code.TG,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "229" };
    }
}
