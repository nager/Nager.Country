using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Barbados
    /// </summary>
    public class BarbadosCountryInfo : ICountryInfo
    {
        public string CommonName => "Barbados";
        public string OfficialName => "Barbados";
        public Alpha2Code Alpha2Code => Alpha2Code.BB;
        public Alpha3Code Alpha3Code => Alpha3Code.BRB;
        public int NumericCode => 052;
        public string[] TLD => new [] { ".bb" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new BbdCurrency() };
        public string[] CallingCodes => new [] { "1246" };
    }
}
