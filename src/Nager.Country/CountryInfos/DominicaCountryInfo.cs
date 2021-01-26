using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Dominica
    /// </summary>
    public class DominicaCountryInfo : ICountryInfo
    {
        public string CommonName => "Dominica";
        public string OfficialName => "Commonwealth of Dominica";
        public Alpha2Code Alpha2Code => Alpha2Code.DM;
        public Alpha3Code Alpha3Code => Alpha3Code.DMA;
        public int NumericCode => 212;
        public string[] TLD => new [] { ".dm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1767" };
    }
}
