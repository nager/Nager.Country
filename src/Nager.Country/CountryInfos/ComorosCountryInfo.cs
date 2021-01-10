using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Comoros
    /// </summary>
    public class ComorosCountryInfo : ICountryInfo
    {
        public string CommonName => "Comoros";
        public string OfficialName => "Union of the Comoros";
        public Alpha2Code Alpha2Code => Alpha2Code.KM;
        public Alpha3Code Alpha3Code => Alpha3Code.COM;
        public int NumericCode => 174;
        public string[] TLD => new [] { ".km" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new KmfCurrency() };
        public string[] CallingCodes => new [] { "269" };
    }
}
