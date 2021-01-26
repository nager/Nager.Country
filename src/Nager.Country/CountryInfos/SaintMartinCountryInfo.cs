using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Martin
    /// </summary>
    public class SaintMartinCountryInfo : ICountryInfo
    {
        public string CommonName => "Saint Martin";
        public string OfficialName => "Saint Martin";
        public Alpha2Code Alpha2Code => Alpha2Code.MF;
        public Alpha3Code Alpha3Code => Alpha3Code.MAF;
        public int NumericCode => 663;
        public string[] TLD => new [] { ".fr", ".gp" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SX,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "590" };
    }
}
