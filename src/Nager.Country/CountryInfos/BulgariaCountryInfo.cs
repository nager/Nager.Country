using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bulgaria
    /// </summary>
    public class BulgariaCountryInfo : ICountryInfo
    {
        public string CommonName => "Bulgaria";
        public string OfficialName => "Republic of Bulgaria";
        public Alpha2Code Alpha2Code => Alpha2Code.BG;
        public Alpha3Code Alpha3Code => Alpha3Code.BGR;
        public int NumericCode => 100;
        public string[] TLD => new [] { ".bg" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GR,
            Alpha2Code.MK,
            Alpha2Code.RO,
            Alpha2Code.RS,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new BgnCurrency() };
        public string[] CallingCodes => new [] { "359" };
    }
}
