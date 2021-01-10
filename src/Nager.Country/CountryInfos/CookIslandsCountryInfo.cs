using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cook Islands
    /// </summary>
    public class CookIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Cook Islands";
        public string OfficialName => "Cook Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.CK;
        public Alpha3Code Alpha3Code => Alpha3Code.COK;
        public int NumericCode => 184;
        public string[] TLD => new [] { ".ck" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        public string[] CallingCodes => new [] { "682" };
    }
}
