using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sweden
    /// </summary>
    public class SwedenCountryInfo : ICountryInfo
    {
        public string CommonName => "Sweden";
        public string OfficialName => "Kingdom of Sweden";
        public Alpha2Code Alpha2Code => Alpha2Code.SE;
        public Alpha3Code Alpha3Code => Alpha3Code.SWE;
        public int NumericCode => 752;
        public string[] TLD => new [] { ".se" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FI,
            Alpha2Code.NO,
        };

        public ICurrency[] Currencies => new [] { new SekCurrency() };
        public string[] CallingCodes => new [] { "46" };
    }
}
