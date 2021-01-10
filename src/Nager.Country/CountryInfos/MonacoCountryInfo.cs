using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Monaco
    /// </summary>
    public class MonacoCountryInfo : ICountryInfo
    {
        public string CommonName => "Monaco";
        public string OfficialName => "Principality of Monaco";
        public Alpha2Code Alpha2Code => Alpha2Code.MC;
        public Alpha3Code Alpha3Code => Alpha3Code.MCO;
        public int NumericCode => 492;
        public string[] TLD => new [] { ".mc" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FR,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "377" };
    }
}
