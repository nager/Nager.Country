using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Haiti
    /// </summary>
    public class HaitiCountryInfo : ICountryInfo
    {
        public string CommonName => "Haiti";
        public string OfficialName => "Republic of Haiti";
        public Alpha2Code Alpha2Code => Alpha2Code.HT;
        public Alpha3Code Alpha3Code => Alpha3Code.HTI;
        public int NumericCode => 332;
        public string[] TLD => new [] { ".ht" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DO,
        };

        public ICurrency[] Currencies => new ICurrency[] { new HtgCurrency(), new UsdCurrency() };
        public string[] CallingCodes => new [] { "509" };
    }
}
