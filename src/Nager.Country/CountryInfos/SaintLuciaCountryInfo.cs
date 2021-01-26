using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Lucia
    /// </summary>
    public class SaintLuciaCountryInfo : ICountryInfo
    {
        public string CommonName => "Saint Lucia";
        public string OfficialName => "Saint Lucia";
        public Alpha2Code Alpha2Code => Alpha2Code.LC;
        public Alpha3Code Alpha3Code => Alpha3Code.LCA;
        public int NumericCode => 662;
        public string[] TLD => new [] { ".lc" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1758" };
    }
}
