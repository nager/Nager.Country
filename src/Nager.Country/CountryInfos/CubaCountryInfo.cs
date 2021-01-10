using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cuba
    /// </summary>
    public class CubaCountryInfo : ICountryInfo
    {
        public string CommonName => "Cuba";
        public string OfficialName => "Republic of Cuba";
        public Alpha2Code Alpha2Code => Alpha2Code.CU;
        public Alpha3Code Alpha3Code => Alpha3Code.CUB;
        public int NumericCode => 192;
        public string[] TLD => new [] { ".cu" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new ICurrency[] { new CucCurrency(), new CupCurrency() };
        public string[] CallingCodes => new [] { "53" };
    }
}
