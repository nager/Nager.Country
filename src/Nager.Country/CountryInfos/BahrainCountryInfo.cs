using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bahrain
    /// </summary>
    public class BahrainCountryInfo : ICountryInfo
    {
        public string CommonName => "Bahrain";
        public string OfficialName => "Kingdom of Bahrain";
        public Alpha2Code Alpha2Code => Alpha2Code.BH;
        public Alpha3Code Alpha3Code => Alpha3Code.BHR;
        public int NumericCode => 048;
        public string[] TLD => new [] { ".bh" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new BhdCurrency() };
        public string[] CallingCodes => new [] { "973" };
    }
}
