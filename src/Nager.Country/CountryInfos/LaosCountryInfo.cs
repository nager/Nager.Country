using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Laos
    /// </summary>
    public class LaosCountryInfo : ICountryInfo
    {
        public string CommonName => "Laos";
        public string OfficialName => "Lao People's Democratic Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.LA;
        public Alpha3Code Alpha3Code => Alpha3Code.LAO;
        public int NumericCode => 418;
        public string[] TLD => new [] { ".la" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MM,
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.TH,
            Alpha2Code.VN,
        };

        public ICurrency[] Currencies => new [] { new LakCurrency() };
        public string[] CallingCodes => new [] { "856" };
    }
}
