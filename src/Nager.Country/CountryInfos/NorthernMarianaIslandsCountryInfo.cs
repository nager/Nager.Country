using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    public class NorthernMarianaIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Northern Mariana Islands";
        public string OfficialName => "Commonwealth of the Northern Mariana Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.MP;
        public Alpha3Code Alpha3Code => Alpha3Code.MNP;
        public int NumericCode => 580;
        public string[] TLD => new [] { ".mp" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1670" };
    }
}
