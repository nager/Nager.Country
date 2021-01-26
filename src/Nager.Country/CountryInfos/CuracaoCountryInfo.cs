using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Curaçao
    /// </summary>
    public class CuracaoCountryInfo : ICountryInfo
    {
        public string CommonName => "Curaçao";
        public string OfficialName => "Country of Curaçao";
        public Alpha2Code Alpha2Code => Alpha2Code.CW;
        public Alpha3Code Alpha3Code => Alpha3Code.CUW;
        public int NumericCode => 531;
        public string[] TLD => new [] { ".cw" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AngCurrency() };
        public string[] CallingCodes => new [] { "5999" };
    }
}
