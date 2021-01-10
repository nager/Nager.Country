using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vietnam
    /// </summary>
    public class VietnamCountryInfo : ICountryInfo
    {
        public string CommonName => "Vietnam";
        public string OfficialName => "Socialist Republic of Vietnam";
        public Alpha2Code Alpha2Code => Alpha2Code.VN;
        public Alpha3Code Alpha3Code => Alpha3Code.VNM;
        public int NumericCode => 704;
        public string[] TLD => new [] { ".vn" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.LA,
        };

        public ICurrency[] Currencies => new [] { new VndCurrency() };
        public string[] CallingCodes => new [] { "84" };
    }
}
