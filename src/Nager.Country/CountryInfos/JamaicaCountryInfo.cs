using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Jamaica
    /// </summary>
    public class JamaicaCountryInfo : ICountryInfo
    {
        public string CommonName => "Jamaica";
        public string OfficialName => "Jamaica";
        public Alpha2Code Alpha2Code => Alpha2Code.JM;
        public Alpha3Code Alpha3Code => Alpha3Code.JAM;
        public int NumericCode => 388;
        public string[] TLD => new [] { ".jm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new JmdCurrency() };
        public string[] CallingCodes => new [] { "1876" };
    }
}
